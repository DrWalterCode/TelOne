Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net

Public Class Passwordrecover
    Dim _ApplicationID As String
    Dim _cmd As MySqlCommand
    ReadOnly _con As MySqlConnection = New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim Passwordpassword As String

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If txtCell.Text = "" Then
            MsgBox("Enter cell number first")
            Exit Sub
        End If
        Try
            _con.Close()
            _con.Open()
            _cmd =
                New MySqlCommand(
                   "Select distinct(password) from users where phone ='" & txtCell.Text & "' ", _con)
            Passwordpassword = _cmd.ExecuteScalar
            _cmd.Dispose()
            _con.Close()

            Dim smsStatus As String
            smsStatus = SendSMS("TelOne_Demo", "f3d523a27b2aea585b9466f218d40f64", txtCell.Text, "Your recoverd password is : " + Passwordpassword)
            MessageBox.Show(smsStatus)
            Dispose()

        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
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
            Dim URL As String = "http://portal.bulksmsweb.com/index.php?app=ws&u=" & username & "&h=" & webservicesToken & " &op=pv&to=" & receipientMobileNumber & "&msg=" & SMSMessage
            SmsStatusMsg = client.DownloadString(URL)
            If SmsStatusMsg.Contains(“""status"":""OK""”) Then
                SmsStatusMsg = "Successfully Recovered Password"
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
    Private Sub Passwordrecover_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Passwordrecover_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

End Class