Public Class Endereco
    Public Property cidade As String
    Public Property uf As String
End Class

Public Class Unidade
    Public Property endereco As Endereco
    Public Property tipo As String
End Class

Public Class UnidadeDestino
    Public Property endereco As Endereco
    Public Property tipo As String
End Class

Public Class Evento
    Public Property codigo As String
    Public Property descricao As String
    Public Property dtHrCriado As DateTime
    Public Property tipo As String
    Public Property unidade As Unidade
    Public Property unidadeDestino As UnidadeDestino
    Public Property urlIcone As String
End Class

Public Class TipoPostal
    Public Property categoria As String
    Public Property descricao As String
    Public Property sigla As String
End Class

Public Class Objeto
    Public Property codObjeto As String
    Public Property eventos As List(Of Evento)
    Public Property modalidade As String
    Public Property tipoPostal As TipoPostal
    Public Property habilitaAutoDeclaracao As Boolean
    Public Property permiteEncargoImportacao As Boolean
    Public Property habilitaPercorridaCarteiro As Boolean
    Public Property bloqueioObjeto As Boolean
    Public Property possuiLocker As Boolean
    Public Property habilitaLocker As Boolean
    Public Property habilitaCrowdshipping As Boolean
End Class

Public Class Rastreio
    Public Property objetos As List(Of Objeto)
    Public Property quantidade As Integer
    Public Property resultado As String
    Public Property versao As String
End Class

