namespace RetoEmpresarial_Hotel
{
    partial class UCVerReservas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHabitacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nudNoches = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoches)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 80);
            this.panel1.TabIndex = 4;
            this.panel1.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvReservas);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 324);
            this.panel3.TabIndex = 7;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.ColumnHeadersHeight = 30;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCliente,
            this.colDocumento,
            this.colHabitacion,
            this.colTipo,
            this.colEntrada,
            this.colSalida,
            this.colNoches,
            this.colEstado,
            this.colOrigen,
            this.colGuardar,
            this.colCancelar});
            this.dgvReservas.Location = new System.Drawing.Point(0, 58);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(1239, 263);
            this.dgvReservas.TabIndex = 18;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            this.dgvReservas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvReservas_DataError);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Relicta Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tabla de reservas";
            this.label6.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbHabitacion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnCrear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFechaEntrada);
            this.panel2.Controls.Add(this.nudNoches);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(13, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 412);
            this.panel2.TabIndex = 8;
            this.panel2.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Habitación asignada:";
            this.label9.UseWaitCursor = true;
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.cmbHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitacion.FocusedColor = System.Drawing.Color.Empty;
            this.cmbHabitacion.FocusedState.Parent = this.cmbHabitacion;
            this.cmbHabitacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.HoverState.Parent = this.cmbHabitacion;
            this.cmbHabitacion.ItemHeight = 30;
            this.cmbHabitacion.ItemsAppearance.Parent = this.cmbHabitacion;
            this.cmbHabitacion.Location = new System.Drawing.Point(390, 198);
            this.cmbHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.ShadowDecoration.Parent = this.cmbHabitacion;
            this.cmbHabitacion.Size = new System.Drawing.Size(185, 36);
            this.cmbHabitacion.TabIndex = 20;
            this.cmbHabitacion.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Identificación:";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cliente:";
            this.label7.UseWaitCursor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.BorderRadius = 10;
            this.btnCrear.CheckedState.Parent = this.btnCrear;
            this.btnCrear.CustomImages.Parent = this.btnCrear;
            this.btnCrear.FillColor = System.Drawing.SystemColors.ControlDark;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.HoverState.Parent = this.btnCrear;
            this.btnCrear.Location = new System.Drawing.Point(332, 344);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.ShadowDecoration.Parent = this.btnCrear;
            this.btnCrear.Size = new System.Drawing.Size(121, 36);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Crear reserva";
            this.btnCrear.UseWaitCursor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Relicta Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "Datos Reserva";
            this.label5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de habitación";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Número de noches";
            this.label2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de entrada";
            this.label4.UseWaitCursor = true;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.CheckedState.Parent = this.dtpFechaEntrada;
            this.dtpFechaEntrada.FillColor = System.Drawing.Color.Silver;
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaEntrada.HoverState.Parent = this.dtpFechaEntrada;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(197, 280);
            this.dtpFechaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEntrada.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEntrada.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.ShadowDecoration.Parent = this.dtpFechaEntrada;
            this.dtpFechaEntrada.Size = new System.Drawing.Size(225, 29);
            this.dtpFechaEntrada.TabIndex = 10;
            this.dtpFechaEntrada.UseWaitCursor = true;
            this.dtpFechaEntrada.Value = new System.DateTime(2026, 5, 22, 0, 0, 0, 0);
            // 
            // nudNoches
            // 
            this.nudNoches.BackColor = System.Drawing.Color.Transparent;
            this.nudNoches.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudNoches.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNoches.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudNoches.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudNoches.DisabledState.Parent = this.nudNoches;
            this.nudNoches.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudNoches.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudNoches.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudNoches.FocusedState.Parent = this.nudNoches;
            this.nudNoches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudNoches.Location = new System.Drawing.Point(463, 280);
            this.nudNoches.Margin = new System.Windows.Forms.Padding(2);
            this.nudNoches.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoches.Name = "nudNoches";
            this.nudNoches.ShadowDecoration.Parent = this.nudNoches;
            this.nudNoches.Size = new System.Drawing.Size(75, 29);
            this.nudNoches.TabIndex = 11;
            this.nudNoches.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.nudNoches.UseWaitCursor = true;
            this.nudNoches.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipo.FocusedState.Parent = this.cmbTipo;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.HoverState.Parent = this.cmbTipo;
            this.cmbTipo.ItemHeight = 30;
            this.cmbTipo.ItemsAppearance.Parent = this.cmbTipo;
            this.cmbTipo.Location = new System.Drawing.Point(197, 198);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.ShadowDecoration.Parent = this.cmbTipo;
            this.cmbTipo.Size = new System.Drawing.Size(185, 36);
            this.cmbTipo.TabIndex = 12;
            this.cmbTipo.UseWaitCursor = true;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Transparent;
            this.txtDocumento.BorderColor = System.Drawing.Color.Gray;
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDocumento.DefaultText = "";
            this.txtDocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumento.DisabledState.Parent = this.txtDocumento;
            this.txtDocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocumento.FillColor = System.Drawing.SystemColors.Control;
            this.txtDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumento.FocusedState.Parent = this.txtDocumento;
            this.txtDocumento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocumento.HoverState.Parent = this.txtDocumento;
            this.txtDocumento.Location = new System.Drawing.Point(272, 113);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "Identificación";
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.ShadowDecoration.Parent = this.txtDocumento;
            this.txtDocumento.Size = new System.Drawing.Size(266, 32);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.SystemColors.Control;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(272, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre Cliente";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(266, 32);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseWaitCursor = true;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.MinimumWidth = 6;
            this.colDocumento.Name = "colDocumento";
            // 
            // colHabitacion
            // 
            this.colHabitacion.HeaderText = "Habitación";
            this.colHabitacion.MinimumWidth = 6;
            this.colHabitacion.Name = "colHabitacion";
            this.colHabitacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHabitacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEntrada
            // 
            this.colEntrada.HeaderText = "Entrada";
            this.colEntrada.MinimumWidth = 6;
            this.colEntrada.Name = "colEntrada";
            // 
            // colSalida
            // 
            this.colSalida.HeaderText = "Salida";
            this.colSalida.MinimumWidth = 6;
            this.colSalida.Name = "colSalida";
            // 
            // colNoches
            // 
            this.colNoches.HeaderText = "Noches";
            this.colNoches.MinimumWidth = 6;
            this.colNoches.Name = "colNoches";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 6;
            this.colOrigen.Name = "colOrigen";
            // 
            // colGuardar
            // 
            this.colGuardar.HeaderText = "Guardar";
            this.colGuardar.MinimumWidth = 6;
            this.colGuardar.Name = "colGuardar";
            this.colGuardar.UseColumnTextForButtonValue = true;
            // 
            // colCancelar
            // 
            this.colCancelar.HeaderText = "Cancelar";
            this.colCancelar.MinimumWidth = 6;
            this.colCancelar.Name = "colCancelar";
            this.colCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCancelar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCancelar.Text = "X";
            // 
            // UCVerReservas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCVerReservas";
            this.Size = new System.Drawing.Size(1237, 866);
            this.Load += new System.EventHandler(this.UCVerReservas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaEntrada;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNoches;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipo;
        private Guna.UI2.WinForms.Guna2TextBox txtDocumento;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHabitacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewComboBoxColumn colHabitacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoches;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewButtonColumn colGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn colCancelar;
    }
}
