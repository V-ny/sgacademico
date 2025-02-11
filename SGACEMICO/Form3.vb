Public Class Form3
    Private Sub ALUNOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUNOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUNOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2023DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.Escola2023DataSet.ALUNO)

    End Sub
End Class