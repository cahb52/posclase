<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
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
        Dim IdpedidoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Fecha_entregaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim AdelantoLabel As System.Windows.Forms.Label
        Dim RestanteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Me.DB = New posclase.DB()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New posclase.DBTableAdapters.PedidosTableAdapter()
        Me.TableAdapterManager = New posclase.DBTableAdapters.TableAdapterManager()
        Me.Detalle_PedidoTableAdapter = New posclase.DBTableAdapters.Detalle_PedidoTableAdapter()
        Me.PedidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PedidosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdpedidoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_entregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FKDetallePedidoPedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New posclase.DBTableAdapters.ClientesTableAdapter()
        Me.ClientesComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedorComboBox = New System.Windows.Forms.ComboBox()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedoresTableAdapter = New posclase.DBTableAdapters.VendedoresTableAdapter()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.AdelantoTextBox = New System.Windows.Forms.TextBox()
        Me.RestanteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.CmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdpedidoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        VendedorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Fecha_entregaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        AdelantoLabel = New System.Windows.Forms.Label()
        RestanteLabel = New System.Windows.Forms.Label()
        CType(Me.DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidosBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDetallePedidoPedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdpedidoLabel
        '
        IdpedidoLabel.AutoSize = True
        IdpedidoLabel.Location = New System.Drawing.Point(18, 43)
        IdpedidoLabel.Name = "IdpedidoLabel"
        IdpedidoLabel.Size = New System.Drawing.Size(50, 13)
        IdpedidoLabel.TabIndex = 1
        IdpedidoLabel.Text = "idpedido:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(18, 69)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 3
        TotalLabel.Text = "total:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(18, 95)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(41, 13)
        ClienteLabel.TabIndex = 5
        ClienteLabel.Text = "cliente:"
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Location = New System.Drawing.Point(18, 122)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(55, 13)
        VendedorLabel.TabIndex = 7
        VendedorLabel.Text = "vendedor:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(18, 150)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 9
        FechaLabel.Text = "fecha:"
        '
        'Fecha_entregaLabel
        '
        Fecha_entregaLabel.AutoSize = True
        Fecha_entregaLabel.Location = New System.Drawing.Point(18, 176)
        Fecha_entregaLabel.Name = "Fecha_entregaLabel"
        Fecha_entregaLabel.Size = New System.Drawing.Size(76, 13)
        Fecha_entregaLabel.TabIndex = 11
        Fecha_entregaLabel.Text = "fecha entrega:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(18, 250)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(42, 13)
        EstadoLabel.TabIndex = 14
        EstadoLabel.Text = "estado:"
        '
        'AdelantoLabel
        '
        AdelantoLabel.AutoSize = True
        AdelantoLabel.Location = New System.Drawing.Point(18, 201)
        AdelantoLabel.Name = "AdelantoLabel"
        AdelantoLabel.Size = New System.Drawing.Size(51, 13)
        AdelantoLabel.TabIndex = 19
        AdelantoLabel.Text = "adelanto:"
        '
        'RestanteLabel
        '
        RestanteLabel.AutoSize = True
        RestanteLabel.Location = New System.Drawing.Point(20, 227)
        RestanteLabel.Name = "RestanteLabel"
        RestanteLabel.Size = New System.Drawing.Size(48, 13)
        RestanteLabel.TabIndex = 20
        RestanteLabel.Text = "restante:"
        '
        'DB
        '
        Me.DB.DataSetName = "DB"
        Me.DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "Pedidos"
        Me.PedidosBindingSource.DataSource = Me.DB
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_PedidoTableAdapter = Me.Detalle_PedidoTableAdapter
        Me.TableAdapterManager.Detalle_PedidoxidpedidoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_VentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTop1TableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = posclase.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        '
        'Detalle_PedidoTableAdapter
        '
        Me.Detalle_PedidoTableAdapter.ClearBeforeFill = True
        '
        'PedidosBindingNavigator
        '
        Me.PedidosBindingNavigator.AddNewItem = Nothing
        Me.PedidosBindingNavigator.BindingSource = Me.PedidosBindingSource
        Me.PedidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PedidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.PedidosBindingNavigatorSaveItem})
        Me.PedidosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PedidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidosBindingNavigator.Name = "PedidosBindingNavigator"
        Me.PedidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidosBindingNavigator.Size = New System.Drawing.Size(932, 25)
        Me.PedidosBindingNavigator.TabIndex = 0
        Me.PedidosBindingNavigator.Text = "BindingNavigator1"
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
        'PedidosBindingNavigatorSaveItem
        '
        Me.PedidosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PedidosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidosBindingNavigatorSaveItem.Name = "PedidosBindingNavigatorSaveItem"
        Me.PedidosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PedidosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdpedidoTextBox
        '
        Me.IdpedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "idpedido", True))
        Me.IdpedidoTextBox.Location = New System.Drawing.Point(100, 40)
        Me.IdpedidoTextBox.Name = "IdpedidoTextBox"
        Me.IdpedidoTextBox.ReadOnly = True
        Me.IdpedidoTextBox.Size = New System.Drawing.Size(211, 20)
        Me.IdpedidoTextBox.TabIndex = 2
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(100, 66)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(211, 20)
        Me.TotalTextBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(100, 146)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(211, 20)
        Me.FechaDateTimePicker.TabIndex = 10
        '
        'Fecha_entregaDateTimePicker
        '
        Me.Fecha_entregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fecha_entrega", True))
        Me.Fecha_entregaDateTimePicker.Location = New System.Drawing.Point(100, 172)
        Me.Fecha_entregaDateTimePicker.Name = "Fecha_entregaDateTimePicker"
        Me.Fecha_entregaDateTimePicker.Size = New System.Drawing.Size(211, 20)
        Me.Fecha_entregaDateTimePicker.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.codigo, Me.nombre, Me.cantidad, Me.precio_unitario, Me.precio_costo, Me.subtotal, Me.pedido})
        Me.DataGridView1.DataSource = Me.FKDetallePedidoPedidosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(907, 230)
        Me.DataGridView1.TabIndex = 13
        '
        'FKDetallePedidoPedidosBindingSource
        '
        Me.FKDetallePedidoPedidosBindingSource.DataMember = "FK_Detalle_Pedido_Pedidos"
        Me.FKDetallePedidoPedidosBindingSource.DataSource = Me.PedidosBindingSource
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(100, 247)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.ReadOnly = True
        Me.EstadoTextBox.Size = New System.Drawing.Size(34, 20)
        Me.EstadoTextBox.TabIndex = 15
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Location = New System.Drawing.Point(23, 310)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(288, 50)
        Me.BtnFacturar.TabIndex = 16
        Me.BtnFacturar.Text = "Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = True
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
        'ClientesComboBox
        '
        Me.ClientesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "cliente", True))
        Me.ClientesComboBox.DataSource = Me.ClientesBindingSource1
        Me.ClientesComboBox.DisplayMember = "nombres"
        Me.ClientesComboBox.FormattingEnabled = True
        Me.ClientesComboBox.Location = New System.Drawing.Point(100, 92)
        Me.ClientesComboBox.Name = "ClientesComboBox"
        Me.ClientesComboBox.Size = New System.Drawing.Size(211, 21)
        Me.ClientesComboBox.TabIndex = 17
        Me.ClientesComboBox.ValueMember = "nit"
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DB
        '
        'VendedorComboBox
        '
        Me.VendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "vendedor", True))
        Me.VendedorComboBox.DataSource = Me.VendedoresBindingSource
        Me.VendedorComboBox.DisplayMember = "nombres"
        Me.VendedorComboBox.FormattingEnabled = True
        Me.VendedorComboBox.Location = New System.Drawing.Point(100, 119)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(211, 21)
        Me.VendedorComboBox.TabIndex = 18
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
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(359, 32)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(138, 23)
        Me.BtnImprimir.TabIndex = 19
        Me.BtnImprimir.Text = "Imprimir Este Pedido"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'AdelantoTextBox
        '
        Me.AdelantoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "adelanto", True))
        Me.AdelantoTextBox.Location = New System.Drawing.Point(100, 198)
        Me.AdelantoTextBox.Name = "AdelantoTextBox"
        Me.AdelantoTextBox.ReadOnly = True
        Me.AdelantoTextBox.Size = New System.Drawing.Size(211, 20)
        Me.AdelantoTextBox.TabIndex = 20
        Me.AdelantoTextBox.Text = "0"
        '
        'RestanteTextBox
        '
        Me.RestanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "restante", True))
        Me.RestanteTextBox.Location = New System.Drawing.Point(100, 224)
        Me.RestanteTextBox.Name = "RestanteTextBox"
        Me.RestanteTextBox.ReadOnly = True
        Me.RestanteTextBox.Size = New System.Drawing.Size(211, 20)
        Me.RestanteTextBox.TabIndex = 21
        Me.RestanteTextBox.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DtFechaFin)
        Me.GroupBox1.Controls.Add(Me.LblFechaInicio)
        Me.GroupBox1.Controls.Add(Me.DtFechaInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 223)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte por fecha"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Fin"
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Location = New System.Drawing.Point(10, 101)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaFin.TabIndex = 2
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Location = New System.Drawing.Point(7, 20)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.LblFechaInicio.TabIndex = 1
        Me.LblFechaInicio.Text = "Fecha Inicio"
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Location = New System.Drawing.Point(10, 46)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaInicio.TabIndex = 0
        '
        'CmbTipoPago
        '
        Me.CmbTipoPago.FormattingEnabled = True
        Me.CmbTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Otro"})
        Me.CmbTipoPago.Location = New System.Drawing.Point(101, 280)
        Me.CmbTipoPago.Name = "CmbTipoPago"
        Me.CmbTipoPago.Size = New System.Drawing.Size(211, 21)
        Me.CmbTipoPago.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tipo de Pago:"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "CÓDIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio_unitario
        '
        Me.precio_unitario.DataPropertyName = "precio_unitario"
        Me.precio_unitario.HeaderText = "PRECIO UNITARIO"
        Me.precio_unitario.Name = "precio_unitario"
        Me.precio_unitario.ReadOnly = True
        '
        'precio_costo
        '
        Me.precio_costo.DataPropertyName = "precio_costo"
        Me.precio_costo.HeaderText = "PRECIO COSTO"
        Me.precio_costo.Name = "precio_costo"
        Me.precio_costo.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'pedido
        '
        Me.pedido.DataPropertyName = "pedido"
        Me.pedido.HeaderText = "PEDIDO"
        Me.pedido.Name = "pedido"
        Me.pedido.ReadOnly = True
        Me.pedido.Visible = False
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 608)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbTipoPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(RestanteLabel)
        Me.Controls.Add(Me.RestanteTextBox)
        Me.Controls.Add(AdelantoLabel)
        Me.Controls.Add(Me.AdelantoTextBox)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.ClientesComboBox)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IdpedidoLabel)
        Me.Controls.Add(Me.IdpedidoTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(VendedorLabel)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Fecha_entregaLabel)
        Me.Controls.Add(Me.Fecha_entregaDateTimePicker)
        Me.Controls.Add(Me.PedidosBindingNavigator)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidosBindingNavigator.ResumeLayout(False)
        Me.PedidosBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDetallePedidoPedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB As DB
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As DBTableAdapters.PedidosTableAdapter
    Friend WithEvents TableAdapterManager As DBTableAdapters.TableAdapterManager
    Friend WithEvents PedidosBindingNavigator As BindingNavigator
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
    Friend WithEvents Detalle_PedidoTableAdapter As DBTableAdapters.Detalle_PedidoTableAdapter
    Friend WithEvents IdpedidoTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_entregaDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FKDetallePedidoPedidosBindingSource As BindingSource
    Friend WithEvents PedidosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DBTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesComboBox As ComboBox
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents VendedorComboBox As ComboBox
    Friend WithEvents VendedoresBindingSource As BindingSource
    Friend WithEvents VendedoresTableAdapter As DBTableAdapters.VendedoresTableAdapter
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents AdelantoTextBox As TextBox
    Friend WithEvents RestanteTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents CmbTipoPago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario As DataGridViewTextBoxColumn
    Friend WithEvents precio_costo As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents pedido As DataGridViewTextBoxColumn
End Class
