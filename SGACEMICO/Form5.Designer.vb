﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim PROFESSORLabel As System.Windows.Forms.Label
        Dim CURSOLabel As System.Windows.Forms.Label
        Dim CAPACIDADELabel As System.Windows.Forms.Label
        Dim DTINICIOLabel As System.Windows.Forms.Label
        Dim DTFIMLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim MEDIALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Escola2023DataSet = New SGACEMICO.escola2023DataSet()
        Me.TURMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURMATableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.TURMATableAdapter()
        Me.TableAdapterManager = New SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager()
        Me.CURSOTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.CURSOTableAdapter()
        Me.PROFESSORTableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.PROFESSORTableAdapter()
        Me.TURMABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TURMABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.PROFESSORComboBox = New System.Windows.Forms.ComboBox()
        Me.PROFESSORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOComboBox = New System.Windows.Forms.ComboBox()
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAPACIDADETextBox = New System.Windows.Forms.TextBox()
        Me.DTINICIODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DTFIMDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.MEDIATextBox = New System.Windows.Forms.TextBox()
        Me.Escola2023DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MATRICULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATRICULATableAdapter = New SGACEMICO.escola2023DataSetTableAdapters.MATRICULATableAdapter()
        Me.MATRICULABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATRICULABindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATRICULABindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CODIGOLabel = New System.Windows.Forms.Label()
        PROFESSORLabel = New System.Windows.Forms.Label()
        CURSOLabel = New System.Windows.Forms.Label()
        CAPACIDADELabel = New System.Windows.Forms.Label()
        DTINICIOLabel = New System.Windows.Forms.Label()
        DTFIMLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        MEDIALabel = New System.Windows.Forms.Label()
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TURMABindingNavigator.SuspendLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escola2023DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(70, 66)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'PROFESSORLabel
        '
        PROFESSORLabel.AutoSize = True
        PROFESSORLabel.Location = New System.Drawing.Point(70, 92)
        PROFESSORLabel.Name = "PROFESSORLabel"
        PROFESSORLabel.Size = New System.Drawing.Size(76, 13)
        PROFESSORLabel.TabIndex = 3
        PROFESSORLabel.Text = "PROFESSOR:"
        '
        'CURSOLabel
        '
        CURSOLabel.AutoSize = True
        CURSOLabel.Location = New System.Drawing.Point(70, 119)
        CURSOLabel.Name = "CURSOLabel"
        CURSOLabel.Size = New System.Drawing.Size(48, 13)
        CURSOLabel.TabIndex = 5
        CURSOLabel.Text = "CURSO:"
        '
        'CAPACIDADELabel
        '
        CAPACIDADELabel.AutoSize = True
        CAPACIDADELabel.Location = New System.Drawing.Point(70, 146)
        CAPACIDADELabel.Name = "CAPACIDADELabel"
        CAPACIDADELabel.Size = New System.Drawing.Size(78, 13)
        CAPACIDADELabel.TabIndex = 7
        CAPACIDADELabel.Text = "CAPACIDADE:"
        '
        'DTINICIOLabel
        '
        DTINICIOLabel.AutoSize = True
        DTINICIOLabel.Location = New System.Drawing.Point(70, 173)
        DTINICIOLabel.Name = "DTINICIOLabel"
        DTINICIOLabel.Size = New System.Drawing.Size(57, 13)
        DTINICIOLabel.TabIndex = 9
        DTINICIOLabel.Text = "DTINICIO:"
        '
        'DTFIMLabel
        '
        DTFIMLabel.AutoSize = True
        DTFIMLabel.Location = New System.Drawing.Point(70, 199)
        DTFIMLabel.Name = "DTFIMLabel"
        DTFIMLabel.Size = New System.Drawing.Size(43, 13)
        DTFIMLabel.TabIndex = 11
        DTFIMLabel.Text = "DTFIM:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(70, 224)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 13
        OBSLabel.Text = "OBS:"
        '
        'MEDIALabel
        '
        MEDIALabel.AutoSize = True
        MEDIALabel.Location = New System.Drawing.Point(70, 476)
        MEDIALabel.Name = "MEDIALabel"
        MEDIALabel.Size = New System.Drawing.Size(44, 13)
        MEDIALabel.TabIndex = 15
        MEDIALabel.Text = "MEDIA:"
        '
        'Escola2023DataSet
        '
        Me.Escola2023DataSet.DataSetName = "escola2023DataSet"
        Me.Escola2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TURMABindingSource
        '
        Me.TURMABindingSource.DataMember = "TURMA"
        Me.TURMABindingSource.DataSource = Me.Escola2023DataSet
        '
        'TURMATableAdapter
        '
        Me.TURMATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Me.PROFESSORTableAdapter
        Me.TableAdapterManager.TURMATableAdapter = Me.TURMATableAdapter
        Me.TableAdapterManager.UpdateOrder = SGACEMICO.escola2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CURSOTableAdapter
        '
        Me.CURSOTableAdapter.ClearBeforeFill = True
        '
        'PROFESSORTableAdapter
        '
        Me.PROFESSORTableAdapter.ClearBeforeFill = True
        '
        'TURMABindingNavigator
        '
        Me.TURMABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TURMABindingNavigator.BindingSource = Me.TURMABindingSource
        Me.TURMABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TURMABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TURMABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TURMABindingNavigatorSaveItem})
        Me.TURMABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TURMABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TURMABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TURMABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TURMABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TURMABindingNavigator.Name = "TURMABindingNavigator"
        Me.TURMABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TURMABindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TURMABindingNavigator.TabIndex = 0
        Me.TURMABindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TURMABindingNavigatorSaveItem
        '
        Me.TURMABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TURMABindingNavigatorSaveItem.Image = CType(resources.GetObject("TURMABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TURMABindingNavigatorSaveItem.Name = "TURMABindingNavigatorSaveItem"
        Me.TURMABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TURMABindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(154, 63)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'PROFESSORComboBox
        '
        Me.PROFESSORComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "PROFESSOR", True))
        Me.PROFESSORComboBox.DataSource = Me.PROFESSORBindingSource
        Me.PROFESSORComboBox.DisplayMember = "NOME"
        Me.PROFESSORComboBox.FormattingEnabled = True
        Me.PROFESSORComboBox.Location = New System.Drawing.Point(154, 89)
        Me.PROFESSORComboBox.Name = "PROFESSORComboBox"
        Me.PROFESSORComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PROFESSORComboBox.TabIndex = 4
        Me.PROFESSORComboBox.ValueMember = "NOME"
        '
        'PROFESSORBindingSource
        '
        Me.PROFESSORBindingSource.DataMember = "PROFESSOR"
        Me.PROFESSORBindingSource.DataSource = Me.Escola2023DataSet
        '
        'CURSOComboBox
        '
        Me.CURSOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CURSO", True))
        Me.CURSOComboBox.DataSource = Me.CURSOBindingSource
        Me.CURSOComboBox.DisplayMember = "NOME"
        Me.CURSOComboBox.FormattingEnabled = True
        Me.CURSOComboBox.Location = New System.Drawing.Point(154, 116)
        Me.CURSOComboBox.Name = "CURSOComboBox"
        Me.CURSOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CURSOComboBox.TabIndex = 6
        Me.CURSOComboBox.ValueMember = "NOME"
        '
        'CURSOBindingSource
        '
        Me.CURSOBindingSource.DataMember = "CURSO"
        Me.CURSOBindingSource.DataSource = Me.Escola2023DataSet
        '
        'CAPACIDADETextBox
        '
        Me.CAPACIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CAPACIDADE", True))
        Me.CAPACIDADETextBox.Location = New System.Drawing.Point(154, 143)
        Me.CAPACIDADETextBox.Name = "CAPACIDADETextBox"
        Me.CAPACIDADETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CAPACIDADETextBox.TabIndex = 8
        '
        'DTINICIODateTimePicker
        '
        Me.DTINICIODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DTINICIO", True))
        Me.DTINICIODateTimePicker.Location = New System.Drawing.Point(154, 169)
        Me.DTINICIODateTimePicker.Name = "DTINICIODateTimePicker"
        Me.DTINICIODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DTINICIODateTimePicker.TabIndex = 10
        '
        'DTFIMDateTimePicker
        '
        Me.DTFIMDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DTFIM", True))
        Me.DTFIMDateTimePicker.Location = New System.Drawing.Point(154, 195)
        Me.DTFIMDateTimePicker.Name = "DTFIMDateTimePicker"
        Me.DTFIMDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DTFIMDateTimePicker.TabIndex = 12
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(154, 221)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(200, 86)
        Me.OBSTextBox.TabIndex = 14
        '
        'MEDIATextBox
        '
        Me.MEDIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "MEDIA", True))
        Me.MEDIATextBox.Enabled = False
        Me.MEDIATextBox.Location = New System.Drawing.Point(154, 473)
        Me.MEDIATextBox.Name = "MEDIATextBox"
        Me.MEDIATextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDIATextBox.TabIndex = 16
        '
        'Escola2023DataSetBindingSource
        '
        Me.Escola2023DataSetBindingSource.DataSource = Me.Escola2023DataSet
        Me.Escola2023DataSetBindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MATRICULABindingSource
        '
        Me.MATRICULABindingSource.DataSource = Me.TURMABindingSource
        '
        'MATRICULATableAdapter
        '
        Me.MATRICULATableAdapter.ClearBeforeFill = True
        '
        'MATRICULABindingSource1
        '
        Me.MATRICULABindingSource1.DataSource = Me.MATRICULABindingSource
        '
        'MATRICULABindingSource2
        '
        Me.MATRICULABindingSource2.DataSource = Me.TURMABindingSource
        '
        'MATRICULABindingSource3
        '
        Me.MATRICULABindingSource3.DataSource = Me.MATRICULABindingSource
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 621)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(PROFESSORLabel)
        Me.Controls.Add(Me.PROFESSORComboBox)
        Me.Controls.Add(CURSOLabel)
        Me.Controls.Add(Me.CURSOComboBox)
        Me.Controls.Add(CAPACIDADELabel)
        Me.Controls.Add(Me.CAPACIDADETextBox)
        Me.Controls.Add(DTINICIOLabel)
        Me.Controls.Add(Me.DTINICIODateTimePicker)
        Me.Controls.Add(DTFIMLabel)
        Me.Controls.Add(Me.DTFIMDateTimePicker)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(MEDIALabel)
        Me.Controls.Add(Me.MEDIATextBox)
        Me.Controls.Add(Me.TURMABindingNavigator)
        Me.Name = "Form5"
        Me.Text = "2"
        CType(Me.Escola2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TURMABindingNavigator.ResumeLayout(False)
        Me.TURMABindingNavigator.PerformLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escola2023DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Escola2023DataSet As escola2023DataSet
    Friend WithEvents TURMABindingSource As BindingSource
    Friend WithEvents TURMATableAdapter As escola2023DataSetTableAdapters.TURMATableAdapter
    Friend WithEvents TableAdapterManager As escola2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TURMABindingNavigator As BindingNavigator
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
    Friend WithEvents TURMABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents PROFESSORComboBox As ComboBox
    Friend WithEvents CURSOComboBox As ComboBox
    Friend WithEvents CAPACIDADETextBox As TextBox
    Friend WithEvents DTINICIODateTimePicker As DateTimePicker
    Friend WithEvents DTFIMDateTimePicker As DateTimePicker
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents MEDIATextBox As TextBox
    Friend WithEvents PROFESSORTableAdapter As escola2023DataSetTableAdapters.PROFESSORTableAdapter
    Friend WithEvents Escola2023DataSetBindingSource As BindingSource
    Friend WithEvents PROFESSORBindingSource As BindingSource
    Friend WithEvents CURSOTableAdapter As escola2023DataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents CURSOBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents MATRICULABindingSource As BindingSource
    Friend WithEvents MATRICULATableAdapter As escola2023DataSetTableAdapters.MATRICULATableAdapter
    Friend WithEvents MATRICULABindingSource1 As BindingSource
    Friend WithEvents MATRICULABindingSource2 As BindingSource
    Friend WithEvents MATRICULABindingSource3 As BindingSource
End Class
