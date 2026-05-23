namespace RetoEmpresarial_Hotel
{
    partial class UCServicios
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
            this.cmbReservas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbServicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnDisponibilidad = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione su reserva:";
            // 
            // cmbReservas
            // 
            this.cmbReservas.BackColor = System.Drawing.Color.Transparent;
            this.cmbReservas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservas.FocusedColor = System.Drawing.Color.Empty;
            this.cmbReservas.FocusedState.Parent = this.cmbReservas;
            this.cmbReservas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbReservas.FormattingEnabled = true;
            this.cmbReservas.HoverState.Parent = this.cmbReservas;
            this.cmbReservas.ItemHeight = 30;
            this.cmbReservas.ItemsAppearance.Parent = this.cmbReservas;
            this.cmbReservas.Location = new System.Drawing.Point(369, 160);
            this.cmbReservas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReservas.Name = "cmbReservas";
            this.cmbReservas.ShadowDecoration.Parent = this.cmbReservas;
            this.cmbReservas.Size = new System.Drawing.Size(233, 36);
            this.cmbReservas.TabIndex = 21;
            this.cmbReservas.UseWaitCursor = true;
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.Transparent;
            this.cmbServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FocusedColor = System.Drawing.Color.Empty;
            this.cmbServicio.FocusedState.Parent = this.cmbServicio;
            this.cmbServicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.HoverState.Parent = this.cmbServicio;
            this.cmbServicio.ItemHeight = 30;
            this.cmbServicio.ItemsAppearance.Parent = this.cmbServicio;
            this.cmbServicio.Location = new System.Drawing.Point(362, 296);
            this.cmbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.ShadowDecoration.Parent = this.cmbServicio;
            this.cmbServicio.Size = new System.Drawing.Size(257, 36);
            this.cmbServicio.TabIndex = 23;
            this.cmbServicio.UseWaitCursor = true;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Servicio que desea solicitar:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(396, 334);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(0, 25);
            this.lblCosto.TabIndex = 24;
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.BorderRadius = 10;
            this.btnDisponibilidad.CheckedState.Parent = this.btnDisponibilidad;
            this.btnDisponibilidad.CustomImages.Parent = this.btnDisponibilidad;
            this.btnDisponibilidad.FillColor = System.Drawing.SystemColors.ControlDark;
            this.btnDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisponibilidad.ForeColor = System.Drawing.Color.White;
            this.btnDisponibilidad.HoverState.Parent = this.btnDisponibilidad;
            this.btnDisponibilidad.Location = new System.Drawing.Point(401, 396);
            this.btnDisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.ShadowDecoration.Parent = this.btnDisponibilidad;
            this.btnDisponibilidad.Size = new System.Drawing.Size(179, 39);
            this.btnDisponibilidad.TabIndex = 25;
            this.btnDisponibilidad.Text = "Solicitar Servicio";
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Relicta Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 50);
            this.label4.TabIndex = 26;
            this.label4.Text = "Servicios";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(435, 437);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 27;
            // 
            // UCServicios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisponibilidad);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbReservas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCServicios";
            this.Size = new System.Drawing.Size(1000, 513);
            this.Load += new System.EventHandler(this.UCServicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbReservas;
        private Guna.UI2.WinForms.Guna2ComboBox cmbServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCosto;
        private Guna.UI2.WinForms.Guna2Button btnDisponibilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
    }
}
