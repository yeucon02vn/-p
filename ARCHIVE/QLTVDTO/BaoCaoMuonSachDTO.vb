Public Class BaoCaoMuonSachDTO
    Private strtentheloai As String
    Private isoluotmuon As Integer
    Private itile As Integer
    Public Sub New()

    End Sub
    Public Sub New(Tentheloai As String, Soluotmuon As Integer, Tile As Integer)
        Me.strtentheloai = Tentheloai
        Me.isoluotmuon = Soluotmuon
        Me.itile = Tile
    End Sub
    Property Tentheloai() As String
        Get
            Return Me.strtentheloai
        End Get
        Set(value As String)
            Me.strtentheloai = value
        End Set
    End Property
    Property Soluotmuon() As Integer
        Get
            Return Me.isoluotmuon
        End Get
        Set(value As Integer)
            Me.isoluotmuon = value
        End Set
    End Property
    Property Tile() As Integer
        Get
            Return Me.itile
        End Get
        Set(value As Integer)
            Me.itile = value
        End Set
    End Property

End Class
