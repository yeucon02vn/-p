Public Class TinhtrangsachDTO
    Private intmatinhtrang As Integer
    Private strtentrinhtrang As String
    Public Sub New()

    End Sub
    Public Sub New(intMatinhtrang As Integer, strTentinhtrang As String)
        Me.intmatinhtrang = intMatinhtrang
        Me.strtentrinhtrang = strTentinhtrang
    End Sub
    Property Matinhtrang() As Integer
        Get
            Return Me.intmatinhtrang
        End Get
        Set(value As Integer)
            Me.intmatinhtrang = value
        End Set
    End Property
    Property tentinhtrang() As String
        Get
            Return strtentrinhtrang
        End Get
        Set(value As String)
            strtentrinhtrang = value
        End Set
    End Property
End Class
