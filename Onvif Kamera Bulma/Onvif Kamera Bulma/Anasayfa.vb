Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Xml


Public Class Anasayfa
    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'Dim XmlKonturDataset As New DataSet
        'XmlKonturDataset.ReadXml(New IO.StringReader(RichTextBox3.Text))



        'MsgBox(XmlKonturDataset.Tables("ProbeMatch").Rows(0).Item("Scopes"))
        'MsgBox(XmlKonturDataset.Tables("ProbeMatch").Rows(0).Item("XAddrs"))




    End Sub

    Private Sub Ara_Buton_Click(sender As Object, e As EventArgs) Handles Ara_Buton.Click
        Dim XmlPostData As String = richTextBox1.Text

        Dim MulticastingAdres As IPAddress = Net.IPAddress.Parse("239.255.255.250")
        Dim MulticastingOnvifPort = 3702


        Dim IPEndPointer As Net.IPEndPoint = New IPEndPoint(MulticastingAdres, MulticastingOnvifPort)


        Dim Udp_Client As New UdpClient
        Udp_Client.MulticastLoopback = True
        Udp_Client.Client.MulticastLoopback = False ' Yazdığımız Data Geri Gelmesin Diye...

        ' ***************************** Bu Grup Aktif Edilirse Sorunun ve Cevabın Hangi IP Adresi Üzerinden Geleceğini Belirtmek Zorundayız.*************************************

        'Dim LocalIPAdresi As IPAddress = IPAddress.Parse("192.168.1.13")
        'Udp_Client.JoinMulticastGroup(MulticastingAdres, LocalIPAdresi) 'Multicast Grubuna Ekliyoruz..iST
        'Udp_Client.Client.Bind(New IPEndPoint(LocalIPAdresi, MulticastingOnvifPort))

        '*********************************************************************************************************************************************************************


        Dim HdsData() As Byte = Encoding.ASCII.GetBytes(XmlPostData)
        Udp_Client.Send(HdsData, HdsData.Length, IPEndPointer)
        Udp_Client.Client.ReceiveTimeout = 1000 ' 1 Saniye Bekler Ve Cevap Gelmediğinde Hataya Düşer. 

        Try

            Do

                Dim Bytesx() As Byte = Udp_Client.Receive(IPEndPointer)
                Dim GelenData As String = Encoding.GetEncoding("ISO-8859-9").GetString(Bytesx)


                Dim XmlKonturDataset As New DataSet
                XmlKonturDataset.ReadXml(New IO.StringReader(GelenData))
                Dim IPParse() As String = XmlKonturDataset.Tables("ProbeMatch").Rows(0).Item("XAddrs").ToString.Split("/")
                Dim ModelVs() As String = XmlKonturDataset.Tables("ProbeMatch").Rows(0).Item("Scopes").ToString.Split(" ")
                Dim Adı As String = ""
                Dim index As Integer
                For i = 0 To ModelVs.Count - 1

                    Adı = ModelVs(i).ToString
                    index = Adı.IndexOf("name")
                    If index >= 0 Then
                        Adı = Adı.Substring(index + 5, Adı.Length - index - 5)
                        Exit For
                    End If

                Next
                If index >= 0 Then
                    ListBox1.Items.Add(Adı & " " & IPParse(2))
                Else
                    ListBox1.Items.Add("No Name" & " " & IPParse(2))
                End If



            Loop
        Catch ex As Exception


        End Try




    End Sub
End Class
