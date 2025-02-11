Public Class Form5
    Private Sub TURMABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TURMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TURMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2023DataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.MATRICULA'. Você pode movê-la ou removê-la conforme necessário.
        Me.MATRICULATableAdapter.Fill(Me.Escola2023DataSet.MATRICULA)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.CURSO'. Você pode movê-la ou removê-la conforme necessário.
        Me.CURSOTableAdapter.Fill(Me.Escola2023DataSet.CURSO)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.PROFESSOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.PROFESSORTableAdapter.Fill(Me.Escola2023DataSet.PROFESSOR)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.TURMA'. Você pode movê-la ou removê-la conforme necessário.
        Me.TURMATableAdapter.Fill(Me.Escola2023DataSet.TURMA)

    End Sub
End Class