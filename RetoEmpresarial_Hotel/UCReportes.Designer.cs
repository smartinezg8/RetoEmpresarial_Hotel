namespace RetoEmpresarial_Hotel
{
    partial class UCReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chartOcupacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWebPresencial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartWeb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlIngresosPeriodo = new System.Windows.Forms.Panel();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIngresosPeriodo = new System.Windows.Forms.Label();
            this.btnGenerar = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIni = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupacion)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeb)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlIngresosPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblOcupacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chartOcupacion);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 300);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Relicta Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ocupación por habitación";
            // 
            // chartOcupacion
            // 
            this.chartOcupacion.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.Name = "ChartArea1";
            this.chartOcupacion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOcupacion.Legends.Add(legend1);
            this.chartOcupacion.Location = new System.Drawing.Point(379, 28);
            this.chartOcupacion.Name = "chartOcupacion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOcupacion.Series.Add(series1);
            this.chartOcupacion.Size = new System.Drawing.Size(338, 238);
            this.chartOcupacion.TabIndex = 3;
            this.chartOcupacion.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Relicta Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblWebPresencial);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chartWeb);
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 300);
            this.panel2.TabIndex = 4;
            // 
            // lblWebPresencial
            // 
            this.lblWebPresencial.AutoSize = true;
            this.lblWebPresencial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebPresencial.Location = new System.Drawing.Point(52, 111);
            this.lblWebPresencial.Name = "lblWebPresencial";
            this.lblWebPresencial.Size = new System.Drawing.Size(81, 28);
            this.lblWebPresencial.TabIndex = 7;
            this.lblWebPresencial.Text = "Reporte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Relicta Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Reserva Web vs Presencial";
            // 
            // chartWeb
            // 
            this.chartWeb.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea2.Name = "ChartArea1";
            this.chartWeb.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWeb.Legends.Add(legend2);
            this.chartWeb.Location = new System.Drawing.Point(379, 37);
            this.chartWeb.Name = "chartWeb";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartWeb.Series.Add(series2);
            this.chartWeb.Size = new System.Drawing.Size(338, 238);
            this.chartWeb.TabIndex = 3;
            this.chartWeb.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.pnlIngresosPeriodo);
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dtpFin);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dtpIni);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 730);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 447);
            this.panel3.TabIndex = 7;
            // 
            // pnlIngresosPeriodo
            // 
            this.pnlIngresosPeriodo.Controls.Add(this.chartIngresos);
            this.pnlIngresosPeriodo.Controls.Add(this.lblIngresosPeriodo);
            this.pnlIngresosPeriodo.Location = new System.Drawing.Point(295, 14);
            this.pnlIngresosPeriodo.Name = "pnlIngresosPeriodo";
            this.pnlIngresosPeriodo.Size = new System.Drawing.Size(462, 433);
            this.pnlIngresosPeriodo.TabIndex = 18;
            this.pnlIngresosPeriodo.Visible = false;
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea3.Name = "ChartArea1";
            this.chartIngresos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIngresos.Legends.Add(legend3);
            this.chartIngresos.Location = new System.Drawing.Point(44, 149);
            this.chartIngresos.Name = "chartIngresos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartIngresos.Series.Add(series3);
            this.chartIngresos.Size = new System.Drawing.Size(393, 256);
            this.chartIngresos.TabIndex = 8;
            this.chartIngresos.Text = "chart2";
            // 
            // lblIngresosPeriodo
            // 
            this.lblIngresosPeriodo.AutoSize = true;
            this.lblIngresosPeriodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosPeriodo.Location = new System.Drawing.Point(129, 18);
            this.lblIngresosPeriodo.Name = "lblIngresosPeriodo";
            this.lblIngresosPeriodo.Size = new System.Drawing.Size(81, 28);
            this.lblIngresosPeriodo.TabIndex = 10;
            this.lblIngresosPeriodo.Text = "Reporte";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BorderRadius = 10;
            this.btnGenerar.CheckedState.Parent = this.btnGenerar;
            this.btnGenerar.CustomImages.Parent = this.btnGenerar;
            this.btnGenerar.FillColor = System.Drawing.Color.Gray;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.HoverState.Parent = this.btnGenerar;
            this.btnGenerar.Location = new System.Drawing.Point(69, 339);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.ShadowDecoration.Parent = this.btnGenerar;
            this.btnGenerar.Size = new System.Drawing.Size(101, 30);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 28);
            this.label11.TabIndex = 8;
            this.label11.Text = "Fecha Fin:";
            // 
            // dtpFin
            // 
            this.dtpFin.BorderRadius = 15;
            this.dtpFin.CheckedState.Parent = this.dtpFin;
            this.dtpFin.FillColor = System.Drawing.Color.Silver;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.HoverState.Parent = this.dtpFin;
            this.dtpFin.Location = new System.Drawing.Point(21, 266);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShadowDecoration.Parent = this.dtpFin;
            this.dtpFin.Size = new System.Drawing.Size(238, 36);
            this.dtpFin.TabIndex = 9;
            this.dtpFin.Value = new System.DateTime(2026, 5, 20, 15, 32, 12, 142);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha inicio:";
            // 
            // dtpIni
            // 
            this.dtpIni.BorderRadius = 15;
            this.dtpIni.CheckedState.Parent = this.dtpIni;
            this.dtpIni.FillColor = System.Drawing.Color.Silver;
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIni.HoverState.Parent = this.dtpIni;
            this.dtpIni.Location = new System.Drawing.Point(21, 149);
            this.dtpIni.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIni.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.ShadowDecoration.Parent = this.dtpIni;
            this.dtpIni.Size = new System.Drawing.Size(238, 36);
            this.dtpIni.TabIndex = 7;
            this.dtpIni.Value = new System.DateTime(2026, 5, 20, 15, 32, 12, 142);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Relicta Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ingresos por período";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.Location = new System.Drawing.Point(52, 93);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(81, 28);
            this.lblOcupacion.TabIndex = 6;
            this.lblOcupacion.Text = "Reporte";
            // 
            // UCReportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UCReportes";
            this.Size = new System.Drawing.Size(780, 990);
            this.Load += new System.EventHandler(this.UCReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeb)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlIngresosPeriodo.ResumeLayout(false);
            this.pnlIngresosPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOcupacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWebPresencial;
        private System.Windows.Forms.Label lblIngresosPeriodo;
        private Guna.UI2.WinForms.Guna2Button btnGenerar;
        private System.Windows.Forms.Panel pnlIngresosPeriodo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.Label lblOcupacion;
    }
}
