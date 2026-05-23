namespace RetoEmpresarial_Hotel
{
    partial class UCSolicitarServicios
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
            this.btnAgregar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(690, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(56, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "+";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvServicios);
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 376);
            this.panel1.TabIndex = 2;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colHabitacion,
            this.colServicio,
            this.colCosto,
            this.colOrigen,
            this.colEstado,
            this.colGuardar,
            this.colEliminar});
            this.dgvServicios.Location = new System.Drawing.Point(0, 65);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.Size = new System.Drawing.Size(825, 298);
            this.dgvServicios.TabIndex = 0;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            this.dgvServicios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Relicta Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 44);
            this.label6.TabIndex = 18;
            this.label6.Text = "Solicitar Servicios";
            this.label6.UseWaitCursor = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID reserva";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colHabitacion
            // 
            this.colHabitacion.HeaderText = "Habitación";
            this.colHabitacion.MinimumWidth = 6;
            this.colHabitacion.Name = "colHabitacion";
            // 
            // colServicio
            // 
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.MinimumWidth = 6;
            this.colServicio.Name = "colServicio";
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.MinimumWidth = 6;
            this.colCosto.Name = "colCosto";
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 6;
            this.colOrigen.Name = "colOrigen";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Entregado"});
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // UCSolicitarServicios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "UCSolicitarServicios";
            this.Size = new System.Drawing.Size(825, 567);
            this.Load += new System.EventHandler(this.UCSolicitarServicios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabitacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}
