Public Class TheLoaiDTO
    Private imatheloai As Integer
    Private strtentheloai As String
    Public Sub New()

    End Sub
    Public Sub New(iMatheloai As Integer, strTentheloai As String)
        Me.imatheloai = iMatheloai
        Me.strtentheloai = strTentheloai
    End Sub
    Property Matheloai() As Integer
        Get
            Return Me.imatheloai
        End Get
        Set(value As Integer)
            Me.imatheloai = value
        End Set
    End Property
    Property Tentheloai() As String
        Get
            Return Me.strtentheloai
        End Get
        Set(value As String)
            Me.strtentheloai = value
        End Set
    End Property
End Class
