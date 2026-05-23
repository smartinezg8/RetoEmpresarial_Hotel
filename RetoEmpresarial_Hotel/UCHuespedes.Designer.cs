namespace RetoEmpresarial_Hotel
{
    partial class UCHuespedes
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
            this.dgvHuespedes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.colIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvHuespedes);
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 429);
            this.panel1.TabIndex = 0;
            // 
            // dgvHuespedes
            // 
            this.dgvHuespedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHuespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuespedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentificacion,
            this.colNombre,
            this.colObservaciones,
            this.colTelefono,
            this.colGuardar,
            this.colEliminar});
            this.dgvHuespedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuespedes.Location = new System.Drawing.Point(0, 0);
            this.dgvHuespedes.Name = "dgvHuespedes";
            this.dgvHuespedes.RowHeadersVisible = false;
            this.dgvHuespedes.RowHeadersWidth = 51;
            this.dgvHuespedes.Size = new System.Drawing.Size(825, 429);
            this.dgvHuespedes.TabIndex = 0;
            this.dgvHuespedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuespedes_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(705, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(56, 55);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.HeaderText = "Identificacion";
            this.colIdentificacion.MinimumWidth = 6;
            this.colIdentificacion.Name = "colIdentificacion";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colObservaciones
            // 
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.MinimumWidth = 6;
            this.colObservaciones.Name = "colObservaciones";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            // 
            // colGuardar
            // 
            this.colGuardar.HeaderText = "Guardar";
            this.colGuardar.MinimumWidth = 6;
            this.colGuardar.Name = "colGuardar";
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Relicta Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 44);
            this.label6.TabIndex = 19;
            this.label6.Text = "Información huéspedes";
            this.label6.UseWaitCursor = true;
            // 
            // UCHuespedes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "UCHuespedes";
            this.Size = new System.Drawing.Size(825, 567);
            this.Load += new System.EventHandler(this.UCHuespedes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuespedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHuespedes;
        private Guna.UI2.WinForms.Guna2CircleButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn colGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Label label6;
    }
}
