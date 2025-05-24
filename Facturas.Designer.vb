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
        Dim IdfacturaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.DB = New posclase.DB()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New posclase.DBTableAdapters.FacturasTableAdapter()
        Me.TableAdapterManager = New posclase.DBTableAdapters.TableAdapterManager()
        Me.FacturasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New posclase.DBTableAdapters.ClientesTableAdapter()
        Me.VendedorComboBox = New System.Windows.Forms.ComboBox()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedoresTableAdapter = New posclase.DBTableAdapters.VendedoresTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciounitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKDetalleVentasFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_VentasTableAdapter = New posclase.DBTableAdapters.Detalle_VentasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        IdfacturaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        CType(Me.DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasBindingNavigator.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDetalleVentasFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(26, 65)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 3
        TotalLabel.Text = "total:"
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
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Location = New System.Drawing.Point(26, 118)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(55, 13)
        VendedorLabel.TabIndex = 7
        VendedorLabel.Text = "vendedor:"
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
        Me.TableAdapterManager.Detalle_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_PedidoxidpedidoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_VentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTop1TableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Me.FacturasTableAdapter
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
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
        'FacturasBindingNavigatorSaveItem
        '
        Me.FacturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturasBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturasBindingNavigatorSaveItem.Name = "FacturasBindingNavigatorSaveItem"
        Me.FacturasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FacturasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdfacturaTextBox
        '
        Me.IdfacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "idfactura", True))
        Me.IdfacturaTextBox.Enabled = False
        Me.IdfacturaTextBox.Location = New System.Drawing.Point(87, 36)
        Me.IdfacturaTextBox.Name = "IdfacturaTextBox"
        Me.IdfacturaTextBox.ReadOnly = True
        Me.IdfacturaTextBox.Size = New System.Drawing.Size(288, 20)
        Me.IdfacturaTextBox.TabIndex = 2
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "total", True))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(87, 62)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(288, 20)
        Me.TotalTextBox.TabIndex = 4
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FacturasBindingSource, "cliente", True))
        Me.ClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.ClienteComboBox.DisplayMember = "nombres"
        Me.ClienteComboBox.Enabled = False
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(87, 88)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(288, 21)
        Me.ClienteComboBox.TabIndex = 9
        Me.ClienteComboBox.ValueMember = "nit"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DB
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'VendedorComboBox
        '
        Me.VendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FacturasBindingSource, "vendedor", True))
        Me.VendedorComboBox.DataSource = Me.VendedoresBindingSource
        Me.VendedorComboBox.DisplayMember = "nombres"
        Me.VendedorComboBox.Enabled = False
        Me.VendedorComboBox.FormattingEnabled = True
        Me.VendedorComboBox.Location = New System.Drawing.Point(87, 115)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(287, 21)
        Me.VendedorComboBox.TabIndex = 10
        Me.VendedorComboBox.ValueMember = "dpi"
        '
        'VendedoresBindingSource
        '
        Me.VendedoresBindingSource.DataMember = "Vendedores"
        Me.VendedoresBindingSource.DataSource = Me.DB
        '
        'VendedoresTableAdapter
        '
        Me.VendedoresTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PreciounitarioDataGridViewTextBoxColumn, Me.PreciocostoDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FKDetalleVentasFacturasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(837, 341)
        Me.DataGridView1.TabIndex = 11
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciounitarioDataGridViewTextBoxColumn
        '
        Me.PreciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario"
        Me.PreciounitarioDataGridViewTextBoxColumn.HeaderText = "precio_unitario"
        Me.PreciounitarioDataGridViewTextBoxColumn.Name = "PreciounitarioDataGridViewTextBoxColumn"
        Me.PreciounitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciocostoDataGridViewTextBoxColumn
        '
        Me.PreciocostoDataGridViewTextBoxColumn.DataPropertyName = "precio_costo"
        Me.PreciocostoDataGridViewTextBoxColumn.HeaderText = "precio_costo"
        Me.PreciocostoDataGridViewTextBoxColumn.Name = "PreciocostoDataGridViewTextBoxColumn"
        Me.PreciocostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PreciocostoDataGridViewTextBoxColumn.Visible = False
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaDataGridViewTextBoxColumn.Visible = False
        '
        'FKDetalleVentasFacturasBindingSource
        '
        Me.FKDetalleVentasFacturasBindingSource.DataMember = "FK_Detalle_Ventas_Facturas"
        Me.FKDetalleVentasFacturasBindingSource.DataSource = Me.FacturasBindingSource
        '
        'Detalle_VentasTableAdapter
        '
        Me.Detalle_VentasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImprimir)
        Me.GroupBox1.Controls.Add(Me.DtFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(409, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 147)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte por rango de fechas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Location = New System.Drawing.Point(10, 37)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(216, 20)
        Me.DtFechaInicio.TabIndex = 1
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Location = New System.Drawing.Point(10, 82)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(216, 20)
        Me.DtFechaFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Inicio:"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(10, 109)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(216, 23)
        Me.BtnImprimir.TabIndex = 4
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.ClienteComboBox)
        Me.Controls.Add(IdfacturaLabel)
        Me.Controls.Add(Me.IdfacturaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(VendedorLabel)
        Me.Controls.Add(Me.FacturasBindingNavigator)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasBindingNavigator.ResumeLayout(False)
        Me.FacturasBindingNavigator.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDetalleVentasFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DBTableAdapters.ClientesTableAdapter
    Friend WithEvents VendedorComboBox As ComboBox
    Friend WithEvents VendedoresBindingSource As BindingSource
    Friend WithEvents VendedoresTableAdapter As DBTableAdapters.VendedoresTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FKDetalleVentasFacturasBindingSource As BindingSource
    Friend WithEvents Detalle_VentasTableAdapter As DBTableAdapters.Detalle_VentasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciounitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnImprimir As Button
End Class
