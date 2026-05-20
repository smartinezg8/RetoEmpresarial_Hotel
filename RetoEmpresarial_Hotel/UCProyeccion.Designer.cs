namespace RetoEmpresarial_Hotel
{
    partial class UCProyeccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione un mes:";
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(324, 252);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(137, 21);
            this.cmbMes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Relicta Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresos proyectados";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BorderRadius = 10;
            this.btnCalcular.CheckedState.Parent = this.btnCalcular;
            this.btnCalcular.CustomImages.Parent = this.btnCalcular;
            this.btnCalcular.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.HoverState.Parent = this.btnCalcular;
            this.btnCalcular.Location = new System.Drawing.Point(336, 278);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.ShadowDecoration.Parent = this.btnCalcular;
            this.btnCalcular.Size = new System.Drawing.Size(115, 37);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingresos proyectados:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(357, 407);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 21);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Resultado";
            // 
            // UCProyeccion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label1);
            this.Name = "UCProyeccion";
            this.Size = new System.Drawing.Size(787, 572);
            this.Load += new System.EventHandler(this.UCProyeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
    }
}
