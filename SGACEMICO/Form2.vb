﻿Public Class Form2
    Private Sub PROFESSORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PROFESSORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROFESSORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2023DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Escola2023DataSet.PROFESSOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.PROFESSORTableAdapter.Fill(Me.Escola2023DataSet.PROFESSOR)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class