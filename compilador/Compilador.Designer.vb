<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compilador
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CodigoAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigoA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigoA3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CódigoA4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitarCarácteresDeRetornoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EjecutarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXTsalida = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTcodigo = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GridERR = New System.Windows.Forms.DataGridView
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.GridV = New System.Windows.Forms.DataGridView
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GridE = New System.Windows.Forms.DataGridView
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ccl3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GridSinE = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GridsemE = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.cl1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cl2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clval = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigosBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.B2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.B3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridERR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridSinE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridsemE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EjecutarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigosToolStripMenuItem, Me.CodigosBToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CódigosToolStripMenuItem
        '
        Me.CódigosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodigoAToolStripMenuItem, Me.CódigoA2ToolStripMenuItem, Me.CódigoA3ToolStripMenuItem, Me.CódigoA4ToolStripMenuItem})
        Me.CódigosToolStripMenuItem.Name = "CódigosToolStripMenuItem"
        Me.CódigosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CódigosToolStripMenuItem.Text = "Códigos A"
        '
        'CodigoAToolStripMenuItem
        '
        Me.CodigoAToolStripMenuItem.Name = "CodigoAToolStripMenuItem"
        Me.CodigoAToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CodigoAToolStripMenuItem.Text = "Código A1"
        '
        'CódigoA2ToolStripMenuItem
        '
        Me.CódigoA2ToolStripMenuItem.Name = "CódigoA2ToolStripMenuItem"
        Me.CódigoA2ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CódigoA2ToolStripMenuItem.Text = "Código A2"
        '
        'CódigoA3ToolStripMenuItem
        '
        Me.CódigoA3ToolStripMenuItem.Name = "CódigoA3ToolStripMenuItem"
        Me.CódigoA3ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CódigoA3ToolStripMenuItem.Text = "Código A3"
        '
        'CódigoA4ToolStripMenuItem
        '
        Me.CódigoA4ToolStripMenuItem.Name = "CódigoA4ToolStripMenuItem"
        Me.CódigoA4ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CódigoA4ToolStripMenuItem.Text = "Código A4"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.QuitarCarácteresDeRetornoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar código"
        '
        'QuitarCarácteresDeRetornoToolStripMenuItem
        '
        Me.QuitarCarácteresDeRetornoToolStripMenuItem.Name = "QuitarCarácteresDeRetornoToolStripMenuItem"
        Me.QuitarCarácteresDeRetornoToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.QuitarCarácteresDeRetornoToolStripMenuItem.Text = "Quitar carácteres de retorno"
        '
        'EjecutarToolStripMenuItem
        '
        Me.EjecutarToolStripMenuItem.Name = "EjecutarToolStripMenuItem"
        Me.EjecutarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EjecutarToolStripMenuItem.Text = "Compilar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Manual"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(38, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1263, 707)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TXTsalida)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TXTcodigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1255, 681)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Salida:"
        '
        'TXTsalida
        '
        Me.TXTsalida.Location = New System.Drawing.Point(23, 405)
        Me.TXTsalida.Multiline = True
        Me.TXTsalida.Name = "TXTsalida"
        Me.TXTsalida.Size = New System.Drawing.Size(1225, 155)
        Me.TXTsalida.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        '
        'TXTcodigo
        '
        Me.TXTcodigo.Location = New System.Drawing.Point(18, 36)
        Me.TXTcodigo.Multiline = True
        Me.TXTcodigo.Name = "TXTcodigo"
        Me.TXTcodigo.Size = New System.Drawing.Size(1217, 325)
        Me.TXTcodigo.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridERR)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.GridV)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GridE)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Grid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1255, 681)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ver análisis léxico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridERR
        '
        Me.GridERR.AllowUserToAddRows = False
        Me.GridERR.AllowUserToDeleteRows = False
        Me.GridERR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridERR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5})
        Me.GridERR.Location = New System.Drawing.Point(522, 449)
        Me.GridERR.Name = "GridERR"
        Me.GridERR.Size = New System.Drawing.Size(419, 183)
        Me.GridERR.TabIndex = 11
        '
        'Column5
        '
        Me.Column5.HeaderText = "Descripción"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(518, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Errores"
        '
        'GridV
        '
        Me.GridV.AllowUserToAddRows = False
        Me.GridV.AllowUserToDeleteRows = False
        Me.GridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        Me.GridV.Location = New System.Drawing.Point(522, 43)
        Me.GridV.Name = "GridV"
        Me.GridV.Size = New System.Drawing.Size(419, 357)
        Me.GridV.TabIndex = 7
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Valor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(518, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Variables:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estadísticas"
        '
        'GridE
        '
        Me.GridE.AllowUserToAddRows = False
        Me.GridE.AllowUserToDeleteRows = False
        Me.GridE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.ccl3, Me.c4})
        Me.GridE.Location = New System.Drawing.Point(47, 449)
        Me.GridE.Name = "GridE"
        Me.GridE.Size = New System.Drawing.Size(343, 183)
        Me.GridE.TabIndex = 4
        '
        'c1
        '
        Me.c1.HeaderText = "# Compilación"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        '
        'ccl3
        '
        Me.ccl3.HeaderText = "Sentencias"
        Me.ccl3.Name = "ccl3"
        Me.ccl3.ReadOnly = True
        '
        'c4
        '
        Me.c4.HeaderText = "Palabras Reservadas"
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Análisis léxico agrupado en categorías"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl1, Me.cl2, Me.clval, Me.Column7})
        Me.Grid.Location = New System.Drawing.Point(46, 43)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(459, 357)
        Me.Grid.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridSinE)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1255, 681)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ver análisis sintáctico"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridSinE
        '
        Me.GridSinE.AllowUserToAddRows = False
        Me.GridSinE.AllowUserToDeleteRows = False
        Me.GridSinE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSinE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1, Me.Column6})
        Me.GridSinE.Location = New System.Drawing.Point(45, 56)
        Me.GridSinE.Name = "GridSinE"
        Me.GridSinE.Size = New System.Drawing.Size(1047, 266)
        Me.GridSinE.TabIndex = 13
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sentencia"
        Me.Column4.Name = "Column4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 700
        '
        'Column6
        '
        Me.Column6.HeaderText = "Línea"
        Me.Column6.Name = "Column6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Errores"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GridsemE)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1255, 681)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ver análisis semántico"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GridsemE
        '
        Me.GridsemE.AllowUserToAddRows = False
        Me.GridsemE.AllowUserToDeleteRows = False
        Me.GridsemE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridsemE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GridsemE.Location = New System.Drawing.Point(45, 62)
        Me.GridsemE.Name = "GridsemE"
        Me.GridsemE.Size = New System.Drawing.Size(1047, 266)
        Me.GridsemE.TabIndex = 15
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sentencia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 700
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Línea"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Errores"
        '
        'cl1
        '
        Me.cl1.HeaderText = "Sentencia"
        Me.cl1.Name = "cl1"
        '
        'cl2
        '
        Me.cl2.HeaderText = "Categoría"
        Me.cl2.Name = "cl2"
        Me.cl2.ReadOnly = True
        '
        'clval
        '
        Me.clval.HeaderText = "Palabra léxica"
        Me.clval.Name = "clval"
        Me.clval.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Valor"
        Me.Column7.Name = "Column7"
        '
        'CodigosBToolStripMenuItem
        '
        Me.CodigosBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BToolStripMenuItem, Me.B2ToolStripMenuItem, Me.B3ToolStripMenuItem})
        Me.CodigosBToolStripMenuItem.Name = "CodigosBToolStripMenuItem"
        Me.CodigosBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CodigosBToolStripMenuItem.Text = "Codigos B"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BToolStripMenuItem.Text = "B1"
        '
        'B2ToolStripMenuItem
        '
        Me.B2ToolStripMenuItem.Name = "B2ToolStripMenuItem"
        Me.B2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.B2ToolStripMenuItem.Text = "B2"
        '
        'B3ToolStripMenuItem
        '
        Me.B3ToolStripMenuItem.Name = "B3ToolStripMenuItem"
        Me.B3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.B3ToolStripMenuItem.Text = "B3"
        '
        'Compilador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Compilador"
        Me.Text = "Compilador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridERR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridSinE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GridsemE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EjecutarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CódigosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodigoAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CódigoA2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTsalida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridE As System.Windows.Forms.DataGridView
    Friend WithEvents GridV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccl3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridERR As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CódigoA3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GridSinE As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents QuitarCarácteresDeRetornoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GridsemE As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CódigoA4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cl1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigosBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
