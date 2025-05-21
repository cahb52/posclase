<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Dim NitLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim FacebookLabel As System.Windows.Forms.Label
        Dim InstagramLabel As System.Windows.Forms.Label
        Dim TiktokLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelegramLabel As System.Windows.Forms.Label
        Dim WhatsappLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Me.DB = New posclase.DB()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New posclase.DBTableAdapters.EmpresaTableAdapter()
        Me.TableAdapterManager = New posclase.DBTableAdapters.TableAdapterManager()
        Me.EmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpresaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.FacebookTextBox = New System.Windows.Forms.TextBox()
        Me.InstagramTextBox = New System.Windows.Forms.TextBox()
        Me.TiktokTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelegramTextBox = New System.Windows.Forms.TextBox()
        Me.WhatsappTextBox = New System.Windows.Forms.TextBox()
        Me.LogoTextBox = New System.Windows.Forms.TextBox()
        NitLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        FacebookLabel = New System.Windows.Forms.Label()
        InstagramLabel = New System.Windows.Forms.Label()
        TiktokLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelegramLabel = New System.Windows.Forms.Label()
        WhatsappLabel = New System.Windows.Forms.Label()
        LogoLabel = New System.Windows.Forms.Label()
        CType(Me.DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DB
        '
        Me.DB.DataSetName = "DB"
        Me.DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "Empresa"
        Me.EmpresaBindingSource.DataSource = Me.DB
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_VentasTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Me.EmpresaTableAdapter
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = posclase.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendedoresTableAdapter = Nothing
        '
        'EmpresaBindingNavigator
        '
        Me.EmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresaBindingNavigator.BindingSource = Me.EmpresaBindingSource
        Me.EmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresaBindingNavigatorSaveItem})
        Me.EmpresaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresaBindingNavigator.Name = "EmpresaBindingNavigator"
        Me.EmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EmpresaBindingNavigator.TabIndex = 0
        Me.EmpresaBindingNavigator.Text = "BindingNavigator1"
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
        'EmpresaBindingNavigatorSaveItem
        '
        Me.EmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresaBindingNavigatorSaveItem.Name = "EmpresaBindingNavigatorSaveItem"
        Me.EmpresaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmpresaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(21, 44)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(21, 13)
        NitLabel.TabIndex = 1
        NitLabel.Text = "nit:"
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(83, 41)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(307, 20)
        Me.NitTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(21, 70)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(83, 67)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(307, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(21, 96)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(83, 93)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(307, 20)
        Me.DireccionTextBox.TabIndex = 6
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(21, 122)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(83, 119)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(307, 20)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'FacebookLabel
        '
        FacebookLabel.AutoSize = True
        FacebookLabel.Location = New System.Drawing.Point(21, 148)
        FacebookLabel.Name = "FacebookLabel"
        FacebookLabel.Size = New System.Drawing.Size(55, 13)
        FacebookLabel.TabIndex = 9
        FacebookLabel.Text = "facebook:"
        '
        'FacebookTextBox
        '
        Me.FacebookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "facebook", True))
        Me.FacebookTextBox.Location = New System.Drawing.Point(83, 145)
        Me.FacebookTextBox.Name = "FacebookTextBox"
        Me.FacebookTextBox.Size = New System.Drawing.Size(307, 20)
        Me.FacebookTextBox.TabIndex = 10
        '
        'InstagramLabel
        '
        InstagramLabel.AutoSize = True
        InstagramLabel.Location = New System.Drawing.Point(21, 174)
        InstagramLabel.Name = "InstagramLabel"
        InstagramLabel.Size = New System.Drawing.Size(55, 13)
        InstagramLabel.TabIndex = 11
        InstagramLabel.Text = "instagram:"
        '
        'InstagramTextBox
        '
        Me.InstagramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "instagram", True))
        Me.InstagramTextBox.Location = New System.Drawing.Point(83, 171)
        Me.InstagramTextBox.Name = "InstagramTextBox"
        Me.InstagramTextBox.Size = New System.Drawing.Size(307, 20)
        Me.InstagramTextBox.TabIndex = 12
        '
        'TiktokLabel
        '
        TiktokLabel.AutoSize = True
        TiktokLabel.Location = New System.Drawing.Point(21, 200)
        TiktokLabel.Name = "TiktokLabel"
        TiktokLabel.Size = New System.Drawing.Size(36, 13)
        TiktokLabel.TabIndex = 13
        TiktokLabel.Text = "tiktok:"
        '
        'TiktokTextBox
        '
        Me.TiktokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "tiktok", True))
        Me.TiktokTextBox.Location = New System.Drawing.Point(83, 197)
        Me.TiktokTextBox.Name = "TiktokTextBox"
        Me.TiktokTextBox.Size = New System.Drawing.Size(307, 20)
        Me.TiktokTextBox.TabIndex = 14
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(21, 226)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(83, 223)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(307, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'TelegramLabel
        '
        TelegramLabel.AutoSize = True
        TelegramLabel.Location = New System.Drawing.Point(21, 252)
        TelegramLabel.Name = "TelegramLabel"
        TelegramLabel.Size = New System.Drawing.Size(50, 13)
        TelegramLabel.TabIndex = 17
        TelegramLabel.Text = "telegram:"
        '
        'TelegramTextBox
        '
        Me.TelegramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "telegram", True))
        Me.TelegramTextBox.Location = New System.Drawing.Point(83, 249)
        Me.TelegramTextBox.Name = "TelegramTextBox"
        Me.TelegramTextBox.Size = New System.Drawing.Size(307, 20)
        Me.TelegramTextBox.TabIndex = 18
        '
        'WhatsappLabel
        '
        WhatsappLabel.AutoSize = True
        WhatsappLabel.Location = New System.Drawing.Point(21, 278)
        WhatsappLabel.Name = "WhatsappLabel"
        WhatsappLabel.Size = New System.Drawing.Size(56, 13)
        WhatsappLabel.TabIndex = 19
        WhatsappLabel.Text = "whatsapp:"
        '
        'WhatsappTextBox
        '
        Me.WhatsappTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "whatsapp", True))
        Me.WhatsappTextBox.Location = New System.Drawing.Point(83, 275)
        Me.WhatsappTextBox.Name = "WhatsappTextBox"
        Me.WhatsappTextBox.Size = New System.Drawing.Size(307, 20)
        Me.WhatsappTextBox.TabIndex = 20
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Location = New System.Drawing.Point(21, 304)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(30, 13)
        LogoLabel.TabIndex = 21
        LogoLabel.Text = "logo:"
        '
        'LogoTextBox
        '
        Me.LogoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "logo", True))
        Me.LogoTextBox.Location = New System.Drawing.Point(83, 301)
        Me.LogoTextBox.Name = "LogoTextBox"
        Me.LogoTextBox.Size = New System.Drawing.Size(307, 20)
        Me.LogoTextBox.TabIndex = 22
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(NitLabel)
        Me.Controls.Add(Me.NitTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(FacebookLabel)
        Me.Controls.Add(Me.FacebookTextBox)
        Me.Controls.Add(InstagramLabel)
        Me.Controls.Add(Me.InstagramTextBox)
        Me.Controls.Add(TiktokLabel)
        Me.Controls.Add(Me.TiktokTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelegramLabel)
        Me.Controls.Add(Me.TelegramTextBox)
        Me.Controls.Add(WhatsappLabel)
        Me.Controls.Add(Me.WhatsappTextBox)
        Me.Controls.Add(LogoLabel)
        Me.Controls.Add(Me.LogoTextBox)
        Me.Controls.Add(Me.EmpresaBindingNavigator)
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        CType(Me.DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresaBindingNavigator.ResumeLayout(False)
        Me.EmpresaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB As DB
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As DBTableAdapters.EmpresaTableAdapter
    Friend WithEvents TableAdapterManager As DBTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpresaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents FacebookTextBox As TextBox
    Friend WithEvents InstagramTextBox As TextBox
    Friend WithEvents TiktokTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TelegramTextBox As TextBox
    Friend WithEvents WhatsappTextBox As TextBox
    Friend WithEvents LogoTextBox As TextBox
End Class
