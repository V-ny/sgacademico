<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim MATRICULALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim SOBRENOMELabel As System.Windows.Forms.Label
        Dim TELEFONELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Me.Escola2023DataSet = New SGACEMICO.escola2023DataSet()
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.ALUNOTableAdapter()
        Me.TableAdapterManager = New SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager()
        Me.ALUNOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ALUNOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MATRICULATextBox = New System.Windows.Forms.TextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.SOBRENOMETextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        MATRICULALabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        SOBRENOMELabel = New System.Windows.Forms.Label()
        TELEFONELabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUNOBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Escola2023DataSet
        '
        Me.Escola2023DataSet.DataSetName = "escola2023DataSet"
        Me.Escola2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ALUNOBindingNavigator
        '
        Me.ALUNOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUNOBindingNavigator.BindingSource = Me.ALUNOBindingSource
        Me.ALUNOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUNOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUNOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUNOBindingNavigatorSaveItem})
        Me.ALUNOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUNOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUNOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUNOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUNOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUNOBindingNavigator.Name = "ALUNOBindingNavigator"
        Me.ALUNOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUNOBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ALUNOBindingNavigator.TabIndex = 0
        Me.ALUNOBindingNavigator.Text = "BindingNavigator1"
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
        'ALUNOBindingNavigatorSaveItem
        '
        Me.ALUNOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUNOBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUNOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUNOBindingNavigatorSaveItem.Name = "ALUNOBindingNavigatorSaveItem"
        Me.ALUNOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ALUNOBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'MATRICULALabel
        '
        MATRICULALabel.AutoSize = True
        MATRICULALabel.Location = New System.Drawing.Point(120, 89)
        MATRICULALabel.Name = "MATRICULALabel"
        MATRICULALabel.Size = New System.Drawing.Size(72, 13)
        MATRICULALabel.TabIndex = 1
        MATRICULALabel.Text = "MATRICULA:"
        '
        'MATRICULATextBox
        '
        Me.MATRICULATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "MATRICULA", True))
        Me.MATRICULATextBox.Location = New System.Drawing.Point(205, 86)
        Me.MATRICULATextBox.Name = "MATRICULATextBox"
        Me.MATRICULATextBox.Size = New System.Drawing.Size(175, 20)
        Me.MATRICULATextBox.TabIndex = 2
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(120, 115)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(205, 112)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(175, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'SOBRENOMELabel
        '
        SOBRENOMELabel.AutoSize = True
        SOBRENOMELabel.Location = New System.Drawing.Point(120, 141)
        SOBRENOMELabel.Name = "SOBRENOMELabel"
        SOBRENOMELabel.Size = New System.Drawing.Size(79, 13)
        SOBRENOMELabel.TabIndex = 5
        SOBRENOMELabel.Text = "SOBRENOME:"
        '
        'SOBRENOMETextBox
        '
        Me.SOBRENOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "SOBRENOME", True))
        Me.SOBRENOMETextBox.Location = New System.Drawing.Point(205, 138)
        Me.SOBRENOMETextBox.Name = "SOBRENOMETextBox"
        Me.SOBRENOMETextBox.Size = New System.Drawing.Size(175, 20)
        Me.SOBRENOMETextBox.TabIndex = 6
        '
        'TELEFONELabel
        '
        TELEFONELabel.AutoSize = True
        TELEFONELabel.Location = New System.Drawing.Point(120, 167)
        TELEFONELabel.Name = "TELEFONELabel"
        TELEFONELabel.Size = New System.Drawing.Size(66, 13)
        TELEFONELabel.TabIndex = 7
        TELEFONELabel.Text = "TELEFONE:"
        '
        'TELEFONEMaskedTextBox
        '
        Me.TELEFONEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "TELEFONE", True))
        Me.TELEFONEMaskedTextBox.Location = New System.Drawing.Point(205, 164)
        Me.TELEFONEMaskedTextBox.Mask = "(00) 00000-0000"
        Me.TELEFONEMaskedTextBox.Name = "TELEFONEMaskedTextBox"
        Me.TELEFONEMaskedTextBox.Size = New System.Drawing.Size(175, 20)
        Me.TELEFONEMaskedTextBox.TabIndex = 8
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(120, 193)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 9
        EMAILLabel.Text = "EMAIL:"
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(205, 190)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(175, 20)
        Me.EMAILTextBox.TabIndex = 10
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(120, 219)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 11
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(205, 216)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(175, 105)
        Me.OBSTextBox.TabIndex = 12
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(531, 89)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 13
        FOTOLabel.Text = "FOTO:"
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ALUNOBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(534, 115)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(113, 121)
        Me.FOTOPictureBox.TabIndex = 14
        Me.FOTOPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Inserir Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MATRICULALabel)
        Me.Controls.Add(Me.MATRICULATextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(SOBRENOMELabel)
        Me.Controls.Add(Me.SOBRENOMETextBox)
        Me.Controls.Add(TELEFONELabel)
        Me.Controls.Add(Me.TELEFONEMaskedTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(Me.ALUNOBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Sistema de Gerenciamento Acadêmico - Cadastro de Alunos"
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUNOBindingNavigator.ResumeLayout(False)
        Me.ALUNOBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Escola2023DataSet As escola2023DataSet
    Friend WithEvents ALUNOBindingSource As BindingSource
    Friend WithEvents ALUNOTableAdapter As escola2023DataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents TableAdapterManager As escola2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUNOBindingNavigator As BindingNavigator
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
    Friend WithEvents ALUNOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MATRICULATextBox As TextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents SOBRENOMETextBox As TextBox
    Friend WithEvents TELEFONEMaskedTextBox As MaskedTextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
    Friend WithEvents Button1 As Button
End Class
