<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim DESCRICAOLabel As System.Windows.Forms.Label
        Dim CHLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Me.Escola2023DataSet = New SGACEMICO.escola2023DataSet()
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.CURSOTableAdapter()
        Me.TableAdapterManager = New SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager()
        Me.CURSOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CURSOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.DESCRICAOTextBox = New System.Windows.Forms.TextBox()
        Me.CHTextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        CODIGOLabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        DESCRICAOLabel = New System.Windows.Forms.Label()
        CHLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CURSOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Escola2023DataSet
        '
        Me.Escola2023DataSet.DataSetName = "escola2023DataSet"
        Me.Escola2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CURSOBindingSource
        '
        Me.CURSOBindingSource.DataMember = "CURSO"
        Me.CURSOBindingSource.DataSource = Me.Escola2023DataSet
        '
        'CURSOTableAdapter
        '
        Me.CURSOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CURSOBindingNavigator
        '
        Me.CURSOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CURSOBindingNavigator.BindingSource = Me.CURSOBindingSource
        Me.CURSOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CURSOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CURSOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CURSOBindingNavigatorSaveItem})
        Me.CURSOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CURSOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CURSOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CURSOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CURSOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CURSOBindingNavigator.Name = "CURSOBindingNavigator"
        Me.CURSOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CURSOBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CURSOBindingNavigator.TabIndex = 0
        Me.CURSOBindingNavigator.Text = "BindingNavigator1"
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
        'CURSOBindingNavigatorSaveItem
        '
        Me.CURSOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CURSOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CURSOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CURSOBindingNavigatorSaveItem.Name = "CURSOBindingNavigatorSaveItem"
        Me.CURSOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CURSOBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(100, 101)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(178, 98)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(234, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(100, 127)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(178, 124)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(234, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'DESCRICAOLabel
        '
        DESCRICAOLabel.AutoSize = True
        DESCRICAOLabel.Location = New System.Drawing.Point(100, 153)
        DESCRICAOLabel.Name = "DESCRICAOLabel"
        DESCRICAOLabel.Size = New System.Drawing.Size(72, 13)
        DESCRICAOLabel.TabIndex = 5
        DESCRICAOLabel.Text = "DESCRICAO:"
        '
        'DESCRICAOTextBox
        '
        Me.DESCRICAOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "DESCRICAO", True))
        Me.DESCRICAOTextBox.Location = New System.Drawing.Point(178, 150)
        Me.DESCRICAOTextBox.Name = "DESCRICAOTextBox"
        Me.DESCRICAOTextBox.Size = New System.Drawing.Size(234, 20)
        Me.DESCRICAOTextBox.TabIndex = 6
        '
        'CHLabel
        '
        CHLabel.AutoSize = True
        CHLabel.Location = New System.Drawing.Point(100, 179)
        CHLabel.Name = "CHLabel"
        CHLabel.Size = New System.Drawing.Size(25, 13)
        CHLabel.TabIndex = 7
        CHLabel.Text = "CH:"
        '
        'CHTextBox
        '
        Me.CHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "CH", True))
        Me.CHTextBox.Location = New System.Drawing.Point(178, 176)
        Me.CHTextBox.Name = "CHTextBox"
        Me.CHTextBox.Size = New System.Drawing.Size(234, 20)
        Me.CHTextBox.TabIndex = 8
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(100, 205)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 9
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(178, 202)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(234, 99)
        Me.OBSTextBox.TabIndex = 10
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(DESCRICAOLabel)
        Me.Controls.Add(Me.DESCRICAOTextBox)
        Me.Controls.Add(CHLabel)
        Me.Controls.Add(Me.CHTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.CURSOBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Sistema de Gerenciamento Acadêmico - Cadastro de Cursos"
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CURSOBindingNavigator.ResumeLayout(False)
        Me.CURSOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Escola2023DataSet As escola2023DataSet
    Friend WithEvents CURSOBindingSource As BindingSource
    Friend WithEvents CURSOTableAdapter As escola2023DataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents TableAdapterManager As escola2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CURSOBindingNavigator As BindingNavigator
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
    Friend WithEvents CURSOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents DESCRICAOTextBox As TextBox
    Friend WithEvents CHTextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
End Class
