<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Escola2023DataSet = New SGACEMICO.escola2023DataSet()
        Me.CONSULTABOLETIMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTABOLETIMTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.CONSULTABOLETIMTableAdapter()
        Me.TableAdapterManager = New SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager()
        Me.CONSULTABOLETIMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CONSULTABOLETIMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ALUNOToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ALUNOToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CONSULTABOLETIMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.ALUNOTableAdapter()
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTABOLETIMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTABOLETIMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTABOLETIMBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.CONSULTABOLETIMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Escola2023DataSet
        '
        Me.Escola2023DataSet.DataSetName = "escola2023DataSet"
        Me.Escola2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTABOLETIMBindingSource
        '
        Me.CONSULTABOLETIMBindingSource.DataMember = "CONSULTABOLETIM"
        Me.CONSULTABOLETIMBindingSource.DataSource = Me.Escola2023DataSet
        '
        'CONSULTABOLETIMTableAdapter
        '
        Me.CONSULTABOLETIMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Nothing
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONSULTABOLETIMBindingNavigator
        '
        Me.CONSULTABOLETIMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONSULTABOLETIMBindingNavigator.BindingSource = Me.CONSULTABOLETIMBindingSource
        Me.CONSULTABOLETIMBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONSULTABOLETIMBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONSULTABOLETIMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONSULTABOLETIMBindingNavigatorSaveItem})
        Me.CONSULTABOLETIMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTABOLETIMBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONSULTABOLETIMBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONSULTABOLETIMBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONSULTABOLETIMBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONSULTABOLETIMBindingNavigator.Name = "CONSULTABOLETIMBindingNavigator"
        Me.CONSULTABOLETIMBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONSULTABOLETIMBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CONSULTABOLETIMBindingNavigator.TabIndex = 0
        Me.CONSULTABOLETIMBindingNavigator.Text = "BindingNavigator1"
        Me.CONSULTABOLETIMBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'CONSULTABOLETIMBindingNavigatorSaveItem
        '
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.Enabled = False
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONSULTABOLETIMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.Name = "CONSULTABOLETIMBindingNavigatorSaveItem"
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.CONSULTABOLETIMBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALUNOToolStripLabel, Me.ALUNOToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        Me.FillToolStrip.Visible = False
        '
        'ALUNOToolStripLabel
        '
        Me.ALUNOToolStripLabel.Name = "ALUNOToolStripLabel"
        Me.ALUNOToolStripLabel.Size = New System.Drawing.Size(50, 22)
        Me.ALUNOToolStripLabel.Text = "ALUNO:"
        '
        'ALUNOToolStripTextBox
        '
        Me.ALUNOToolStripTextBox.Name = "ALUNOToolStripTextBox"
        Me.ALUNOToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'CONSULTABOLETIMDataGridView
        '
        Me.CONSULTABOLETIMDataGridView.AutoGenerateColumns = False
        Me.CONSULTABOLETIMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTABOLETIMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CONSULTABOLETIMDataGridView.DataSource = Me.CONSULTABOLETIMBindingSource
        Me.CONSULTABOLETIMDataGridView.Location = New System.Drawing.Point(96, 160)
        Me.CONSULTABOLETIMDataGridView.Name = "CONSULTABOLETIMDataGridView"
        Me.CONSULTABOLETIMDataGridView.Size = New System.Drawing.Size(428, 220)
        Me.CONSULTABOLETIMDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ALUNO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ALUNO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CURSO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CURSO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aluno:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ALUNOBindingSource
        Me.ComboBox1.DisplayMember = "NOME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "NOME"
        '
        'ALUNOBindingSource
        '
        Me.ALUNOBindingSource.DataMember = "ALUNO"
        Me.ALUNOBindingSource.DataSource = Me.Escola2023DataSet
        '
        'ALUNOTableAdapter
        '
        Me.ALUNOTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONSULTABOLETIMDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.CONSULTABOLETIMBindingNavigator)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTABOLETIMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTABOLETIMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTABOLETIMBindingNavigator.ResumeLayout(False)
        Me.CONSULTABOLETIMBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.CONSULTABOLETIMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Escola2023DataSet As escola2023DataSet
    Friend WithEvents CONSULTABOLETIMBindingSource As BindingSource
    Friend WithEvents CONSULTABOLETIMTableAdapter As escola2023DataSetTableAdapters.CONSULTABOLETIMTableAdapter
    Friend WithEvents TableAdapterManager As escola2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTABOLETIMBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CONSULTABOLETIMBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents ALUNOToolStripLabel As ToolStripLabel
    Friend WithEvents ALUNOToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents CONSULTABOLETIMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ALUNOTableAdapter As escola2023DataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents ALUNOBindingSource As BindingSource
End Class
