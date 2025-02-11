Public Class Form4
    Private Sub CURSOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CURSOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CURSOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2023DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.CURSO'. Você pode movê-la ou removê-la conforme necessário.
        Me.CURSOTableAdapter.Fill(Me.Escola2023DataSet.CURSO)

    End Sub
End Class