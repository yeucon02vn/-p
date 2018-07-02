Imports QLTVBUS
Imports QLTVDTO
Imports Utility
Public Class BaoCaoMuonTre
    Private baocaosachtreBUS As BaoCaoMuonTreBUS
    Private Sub txtbaocao_Click(sender As Object, e As EventArgs) Handles txtbaocao.Click
        Loadchitietbaocao()
    End Sub

    Private Sub BaoCaoMuonTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baocaosachtreBUS = New BaoCaoMuonTreBUS()
    End Sub
    Private Sub Loadchitietbaocao()
        Dim listmuonsachtre = New List(Of BaoCaoMunTreDTO)
        listmuonsachtre = baocaosachtreBUS.baocao()



        dgvbaocaomuontre.Columns.Clear()
        dgvbaocaomuontre.DataSource = Nothing

        dgvbaocaomuontre.AutoGenerateColumns = False
        dgvbaocaomuontre.AllowUserToAddRows = False
        dgvbaocaomuontre.DataSource = New BindingSource(listmuonsachtre, String.Empty)
        Dim cltensach = New DataGridViewTextBoxColumn()
        cltensach.Name = "Tensach"
        cltensach.HeaderText = "Tên Sách"
        cltensach.DataPropertyName = "Tensach"
        dgvbaocaomuontre.Columns.Add(cltensach)

        Dim clngaymuon = New DataGridViewTextBoxColumn()
        clngaymuon.Name = "Ngaymuon"
        clngaymuon.HeaderText = "Ngày Mượn"
        clngaymuon.DataPropertyName = "Ngaymuon"
        dgvbaocaomuontre.Columns.Add(clngaymuon)

        Dim clsongaytre = New DataGridViewTextBoxColumn()
        clsongaytre.Name = "Songaytre"
        clsongaytre.HeaderText = "Số Ngày Trể"
        clsongaytre.DataPropertyName = "Songaytre"
        dgvbaocaomuontre.Columns.Add(clsongaytre)
        dgvbaocaomuontre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class