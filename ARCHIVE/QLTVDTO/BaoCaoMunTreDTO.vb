Public Class BaoCaoMunTreDTO
    Private strtensach As String
    Private datengaymuon As DateTime
    Private isongaytre As Integer
    Public Sub New()

    End Sub
    Public Sub New(Tensach As String, Ngaymuon As DateTime, Songaytre As Integer)
        Me.strtensach = Tensach
        Me.datengaymuon = Ngaymuon
        Me.isongaytre = Songaytre
    End Sub
    Property Tensach() As String
        Get
            Return Me.strtensach
        End Get
        Set(value As String)
            Me.strtensach = value
        End Set
    End Property
    Property Ngaymuon() As DateTime
        Get
            Return Me.datengaymuon
        End Get
        Set(value As DateTime)
            Me.datengaymuon = value
        End Set
    End Property
    Property Songaytre() As Integer
        Get
            Return Me.isongaytre
        End Get
        Set(value As Integer)
            Me.isongaytre = value
        End Set
    End Property
End Class
