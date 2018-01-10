Imports System.Net
Imports System.Net.NetworkInformation
Public Class Form1

    Dim CurrentNetworkInterface As NetworkInterface
Delegate Sub FuncCallback(ByRef obj As Object, ByVal text As String)
    Dim NetInts As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

    Private Function inArrayNetType(ByVal arr As NetworkInterfaceType(), ByVal match As NetworkInterfaceType) As Boolean
        For Each nettype As NetworkInterfaceType In arr
            If nettype = match Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetNetInteface() As List(Of NetworkInterface)
        Dim NetInts = NetworkInterface.GetAllNetworkInterfaces
        Dim NetList As New List(Of NetworkInterface)
        Dim NetInterfaceFilter As NetworkInterfaceType() = {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
        For Each NetInt As NetworkInterface In NetInts
            If inArrayNetType(NetInterfaceFilter, NetInt.NetworkInterfaceType) Then
                NetList.Add(NetInt)
            End If
        Next
        Return NetList
    End Function

    Private Sub LoadNicComboBox()
        NetInts = NetworkInterface.GetAllNetworkInterfaces
        Dim NetInterfaceFilter As NetworkInterfaceType() = {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
        If CBNetInts.InvokeRequired Then
            Dim d As New FuncCallback(AddressOf LoadNicComboBox)
            Me.Invoke(d, New Object() {Nothing, Nothing})
        Else
            CBNetInts.DataSource = GetNetInteface()
            CBNetInts.DisplayMember = "Name"
            CBNetInts.ValueMember = "Id"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNicComboBox()
        Dim HostName As String
        Dim IPAdds() As IPAddress
        HostName = System.Net.Dns.GetHostName()
        IPAdds = Dns.GetHostAddresses(HostName)
        For i = 0 To IPAdds.Count - 2
            IPAddIn.Text = "Internal IP Address: " & (IPAdds(i).ToString)
        Next
        'Using wb As New WebClient
        '    Dim s As String = wb.DownloadString("http://www.whatsmyip.us/showipsimple.php")
        '    Dim l As String = s.Remove(0, 16)
        '    Dim j As String = l.Remove(l.Length - 3, 3)
        '    IPAddEx.Text = "External IP Address: " & j
        'End Using
    End Sub

    Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles TmrStatus.Tick
        If My.Computer.Network.IsAvailable = True Then
            LblStatus.Text = "Status: Connected"
            Dim NetSpd As Decimal = CurrentNetworkInterface.Speed / 1024 / 1024
            Dim NetSpdR = Math.Truncate(NetSpd)
            SpdLbl.Text = "Speed: " & NetSpdR & " Mbits/s"
            DatSent.Text = "Data Sent: " & Math.Truncate(CurrentNetworkInterface.GetIPv4Statistics.BytesSent / 1024) & " KB"
            DatRcvd.Text = "Data Received: " & Math.Truncate(CurrentNetworkInterface.GetIPv4Statistics.BytesReceived / 1024) & " KB"
        Else
            LblStatus.Text = "Status: No Internet Access"
        End If
    End Sub

    Private Sub CBNetInts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNetInts.SelectedIndexChanged
        CurrentNetworkInterface = CBNetInts.SelectedItem
        Dim IpInterface As IPInterfaceProperties = CurrentNetworkInterface.GetIPProperties
        Dim UnicastIpaddr As UnicastIPAddressInformationCollection = IpInterface.UnicastAddresses
    End Sub
End Class