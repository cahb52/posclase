<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Dim IdfacturaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Me.DB = New posclase.DB()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New posclase.DBTableAdapters.FacturasTableAdapter()
        Me.TableAdapterManager = New posclase.DBTableAdapters.TableAdapterManager()
        Me.FacturasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.VendedorComboBox = New System.Windows.Forms.ComboBox()
        IdfacturaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        CType(Me.DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DB
        '
        Me.DB.DataSetName = "DB"
        Me.DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.DB
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_VentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Me.FacturasTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = posclase.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        '
        'FacturasBindingNavigator
        '
        Me.FacturasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturasBindingNavigator.BindingSource = Me.FacturasBindingSource
        Me.FacturasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturasBindingNavigatorSaveItem})
        Me.FacturasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturasBindingNavigator.Name = "FacturasBindingNavigator"
        Me.FacturasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturasBindingNavigator.Size = New System.Drawing.Size(862, 25)
        Me.FacturasBindingNavigator.TabIndex = 0
        Me.FacturasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
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
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
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
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'FacturasBindingNavigatorSaveItem
        '
        Me.FacturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturasBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturasBindingNavigatorSaveItem.Name = "FacturasBindingNavigatorSaveItem"
        Me.FacturasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FacturasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdfacturaLabel
        '
        IdfacturaLabel.AutoSize = True
        IdfacturaLabel.Location = New System.Drawing.Point(26, 39)
        IdfacturaLabel.Name = "IdfacturaLabel"
        IdfacturaLabel.Size = New System.Drawing.Size(51, 13)
        IdfacturaLabel.TabIndex = 1
        IdfacturaLabel.Text = "idfactura:"
        '
        'IdfacturaTextBox
        '
        Me.IdfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "idfactura", True))
        Me.IdfacturaTextBox.Location = New System.Drawing.Point(87, 36)
        Me.IdfacturaTextBox.Name = "IdfacturaTextBox"
        Me.IdfacturaTextBox.Size = New System.Drawing.Size(288, 20)
        Me.IdfacturaTextBox.TabIndex = 2
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(26, 65)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 3
        TotalLabel.Text = "total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(87, 62)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(288, 20)
        Me.TotalTextBox.TabIndex = 4
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(26, 91)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(41, 13)
        ClienteLabel.TabIndex = 5
        ClienteLabel.Text = "cliente:"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "cliente", True))
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(87, 88)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(288, 21)
        Me.ClienteComboBox.TabIndex = 6
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Location = New System.Drawing.Point(26, 118)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(55, 13)
        VendedorLabel.TabIndex = 7
        VendedorLabel.Text = "vendedor:"
        '
        'VendedorComboBox
        '
        Me.VendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "vendedor", True))
        Me.VendedorComboBox.FormattingEnabled = True
        Me.VendedorComboBox.Location = New System.Drawing.Point(87, 115)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(288, 21)
        Me.VendedorComboBox.TabIndex = 8
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 535)
        Me.Controls.Add(IdfacturaLabel)
        Me.Controls.Add(Me.IdfacturaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.ClienteComboBox)
        Me.Controls.Add(VendedorLabel)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.FacturasBindingNavigator)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasBindingNavigator.ResumeLayout(False)
        Me.FacturasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB As DB
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As DBTableAdapters.FacturasTableAdapter
    Friend WithEvents TableAdapterManager As DBTableAdapters.TableAdapterManager
    Friend WithEvents FacturasBindingNavigator As BindingNavigator
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
    Friend WithEvents FacturasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdfacturaTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents VendedorComboBox As ComboBox
End Class
