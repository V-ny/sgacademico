Public Class Form7
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CONSULTABOLETIMTableAdapter.Fill(Me.Escola2023DataSet.CONSULTABOLETIM, ALUNOToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.CONSULTABOLETIMTableAdapter.Fill(Me.Escola2023DataSet.CONSULTABOLETIM, ComboBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.Escola2023DataSet.ALUNO)

    End Sub
End Class