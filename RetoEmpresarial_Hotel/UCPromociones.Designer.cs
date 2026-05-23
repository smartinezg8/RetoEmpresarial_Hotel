namespace RetoEmpresarial_Hotel
{
    partial class UCPromociones
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIni = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Relicta Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Promociones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 250);
            this.panel1.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.BorderRadius = 10;
            this.btnCrear.CheckedState.Parent = this.btnCrear;
            this.btnCrear.CustomImages.Parent = this.btnCrear;
            this.btnCrear.FillColor = System.Drawing.Color.Gray;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.HoverState.Parent = this.btnCrear;
            this.btnCrear.Location = new System.Drawing.Point(571, 157);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.ShadowDecoration.Parent = this.btnCrear;
            this.btnCrear.Size = new System.Drawing.Size(121, 28);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Aplicable a:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(571, 103);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Porcentaje de descuento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre de la promoción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.BorderRadius = 15;
            this.dtpFin.CheckedState.Parent = this.dtpFin;
            this.dtpFin.FillColor = System.Drawing.Color.Silver;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.HoverState.Parent = this.dtpFin;
            this.dtpFin.Location = new System.Drawing.Point(296, 153);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShadowDecoration.Parent = this.dtpFin;
            this.dtpFin.Size = new System.Drawing.Size(229, 32);
            this.dtpFin.TabIndex = 10;
            this.dtpFin.Value = new System.DateTime(2026, 5, 20, 15, 32, 12, 142);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha inicio:";
            // 
            // dtpIni
            // 
            this.dtpIni.BorderRadius = 15;
            this.dtpIni.CheckedState.Parent = this.dtpIni;
            this.dtpIni.FillColor = System.Drawing.Color.Silver;
            this.dtpIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIni.HoverState.Parent = this.dtpIni;
            this.dtpIni.Location = new System.Drawing.Point(296, 87);
            this.dtpIni.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIni.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.ShadowDecoration.Parent = this.dtpIni;
            this.dtpIni.Size = new System.Drawing.Size(229, 32);
            this.dtpIni.TabIndex = 8;
            this.dtpIni.Value = new System.DateTime(2026, 5, 20, 15, 32, 12, 142);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BorderColor = System.Drawing.Color.Gray;
            this.txtDesc.BorderRadius = 10;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.DefaultText = "";
            this.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.DisabledState.Parent = this.txtDesc;
            this.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesc.FillColor = System.Drawing.SystemColors.Control;
            this.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.FocusedState.Parent = this.txtDesc;
            this.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesc.HoverState.Parent = this.txtDesc;
            this.txtDesc.Location = new System.Drawing.Point(32, 158);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDesc.PlaceholderText = "% de descuento";
            this.txtDesc.SelectedText = "";
            this.txtDesc.ShadowDecoration.Parent = this.txtDesc;
            this.txtDesc.Size = new System.Drawing.Size(196, 27);
            this.txtDesc.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.txtNombre.Location = new System.Drawing.Point(32, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(196, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Relicta Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gestionar promociones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dgvPromo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 297);
            this.panel2.TabIndex = 18;
            // 
            // dgvPromo
            // 
            this.dgvPromo.AllowUserToAddRows = false;
            this.dgvPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colDescuento,
            this.colInicio,
            this.colFin,
            this.colAplica,
            this.colEliminar});
            this.dgvPromo.Location = new System.Drawing.Point(3, 71);
            this.dgvPromo.MultiSelect = false;
            this.dgvPromo.Name = "dgvPromo";
            this.dgvPromo.ReadOnly = true;
            this.dgvPromo.RowHeadersVisible = false;
            this.dgvPromo.RowHeadersWidth = 51;
            this.dgvPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromo.Size = new System.Drawing.Size(764, 223);
            this.dgvPromo.TabIndex = 6;
            this.dgvPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromo_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.MinimumWidth = 6;
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colInicio
            // 
            this.colInicio.HeaderText = "Inicio";
            this.colInicio.MinimumWidth = 6;
            this.colInicio.Name = "colInicio";
            this.colInicio.ReadOnly = true;
            // 
            // colFin
            // 
            this.colFin.HeaderText = "Fin";
            this.colFin.MinimumWidth = 6;
            this.colFin.Name = "colFin";
            this.colFin.ReadOnly = true;
            // 
            // colAplica
            // 
            this.colAplica.HeaderText = "Aplica";
            this.colAplica.MinimumWidth = 6;
            this.colAplica.Name = "colAplica";
            this.colAplica.ReadOnly = true;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.UseColumnTextForButtonValue = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Relicta Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(264, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 30);
            this.label13.TabIndex = 5;
            this.label13.Text = "Promociones registradas";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(304, 220);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 18;
            // 
            // UCPromociones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UCPromociones";
            this.Size = new System.Drawing.Size(769, 609);
            this.Load += new System.EventHandler(this.UCPromociones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtDesc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCrear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAplica;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Label lblError;
    }
}
