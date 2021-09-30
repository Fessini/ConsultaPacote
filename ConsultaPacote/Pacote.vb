Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Public Class Pacote
    Public Function ObterPacote(codigo As String) As Rastreio
        Dim strEnd As String = String.Format("https://proxyapp.correios.com.br/v1/sro-rastro/{0}", codigo)
        Dim result As Rastreio

        Try
            Dim wc As New WebClient
            wc.Encoding = Encoding.UTF8
            Dim strJson As String = wc.DownloadString(strEnd)

            result = JsonConvert.DeserializeObject(Of Rastreio)(strJson)

            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
