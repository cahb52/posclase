﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalFactura = New System.Windows.Forms.TextBox()
        Me.DetalleVenta = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkPorcentaje = New System.Windows.Forms.CheckBox()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ChkPedido = New System.Windows.Forms.CheckBox()
        Me.DtFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAnticipo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtRestante = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPagado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtVuelto = New System.Windows.Forms.TextBox()
        CType(Me.DetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nit o DPI:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TxtNombres
        '
        Me.TxtNombres.Enabled = False
        Me.TxtNombres.Location = New System.Drawing.Point(73, 39)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(243, 20)
        Me.TxtNombres.TabIndex = 2
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(73, 65)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(243, 20)
        Me.TxtApellidos.TabIndex = 3
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Location = New System.Drawing.Point(73, 91)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(243, 20)
        Me.TxtDireccion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(548, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(3)
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Factura"
        '
        'TxtTotalFactura
        '
        Me.TxtTotalFactura.Enabled = False
        Me.TxtTotalFactura.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalFactura.Location = New System.Drawing.Point(655, 13)
        Me.TxtTotalFactura.Name = "TxtTotalFactura"
        Me.TxtTotalFactura.Size = New System.Drawing.Size(180, 34)
        Me.TxtTotalFactura.TabIndex = 10
        Me.TxtTotalFactura.Text = "Q.0.00"
        Me.TxtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DetalleVenta
        '
        Me.DetalleVenta.AllowUserToAddRows = False
        Me.DetalleVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.cantidad, Me.precio_unitario, Me.precio_costo, Me.subtotal})
        Me.DetalleVenta.Location = New System.Drawing.Point(3, 185)
        Me.DetalleVenta.Name = "DetalleVenta"
        Me.DetalleVenta.ReadOnly = True
        Me.DetalleVenta.Size = New System.Drawing.Size(927, 290)
        Me.DetalleVenta.TabIndex = 11
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio_unitario
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.precio_unitario.DefaultCellStyle = DataGridViewCellStyle1
        Me.precio_unitario.HeaderText = "Precio Unitario"
        Me.precio_unitario.Name = "precio_unitario"
        Me.precio_unitario.ReadOnly = True
        '
        'precio_costo
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precio_costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio_costo.HeaderText = "Precio Costo"
        Me.precio_costo.Name = "precio_costo"
        Me.precio_costo.ReadOnly = True
        Me.precio_costo.Visible = False
        '
        'subtotal
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Código:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(73, 133)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(243, 20)
        Me.TxtCodigo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(397, 133)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(106, 20)
        Me.TxtCantidad.TabIndex = 15
        Me.TxtCantidad.Text = "1"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(509, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descuento:"
        '
        'ChkPorcentaje
        '
        Me.ChkPorcentaje.AutoSize = True
        Me.ChkPorcentaje.Location = New System.Drawing.Point(577, 136)
        Me.ChkPorcentaje.Name = "ChkPorcentaje"
        Me.ChkPorcentaje.Size = New System.Drawing.Size(34, 17)
        Me.ChkPorcentaje.TabIndex = 17
        Me.ChkPorcentaje.Text = "%"
        Me.ChkPorcentaje.UseVisualStyleBackColor = True
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(617, 133)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescuento.TabIndex = 18
        Me.TxtDescuento.Text = "0"
        Me.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(687, 576)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(243, 35)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Generar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'ChkPedido
        '
        Me.ChkPedido.AutoSize = True
        Me.ChkPedido.Location = New System.Drawing.Point(3, 483)
        Me.ChkPedido.Name = "ChkPedido"
        Me.ChkPedido.Size = New System.Drawing.Size(59, 17)
        Me.ChkPedido.TabIndex = 21
        Me.ChkPedido.Text = "Pedido"
        Me.ChkPedido.UseVisualStyleBackColor = True
        '
        'DtFechaEntrega
        '
        Me.DtFechaEntrega.Enabled = False
        Me.DtFechaEntrega.Location = New System.Drawing.Point(191, 481)
        Me.DtFechaEntrega.Name = "DtFechaEntrega"
        Me.DtFechaEntrega.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaEntrega.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Fecha de Entrega:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 507)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Anticipo"
        '
        'TxtAnticipo
        '
        Me.TxtAnticipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtAnticipo.Location = New System.Drawing.Point(55, 507)
        Me.TxtAnticipo.Name = "TxtAnticipo"
        Me.TxtAnticipo.ReadOnly = True
        Me.TxtAnticipo.Size = New System.Drawing.Size(161, 20)
        Me.TxtAnticipo.TabIndex = 25
        Me.TxtAnticipo.Text = "0"
        Me.TxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Restante"
        '
        'TxtRestante
        '
        Me.TxtRestante.Enabled = False
        Me.TxtRestante.Location = New System.Drawing.Point(55, 533)
        Me.TxtRestante.Name = "TxtRestante"
        Me.TxtRestante.ReadOnly = True
        Me.TxtRestante.Size = New System.Drawing.Size(161, 20)
        Me.TxtRestante.TabIndex = 27
        Me.TxtRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(597, 487)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Tipo de pago"
        '
        'CmbTipoPago
        '
        Me.CmbTipoPago.FormattingEnabled = True
        Me.CmbTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Otro"})
        Me.CmbTipoPago.Location = New System.Drawing.Point(687, 484)
        Me.CmbTipoPago.Name = "CmbTipoPago"
        Me.CmbTipoPago.Size = New System.Drawing.Size(243, 21)
        Me.CmbTipoPago.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(597, 517)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Pagado:"
        '
        'TxtPagado
        '
        Me.TxtPagado.Location = New System.Drawing.Point(687, 514)
        Me.TxtPagado.Name = "TxtPagado"
        Me.TxtPagado.Size = New System.Drawing.Size(243, 20)
        Me.TxtPagado.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(597, 543)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Vuelto:"
        '
        'TxtVuelto
        '
        Me.TxtVuelto.Location = New System.Drawing.Point(687, 540)
        Me.TxtVuelto.Name = "TxtVuelto"
        Me.TxtVuelto.ReadOnly = True
        Me.TxtVuelto.Size = New System.Drawing.Size(243, 20)
        Me.TxtVuelto.TabIndex = 33
        '
        'Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 613)
        Me.Controls.Add(Me.TxtVuelto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtPagado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CmbTipoPago)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtRestante)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtAnticipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DtFechaEntrega)
        Me.Controls.Add(Me.ChkPedido)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.ChkPorcentaje)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DetalleVenta)
        Me.Controls.Add(Me.TxtTotalFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Facturar"
        Me.Text = "Facturar o pedir"
        CType(Me.DetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalFactura As TextBox
    Friend WithEvents DetalleVenta As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkPorcentaje As CheckBox
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ChkPedido As CheckBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario As DataGridViewTextBoxColumn
    Friend WithEvents precio_costo As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents DtFechaEntrega As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAnticipo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtRestante As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbTipoPago As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPagado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtVuelto As TextBox
End Class
