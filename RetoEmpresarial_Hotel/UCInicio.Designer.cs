namespace RetoEmpresarial_Hotel
{
    partial class UCInicio
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
            this.panelInicio = new Guna.UI2.WinForms.Guna2Panel();
            this.hotelNombre = new System.Windows.Forms.Label();
            this.fraseHotel = new System.Windows.Forms.Label();
            this.fotoHotel = new System.Windows.Forms.PictureBox();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.Transparent;
            this.panelInicio.Controls.Add(this.hotelNombre);
            this.panelInicio.Controls.Add(this.fraseHotel);
            this.panelInicio.Controls.Add(this.fotoHotel);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.FillColor = System.Drawing.Color.Transparent;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.ShadowDecoration.Parent = this.panelInicio;
            this.panelInicio.Size = new System.Drawing.Size(750, 417);
            this.panelInicio.TabIndex = 1;
            this.panelInicio.UseTransparentBackground = true;
            // 
            // hotelNombre
            // 
            this.hotelNombre.AutoSize = true;
            this.hotelNombre.BackColor = System.Drawing.Color.Transparent;
            this.hotelNombre.Font = new System.Drawing.Font("Relicta Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelNombre.ForeColor = System.Drawing.Color.DimGray;
            this.hotelNombre.Location = new System.Drawing.Point(28, 147);
            this.hotelNombre.Name = "hotelNombre";
            this.hotelNombre.Size = new System.Drawing.Size(239, 77);
            this.hotelNombre.TabIndex = 2;
            this.hotelNombre.Text = "Velisse";
            // 
            // fraseHotel
            // 
            this.fraseHotel.AutoSize = true;
            this.fraseHotel.BackColor = System.Drawing.Color.Transparent;
            this.fraseHotel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraseHotel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fraseHotel.Location = new System.Drawing.Point(53, 293);
            this.fraseHotel.Name = "fraseHotel";
            this.fraseHotel.Size = new System.Drawing.Size(187, 52);
            this.fraseHotel.TabIndex = 1;
            this.fraseHotel.Text = "Más que un hotel,\r\nuna experiencia";
            // 
            // fotoHotel
            // 
            this.fotoHotel.BackColor = System.Drawing.Color.Transparent;
            this.fotoHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fotoHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fotoHotel.Image = global::RetoEmpresarial_Hotel.Properties.Resources.HotelImage;
            this.fotoHotel.Location = new System.Drawing.Point(0, 0);
            this.fotoHotel.Name = "fotoHotel";
            this.fotoHotel.Size = new System.Drawing.Size(750, 417);
            this.fotoHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoHotel.TabIndex = 0;
            this.fotoHotel.TabStop = false;
            this.fotoHotel.Click += new System.EventHandler(this.fotoHotel_Click);
            // 
            // UCInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInicio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCInicio";
            this.Size = new System.Drawing.Size(750, 418);
            this.Load += new System.EventHandler(this.UCInicio_Load);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoHotel;
        private Guna.UI2.WinForms.Guna2Panel panelInicio;
        private System.Windows.Forms.Label fraseHotel;
        private System.Windows.Forms.Label hotelNombre;
    }
}
