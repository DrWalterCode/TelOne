Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net
Public Class TelOneMain
    Dim _cmd As MySqlCommand
    ReadOnly _con As MySqlConnection = New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _timercount As Integer = 60 'The number of seconds
    Dim logindate As String
    Dim logintime As String
    Dim menuchosen As String


    Dim CurrentData As Double

    Dim indeX As Integer = 0

    Dim yearend As String

    ''' <summary>
    ''' The realco identifier
    ''' </summary>
    Public realcoID As String

    ''' <summary>
    ''' The real company name
    ''' </summary>
    Public realcompanyname As String

    ''' <summary>
    ''' The user name
    ''' </summary>
    Public username As String


    Private ipv4Stats As IPv4InterfaceStatistics
    Private nic As NetworkInterface
    Private startUploaded, startDownloaded As Long

    Public Sub LoadgridLEADERBOARD()
        checkforBadges()
        _con.Close()
        Try
            Dim strQuery = "select * from leaderboard "
            _cmd = New MySqlCommand(strQuery)
            Dim getgriddata As New InsertUpdateData
            Dim dt As DataTable = getgriddata.GetData(_cmd)
            dgvLeader.DataSource = dt
            dgvLeader.FirstDisplayedScrollingRowIndex = dgvLeader.RowCount - 1
            dgvLeader.Rows(dgvLeader.RowCount - 1).Selected = True
            dgvLeader.CurrentCell = dgvLeader.Rows(dgvLeader.RowCount - 1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkforBadges()
        Try
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("select * from leaderboard where usernumber='" & FrmLogin.lblUsername & "'  ", _con)
            Dim dr As MySqlDataReader = _cmd.ExecuteReader()
            While dr.Read()
                Dim points As String = dr.GetString("points").ToString()
                If String.IsNullOrEmpty(points) Then
                    'MsgBox("You have no data, purchase data first")
                Else
                    If CDbl(points) > 90 Then
                        badge1.Visible = True
                        badge2.Visible = True
                        badge3.Visible = True
                    ElseIf CDbl(points) > 60 Then
                        badge1.Visible = True
                        badge2.Visible = True
                        badge3.Visible = False
                    ElseIf CDbl(points) > 30 Then
                        badge1.Visible = True
                        badge2.Visible = False
                        badge3.Visible = False
                    End If
                End If
            End While
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '         _cmd.Dispose()
            _con.Close()
        End Try
    End Sub

    Private Sub checkdataleft()
        Try
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("select * from currentmonth_usage_view where usernumber='" & FrmLogin.lblUsername & "'  ", _con)
            Dim dr As MySqlDataReader = _cmd.ExecuteReader()
            While dr.Read()
                Dim dataused As String = dr.GetString("usage").ToString()
                Dim databought As String = dr.GetString("data").ToString()
                If String.IsNullOrEmpty(databought) Then
                    MsgBox("You have no data, purchase data first")
                Else


                    CurrentData = CDbl(databought) - CDbl(dataused) - CDbl(LabelComponent2.Text)
                    If CurrentData <= 0 Then
                        'MsgBox("You have depleted your monthly package data")
                        Timer1.Stop()
                        Timer2.Stop()
                        closeApp()
                        Exit Sub
                    End If

                    Label14.Text = Math.Round(CurrentData, 2)


                    'If CurrentData <= 0 Then
                    '    MsgBox("You have depleted your monthly package data")
                    '    closeApp()
                    '    'Dispose()
                    'End If

                End If
            End While
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '         _cmd.Dispose()
            _con.Close()
        End Try
    End Sub
    Private Sub TelOneMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label14.Text = "0"
        LoadgridLEADERBOARD()
        Try
            txtusergroup.Text = FrmLogin.usergroup.ToUpper
            lblUsername.Text = FrmLogin.lblUsername.ToUpper
            txtnum.Text = FrmLogin.phone.ToUpper
        Catch ex As Exception

        End Try

        Try
            _con.Open()
            Dim logoutdate As String = "LOGGED IN"
            Dim logout As String = "LOGGED IN"
            logintime = Now.ToLongTimeString
            logindate = Now.Date.ToString("dd/MM/yyyy")
            timeIn.Text = logintime
            dateIn.Text = logindate
            _cmd =
                New MySqlCommand(
                    "INSERT into audit(loginDate,loginTime,logoutDate,logoutTime,username) values ('" +
                    logindate + "','" + logintime + "','" + logoutdate + "','" + logout + "','" + lblUsername.Text +
                    "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            'MsgBox(ex.Message)
        End Try

        ' don't sort combo items, index used to make selection!
        ComboBox1.Sorted = False
        ' pop list with network adapter names
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        For Each adapter As NetworkInterface In nics

            If adapter.Name = "Wi-Fi" Then
                ComboBox1.Items.Add("TELONE ADSL")
                ComboBox1.SelectedIndex = 0
                Exit Sub
            End If
            indeX = indeX + 1
        Next

        If txtusergroup.Text = "ADMIN" Then
            nphome.PageVisible = True
            npbrowse.PageVisible = True
            npreports.PageVisible = True
            npstats.PageVisible = True
            'npvoice.PageVisible = True
            nptelpay.PageVisible = True
            'npadmin.PageVisible = True
            npleaderboard.PageVisible = True
            nppoints.PageVisible = True

        End If


        If txtusergroup.Text = "CLIENT" Then
            nphome.PageVisible = True
            npbrowse.PageVisible = True
            npreports.PageVisible = True
            npstats.PageVisible = True
            'npvoice.PageVisible = True
            nptelpay.PageVisible = True
            'npadmin.PageVisible = False
            npleaderboard.PageVisible = True
            nppoints.PageVisible = True
        End If

    End Sub

    Private Sub dateIn_Click(sender As Object, e As EventArgs) Handles dateIn.Click

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateStats()
        Try
            ipv4Stats = nic.GetIPv4Statistics
            Label11.Text = String.Format("Downloaded: {0} bytes", ipv4Stats.BytesReceived - startDownloaded)
            Label10.Text = String.Format("Uploaded: {0} bytes", ipv4Stats.BytesSent - startUploaded)

            Dim totaldata As Double = CDbl(ipv4Stats.BytesReceived - startDownloaded) + CDbl(ipv4Stats.BytesSent - startUploaded)

            'UPLOAD
            ArcScaleComponent2.MaxValue = 10000
            ArcScaleComponent2.Value = Double.Parse((ipv4Stats.BytesSent - startUploaded) / 1048576)
            LabelComponent1.Text = String.Format("{0} ", (ipv4Stats.BytesSent - startUploaded) / 1048576)

            'DOWNLOAD
            ArcScaleComponent3.MaxValue = 10000
            ArcScaleComponent3.Value = Double.Parse((ipv4Stats.BytesReceived - startDownloaded) / 1048576)
            LabelComponent3.Text = String.Format("{0} ", (ipv4Stats.BytesReceived - startDownloaded) / 1048576)


            'TOTAL
            ArcScaleComponent1.MaxValue = 10000
            ArcScaleComponent1.Value = Double.Parse((totaldata) / 1048576)
            LabelComponent2.Text = String.Format("{0} ", Math.Round((totaldata) / 1048576, 2))
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs) Handles NavigationPane1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CurrentData <= 0 Then
            'MsgBox("You have depleted your monthly package data")
            Timer1.Stop()
            Timer2.Stop()
            closeApp()
            Exit Sub
        End If

        UpdateStats()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Label14.Text = "0" Then
            MsgBox("You have no data available")
            Exit Sub
        End If
        'For git
        ' select adapter to monitor...
        If ComboBox1.SelectedIndex > -1 Then
            nic = NetworkInterface.GetAllNetworkInterfaces(indeX)
            ipv4Stats = nic.GetIPv4Statistics
            ' save current Bytes
            startDownloaded = ipv4Stats.BytesReceived
            startUploaded = ipv4Stats.BytesSent
            ' update labels/stats
            UpdateStats()
            ' start timer/auto update stats
            Timer1.Interval = 1000
            Timer1.Start()
        End If
        WebBrowser1.Visible = True
        WebBrowser1.GoHome()
    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        NavigationPane1.SelectedPage = nptelpay
    End Sub
    Private Sub healhcheck()
        'very happy 
        StateIndicatorComponent1.StateIndex = 0
        'happy 
        StateIndicatorComponent1.StateIndex = 1
        'center 
        StateIndicatorComponent1.StateIndex = 2
        'sad 
        StateIndicatorComponent1.StateIndex = 3
        'very sad 
        StateIndicatorComponent1.StateIndex = 4
    End Sub
    Private Sub npstats_Paint(sender As Object, e As PaintEventArgs) Handles npstats.Paint

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        closeApp()
    End Sub

    Private Sub closeApp()
        Timer2.Stop()

        Try
            _cmd.Dispose()
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("INSERT into usages(`usage`,usernumber) values ('" + LabelComponent2.Text.Trim + "','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()
            'MsgBox("Package Purchased")



        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try


        WebBrowser1.Visible = False
        Label11.Text = "0 bytes"
        Label10.Text = "0 bytes"


        ArcScaleComponent2.Value = 0
        LabelComponent1.Text = "0"

        'DOWNLOAD

        ArcScaleComponent3.Value = 0
        LabelComponent3.Text = "0"


        'TOTAL
        ArcScaleComponent1.Value = 0
        LabelComponent2.Text = "0"
        Timer2.Stop()
        Dispose()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Try
            _con.Open()
            _cmd = New MySqlCommand("INSERT into payments(amount,package,data,usernumber) values ('25','Home Plus', '30000','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()
            'MsgBox("Package Purchased")

            _con.Open()
            _cmd = New MySqlCommand("INSERT into points(point,usernumber) values ('5','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()


            Dim smsStatus As String
            smsStatus = SendSMS("TelOne_Demo", "f3d523a27b2aea585b9466f218d40f64", txtnum.Text, "You have successfully purchased 30 gig of the Home plus package for $25 and received 5 points")
            MessageBox.Show(smsStatus)

            LoadgridLEADERBOARD()

        Catch ex As Exception
            _cmd.Dispose()
                _con.Close()
                MessageBox.Show(ex.Message, "Error")
            End Try


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        _cmd.Dispose()
        _con.Close()
        Try
            _con.Open()
            Dim logout As String = Now.ToLongTimeString
            Dim logoutdate As String = Now.Date.ToString("dd/MM/yyyy")
            _cmd =
                 New MySqlCommand(
                     "UPDATE audit set logoutDate='" + logoutdate + "',logoutTime='" + logout + "' where username='" + username +
                     "' and loginDate='" + logindate + "' and loginTime='" + logintime + "'", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()
            closeApp()
            Dispose()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
        'FrmLogin.Show()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Try
            _con.Open()
            _cmd = New MySqlCommand("INSERT into payments(amount,package,data,usernumber) values ('42','Home Premier', '60000','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()
            'MsgBox("Package Purchased")

            _con.Open()
            _cmd = New MySqlCommand("INSERT into points(point,usernumber) values ('10','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()

            Dim smsStatus As String
            smsStatus = SendSMS("TelOne_Demo", "f3d523a27b2aea585b9466f218d40f64", txtnum.Text, "You have successfully purchased 60 gig of the Home premier package for $42 and received 10 points")
            MessageBox.Show(smsStatus)
            LoadgridLEADERBOARD()

        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Try
            _con.Open()
            _cmd = New MySqlCommand("INSERT into payments(amount,package,data,usernumber) values ('89','Infinity Pro', '1000000','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()
            'MsgBox("Package Purchased")

            _con.Open()
            _cmd = New MySqlCommand("INSERT into points(point,usernumber) values ('30','" + FrmLogin.lblUsername.ToUpper + "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ' _cmd.Dispose()
            _con.Close()

            Dim smsStatus As String
            smsStatus = SendSMS("TelOne_Demo", "f3d523a27b2aea585b9466f218d40f64", txtnum.Text, "You have successfully purchased 1000 gig of the Infinity Pro package for $89 and received 30 points")
            MessageBox.Show(smsStatus)
            LoadgridLEADERBOARD()

        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub TelOneMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CurrentData <= 0 Then
            'MsgBox("You have depleted your monthly package data")
            Timer1.Stop()
            Timer2.Stop()
            'closeApp()
            Exit Sub
        End If
        checkdataleft()
    End Sub

    ''' <summary>
    ''' 'Function send Http request and returns the status of the message
    ''' </summary>
    ''' <param name="username">Account username </param>
    ''' <param name="webservicesToken">Webservices token. To get the web services token, login to the Bulk SMS system. Got To “My Account”, Then Click On “User Configuration”, And For the screen that comes up, copy the Webservices token.</param>
    ''' <param name="receipientMobileNumber">Receipient Mobile Number. You can put multiple number separated by comma</param>
    ''' <param name="SMSMessage">SMS Message </param>
    ''' <returns></returns>
    Private Function SendSMS(ByVal username As String, ByVal webservicesToken As String, ByVal receipientMobileNumber As String, ByVal SMSMessage As String) As String
        Dim SmsStatusMsg As String = String.Empty
        Try
            'Sending SMS To User
            Dim client As WebClient = New WebClient()
            Dim URL As String = "http://portal.zimtext.co.zw/index.php?app=ws&u=" & username & "&h=" & webservicesToken & " &op=pv&to=" & receipientMobileNumber & "&msg=" & SMSMessage
            SmsStatusMsg = client.DownloadString(URL)
            If SmsStatusMsg.Contains(“""status"":""OK""”) Then
                SmsStatusMsg = "Package Payment successful"
            Else
                If SmsStatusMsg.Contains(“""error"":""100""”) Then
                    SmsStatusMsg = "authentication failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""101""”) Then
                    SmsStatusMsg = "type of action is invalid or unknown"
                ElseIf SmsStatusMsg.Contains(“""error"":""102""”) Then
                    SmsStatusMsg = "one or more field empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""103""”) Then
                    SmsStatusMsg = "not enough credit for this operation"
                ElseIf SmsStatusMsg.Contains(“""error"":""104""”) Then
                    SmsStatusMsg = "webservice token is not available"
                ElseIf SmsStatusMsg.Contains(“""error"":""105""”) Then
                    SmsStatusMsg = "webservice token not enable for this user"
                ElseIf SmsStatusMsg.Contains(“""error"":""106""”) Then
                    SmsStatusMsg = "webservice token not allowed from this IP address"
                ElseIf SmsStatusMsg.Contains(“""error"":""200""”) Then
                    SmsStatusMsg = "send message failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""201""”) Then
                    SmsStatusMsg = "destination number or message is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""400""”) Then
                    SmsStatusMsg = "no delivery status available"
                ElseIf SmsStatusMsg.Contains(“""error"":""401""”) Then
                    SmsStatusMsg = "no delivery status retrieved and SMS still in queue"
                ElseIf SmsStatusMsg.Contains(“""error"":""402""”) Then
                    SmsStatusMsg = "no delivery status retrieved and SMS has been processed from queue"
                ElseIf SmsStatusMsg.Contains(“""error"":""501""”) Then
                    SmsStatusMsg = "no data returned or result is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""600""”) Then
                    SmsStatusMsg = "admin level authentication failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""601""”) Then
                    SmsStatusMsg = "inject message failed"
                ElseIf SmsStatusMsg.Contains(“""error"":""602""”) Then
                    SmsStatusMsg = "sender id or message is empty"
                ElseIf SmsStatusMsg.Contains(“""error"":""603""”) Then
                    SmsStatusMsg = "account addition failed due to missing data"
                End If

            End If
        Catch e1 As WebException
            SmsStatusMsg = e1.Message
        Catch e2 As Exception
            SmsStatusMsg = e2.Message
        End Try
        Return SmsStatusMsg
    End Function

    Private Sub TabPane2_SelectedPageIndexChanged(sender As Object, e As EventArgs) _
        Handles TabPane2.SelectedPageIndexChanged
        Try
            Select Case TabPane2.SelectedPageIndex
                Case 0
                    Dim report As New usagerepo
                    report.Parameters("USERNUMBER").Value = FrmLogin.lblUsername.ToUpper
                    ' Hide the Parameters UI from end-users.
                    report.Parameters("USERNUMBER").Visible = False
                    Me.DocumentViewer1.DocumentSource = report
                    report.CreateDocument(False)

                Case 1
                    Dim report As New pointsrepo
                    report.Parameters("USERNUMBER").Value = FrmLogin.lblUsername.ToUpper
                    ' Hide the Parameters UI from end-users.
                    report.Parameters("USERNUMBER").Visible = False
                    Me.DocumentViewer2.DocumentSource = report
                    report.CreateDocument(False)
                Case 2
                    Dim report As New paymentsrepo
                    report.Parameters("USERNUMBER").Value = FrmLogin.lblUsername.ToUpper
                    ' Hide the Parameters UI from end-users.
                    report.Parameters("USERNUMBER").Visible = False
                    Me.DocumentViewer3.DocumentSource = report
                    report.CreateDocument(False)

            End Select
        Catch ex As Exception

        End Try
    End Sub


End Class
