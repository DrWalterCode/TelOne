Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports Microsoft.Win32
Imports System.Runtime.InteropServices

''' <summary>
''' Class FrmLogin.
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmLogin
    Public usergroup As String
    Public phone As String
    Public lblUsername As String

    ''' <summary>
    ''' The con
    ''' </summary>
    Dim _con As MySqlConnection

    ''' <summary>
    ''' The command
    ''' </summary>
    Dim _cmd As MySqlCommand

    ''' <summary>
    ''' The timercount
    ''' </summary>
    Dim _timercount As Integer = 60 'The number of seconds

    ''' <summary>
    ''' The lastrecordday
    ''' </summary>
    Dim _lastrecordday As String

    ''' <summary>
    ''' The resultnumber
    ''' </summary>
    Dim _resultnumber As Integer

    ''' <summary>
    ''' Sends the message.
    ''' </summary>
    ''' <param name="hWnd">The h WND.</param>
    ''' <param name="msg">The MSG.</param>
    ''' <param name="wParam">The w parameter.</param>
    ''' <param name="lParam">The l parameter.</param>
    ''' <returns>Int32.</returns>
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    ''' <summary>
    ''' Changeformats this instance.
    ''' </summary>
    Private Sub Changeformat()
        Try
            Dim keyName As String =
                    Registry.CurrentUser.ToString() & "\Control Panel\International"

            Dim valueName As String = "sShortDate"

            Dim s As String =
                    Registry.GetValue(keyName, valueName, String.Empty).ToString()

            Registry.SetValue(keyName, valueName, "dd.MM.yyyy")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Checkconnections this instance.
    ''' </summary>
    Private Sub Checkconnection()
        Try
            Dim connectionString = ConnectionStrings("myConnection").ConnectionString
            _con = New MySqlConnection(connectionString)
            _con.Open()
        Catch ex As Exception
            MsgBox("Failed to establish connection")
            FrmDatabaseSetup.ShowDialog()
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Load event of the FrmLogin control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SendMessage(Me.txtpwd.Handle, &H1501, 0, "Enter password here...")
        SendMessage(Me.txtusername.Handle, &H1501, 0, "Enter system username...")

        Changeformat()
        Checkconnection()
        txtusername.Select()
        'FrmLicensing.ShowDialog()

    End Sub

    ''' <summary>
    ''' Handles the Tick event of the Timer2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label7.Text = _timercount.ToString() 'show the countdown in the label
        If _timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Timer1.Enabled = False
            Label7.Text = "Done"
        Else 'If timercount is higher then 0 then subtract one from it
            _timercount -= 1
        End If
    End Sub

    ''' <summary>
    ''' Logins this instance.
    ''' </summary>
    Private Sub Login()
        Try
            Dim connectionString = ConnectionStrings("myConnection").ConnectionString
            _con = New MySqlConnection(connectionString)
            _con.Open()
            _cmd =
                New MySqlCommand(
                    "Select * from users where username = '" + txtusername.Text + "' ",
                    _con)
            Dim reader = _cmd.ExecuteReader()
            If reader.Read() = True Then
                _cmd.Dispose()
                _con.Close()
                lblerror.Visible = True
                lblerror.Text = "Login Successful"
                ProgressPanel1.Visible = True
                Timer2.Interval = 1000
                Timer2.Start()
            Else
                lblerror.Visible = True
                lblerror.Text = "Login Details not yet verified !! "
            End If
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '_cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
        _cmd.Dispose()
        _con.Close()
    End Sub

    ''' <summary>
    ''' Handles the TextChanged event of the txtpwd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        Login()
    End Sub

    ''' <summary>
    ''' Handles the FormClosing event of the FrmLogin control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _con.Close()
    End Sub

    ''' <summary>
    ''' Handles the KeyDown event of the FrmLogin control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim ans As String
            ans = MsgBox("Are you sure you want to Exit System?", vbYesNo + vbQuestion, "Caution")
            If ans = vbYes Then
                Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event of the LinkLabel1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Passwordrecover.ShowDialog()
    End Sub

    '
    Private Sub Label7_TextChanged(sender As Object, e As EventArgs) Handles Label7.TextChanged
        If Label7.Text = "58" Then
            Timer2.Stop()
            _timercount = 60
            ProgressPanel1.Visible = False
            lblUsername = txtusername.Text

            Dim myForm As New TelOneMain() 'go to the menu after logging in
            Hide() ' temporarily hide the log in form
            lblUsername = txtusername.Text
            myForm.ShowDialog()
            Show()  ' when user closes the menu, show the form again
            'FrmHomePage.ShowDialog()
            Label7.Text = ""
            txtusername.Select()
            'txtpwd.Text = ""
            txtusername.Text = ""
            lblerror.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the SimpleButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    ''' <summary>
    ''' Handles the MouseHover event of the LinkLabel3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub LinkLabel3_MouseHover(sender As Object, e As EventArgs)
        'label2.Visible=True
    End Sub

    ''' <summary>
    ''' Handles the Click event of the SimpleButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        FrmDatabaseSetup.ShowDialog()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        Try
            _con.Close()
            _con.Open()
            _cmd = New MySqlCommand("select distinct(usergroup),phone from users where username='" & txtusername.Text & "'  ", _con)
            Dim dr As MySqlDataReader = _cmd.ExecuteReader()
            While dr.Read()
                Dim str As String = dr.GetString("usergroup").ToString()
                Dim str2 As String = dr.GetString("phone").ToString()
                If String.IsNullOrEmpty(str) Then
                Else
                    usergroup = str
                    phone = str2
                End If
            End While
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '         _cmd.Dispose()
            _con.Close()
        End Try
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Passwordrecover.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Passwordrecover.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        frmRegister.ShowDialog()
    End Sub

    Private Sub txtusername_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtusername.MaskInputRejected

    End Sub
End Class