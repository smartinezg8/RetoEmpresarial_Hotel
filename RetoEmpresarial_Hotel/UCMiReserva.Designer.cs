namespace RetoEmpresarial_Hotel
{
    partial class UCMiReserva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBuscarReserva = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigoReserva = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lblErrorCancelar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.btnBuscarReserva);
            this.panel1.Controls.Add(this.txtCodigoReserva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 141);
            this.panel1.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMensaje.Location = new System.Drawing.Point(400, 105);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 19);
            this.lblMensaje.TabIndex = 12;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.BorderRadius = 10;
            this.btnBuscarReserva.CheckedState.Parent = this.btnBuscarReserva;
            this.btnBuscarReserva.CustomImages.Parent = this.btnBuscarReserva;
            this.btnBuscarReserva.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscarReserva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReserva.HoverState.Parent = this.btnBuscarReserva;
            this.btnBuscarReserva.Location = new System.Drawing.Point(688, 62);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.ShadowDecoration.Parent = this.btnBuscarReserva;
            this.btnBuscarReserva.Size = new System.Drawing.Size(159, 39);
            this.btnBuscarReserva.TabIndex = 11;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoReserva.BorderColor = System.Drawing.Color.Gray;
            this.txtCodigoReserva.BorderRadius = 20;
            this.txtCodigoReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoReserva.DefaultText = "";
            this.txtCodigoReserva.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoReserva.DisabledState.Parent = this.txtCodigoReserva;
            this.txtCodigoReserva.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoReserva.FillColor = System.Drawing.SystemColors.Control;
            this.txtCodigoReserva.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtCodigoReserva.FocusedState.Parent = this.txtCodigoReserva;
            this.txtCodigoReserva.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoReserva.HoverState.Parent = this.txtCodigoReserva;
            this.txtCodigoReserva.Location = new System.Drawing.Point(393, 67);
            this.txtCodigoReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.PasswordChar = '\0';
            this.txtCodigoReserva.PlaceholderText = "";
            this.txtCodigoReserva.SelectedText = "";
            this.txtCodigoReserva.ShadowDecoration.Parent = this.txtCodigoReserva;
            this.txtCodigoReserva.Size = new System.Drawing.Size(259, 34);
            this.txtCodigoReserva.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese documento o código de reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Relicta Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Reserva";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 741);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panelDetalles);
            this.panel3.Controls.Add(this.dgvReservas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 600);
            this.panel3.TabIndex = 0;
            // 
            // panelDetalles
            // 
            this.panelDetalles.AutoScroll = true;
            this.panelDetalles.Controls.Add(this.lblErrorCancelar);
            this.panelDetalles.Controls.Add(this.label10);
            this.panelDetalles.Controls.Add(this.label9);
            this.panelDetalles.Controls.Add(this.label8);
            this.panelDetalles.Controls.Add(this.label7);
            this.panelDetalles.Controls.Add(this.label6);
            this.panelDetalles.Controls.Add(this.label5);
            this.panelDetalles.Controls.Add(this.label4);
            this.panelDetalles.Controls.Add(this.label3);
            this.panelDetalles.Controls.Add(this.btnCancelar);
            this.panelDetalles.Controls.Add(this.lblCodigo);
            this.panelDetalles.Controls.Add(this.lblTipo);
            this.panelDetalles.Controls.Add(this.lblTotal);
            this.panelDetalles.Controls.Add(this.lblPromocion);
            this.panelDetalles.Controls.Add(this.lblServicios);
            this.panelDetalles.Controls.Add(this.lblFechas);
            this.panelDetalles.Controls.Add(this.lblHabitacion);
            this.panelDetalles.Location = new System.Drawing.Point(6, 324);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(994, 273);
            this.panelDetalles.TabIndex = 19;
            // 
            // lblErrorCancelar
            // 
            this.lblErrorCancelar.AutoSize = true;
            this.lblErrorCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorCancelar.Location = new System.Drawing.Point(660, 250);
            this.lblErrorCancelar.Name = "lblErrorCancelar";
            this.lblErrorCancelar.Size = new System.Drawing.Size(0, 19);
            this.lblErrorCancelar.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(678, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(678, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Promoción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Servicios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fechas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Habitación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Relicta Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Detalles Reserva seleccionada";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(704, 215);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(131, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar reserva";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(498, 109);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 23);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(147, 109);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 23);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(789, 155);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 23);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(794, 109);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(93, 23);
            this.lblPromocion.TabIndex = 6;
            this.lblPromocion.Text = "Promoción";
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(498, 155);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(75, 23);
            this.lblServicios.TabIndex = 5;
            this.lblServicios.Text = "Servicios";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechas.Location = new System.Drawing.Point(147, 203);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(61, 23);
            this.lblFechas.TabIndex = 4;
            this.lblFechas.Text = "Fechas";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(147, 155);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(92, 23);
            this.lblHabitacion.TabIndex = 3;
            this.lblHabitacion.Text = "Habitación";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colHabitacion,
            this.colTipo,
            this.colFechaEntrada,
            this.colNoches,
            this.colTotal});
            this.dgvReservas.Location = new System.Drawing.Point(0, 30);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(1000, 275);
            this.dgvReservas.TabIndex = 18;
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colHabitacion
            // 
            this.colHabitacion.HeaderText = "Habitación";
            this.colHabitacion.MinimumWidth = 6;
            this.colHabitacion.Name = "colHabitacion";
            this.colHabitacion.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colFechaEntrada
            // 
            this.colFechaEntrada.HeaderText = "Fecha Entrada";
            this.colFechaEntrada.MinimumWidth = 6;
            this.colFechaEntrada.Name = "colFechaEntrada";
            this.colFechaEntrada.ReadOnly = true;
            // 
            // colNoches
            // 
            this.colNoches.HeaderText = "Noches";
            this.colNoches.MinimumWidth = 6;
            this.colNoches.Name = "colNoches";
            this.colNoches.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // UCMiReserva
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Name = "UCMiReserva";
            this.Size = new System.Drawing.Size(1000, 741);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoReserva;
        private Guna.UI2.WinForms.Guna2Button btnBuscarReserva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoches;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblErrorCancelar;
    }
}
