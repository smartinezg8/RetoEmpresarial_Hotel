namespace RetoEmpresarial_Hotel
{
    partial class UCPrecioEstancia
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
            this.txtReserva = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new Guna.UI2.WinForms.Guna2Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReserva
            // 
            this.txtReserva.BackColor = System.Drawing.Color.Transparent;
            this.txtReserva.BorderColor = System.Drawing.Color.Gray;
            this.txtReserva.BorderRadius = 20;
            this.txtReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReserva.DefaultText = "";
            this.txtReserva.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReserva.DisabledState.Parent = this.txtReserva;
            this.txtReserva.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReserva.FillColor = System.Drawing.SystemColors.Control;
            this.txtReserva.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtReserva.FocusedState.Parent = this.txtReserva;
            this.txtReserva.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReserva.HoverState.Parent = this.txtReserva;
            this.txtReserva.Location = new System.Drawing.Point(42, 88);
            this.txtReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.PasswordChar = '\0';
            this.txtReserva.PlaceholderText = "Código";
            this.txtReserva.SelectedText = "";
            this.txtReserva.ShadowDecoration.Parent = this.txtReserva;
            this.txtReserva.Size = new System.Drawing.Size(253, 34);
            this.txtReserva.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Relicta Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcular precio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código de reserva";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BorderRadius = 10;
            this.btnCalcular.CheckedState.Parent = this.btnCalcular;
            this.btnCalcular.CustomImages.Parent = this.btnCalcular;
            this.btnCalcular.FillColor = System.Drawing.Color.Gray;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.HoverState.Parent = this.btnCalcular;
            this.btnCalcular.Location = new System.Drawing.Point(327, 88);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.ShadowDecoration.Parent = this.btnCalcular;
            this.btnCalcular.Size = new System.Drawing.Size(121, 34);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(55, 126);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(180, 32);
            this.lblError.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Habitación:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Noches:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Promoción:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Servicios:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(377, 229);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(122, 32);
            this.lblHabitacion.TabIndex = 25;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblNoches
            // 
            this.lblNoches.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoches.Location = new System.Drawing.Point(377, 261);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(122, 32);
            this.lblNoches.TabIndex = 26;
            this.lblNoches.Text = "Noches";
            // 
            // lblPromocion
            // 
            this.lblPromocion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(377, 293);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(122, 32);
            this.lblPromocion.TabIndex = 27;
            this.lblPromocion.Text = "Promoción";
            // 
            // lblServicios
            // 
            this.lblServicios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(377, 357);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(198, 32);
            this.lblServicios.TabIndex = 28;
            this.lblServicios.Text = "Servicios";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(364, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 32);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BorderRadius = 10;
            this.btnFinalizar.CheckedState.Parent = this.btnFinalizar;
            this.btnFinalizar.CustomImages.Parent = this.btnFinalizar;
            this.btnFinalizar.FillColor = System.Drawing.Color.Black;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.HoverState.Parent = this.btnFinalizar;
            this.btnFinalizar.Location = new System.Drawing.Point(270, 485);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.ShadowDecoration.Parent = this.btnFinalizar;
            this.btnFinalizar.Size = new System.Drawing.Size(163, 49);
            this.btnFinalizar.TabIndex = 30;
            this.btnFinalizar.Text = "Finalizar estancia";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(377, 325);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(122, 32);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "Estado:";
            // 
            // UCPrecioEstancia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.label1);
            this.Name = "UCPrecioEstancia";
            this.Size = new System.Drawing.Size(825, 567);
            this.Load += new System.EventHandler(this.UCPrecioEstancia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCalcular;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnFinalizar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label9;
    }
}
