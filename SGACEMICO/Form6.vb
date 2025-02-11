Public Class Form6
    Private Sub TURMABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TURMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TURMABindingSource.EndEdit()
        Me.MATRICULABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2023DataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.Escola2023DataSet.ALUNO)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.MATRICULA'. Você pode movê-la ou removê-la conforme necessário.
        Me.MATRICULATableAdapter.Fill(Me.Escola2023DataSet.MATRICULA)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.CURSO'. Você pode movê-la ou removê-la conforme necessário.
        Me.CURSOTableAdapter.Fill(Me.Escola2023DataSet.CURSO)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.PROFESSOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.PROFESSORTableAdapter.Fill(Me.Escola2023DataSet.PROFESSOR)
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.TURMA'. Você pode movê-la ou removê-la conforme necessário.
        Me.TURMATableAdapter.Fill(Me.Escola2023DataSet.TURMA)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim linha As DataGridViewRow
        Dim media As Double
        Dim cont As Integer

        For Each linha In MATRICULADataGridView.Rows
            media = media + linha.Cells(3).Value
            cont = cont + 1
        Next
        cont = cont - 1
        media = media / cont
        MEDIATextBox.Text = media
    End Sub
End Class