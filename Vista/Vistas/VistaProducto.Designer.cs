namespace Presentacion.Vistas
{
    partial class VistaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            graficaTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bindingSourceProducto = new BindingSource(components);
            label10 = new Label();
            label11 = new Label();
            radioLadrillo = new RadioButton();
            radioMadera = new RadioButton();
            label9 = new Label();
            radioCelulosa = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            labelConductividad = new Label();
            botonSimular = new Button();
            botonProduccion = new Button();
            labelEspesor = new Label();
            sliderEspesor = new TrackBar();
            label3 = new Label();
            labelExterior = new Label();
            labelInterior = new Label();
            label2 = new Label();
            label1 = new Label();
            splitExterior = new SplitContainer();
            splitCasa = new SplitContainer();
            panelInterior = new Panel();
            panelExterior = new Panel();
            timerSimulacion = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)graficaTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderEspesor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitExterior).BeginInit();
            splitExterior.Panel1.SuspendLayout();
            splitExterior.Panel2.SuspendLayout();
            splitExterior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitCasa).BeginInit();
            splitCasa.Panel1.SuspendLayout();
            splitCasa.SuspendLayout();
            panelInterior.SuspendLayout();
            panelExterior.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 234, 234);
            panel1.Controls.Add(graficaTemp);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(radioLadrillo);
            panel1.Controls.Add(radioMadera);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(radioCelulosa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelConductividad);
            panel1.Controls.Add(botonSimular);
            panel1.Controls.Add(botonProduccion);
            panel1.Controls.Add(labelEspesor);
            panel1.Controls.Add(sliderEspesor);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(293, 591);
            panel1.TabIndex = 2;
            // 
            // graficaTemp
            // 
            graficaTemp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            graficaTemp.BackColor = Color.FromArgb(234, 234, 234);
            chartArea1.AxisX.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = Color.White;
            chartArea1.Name = "ChartArea1";
            graficaTemp.ChartAreas.Add(chartArea1);
            graficaTemp.DataBindings.Add(new Binding("Text", bindingSourceProducto, "CalorEspecifico", true));
            graficaTemp.DataBindings.Add(new Binding("DataSource", bindingSourceProducto, "TempInterior", true));
            graficaTemp.Location = new Point(9, 444);
            graficaTemp.Name = "graficaTemp";
            graficaTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.FromArgb(0, 192, 0);
            series1.IsXValueIndexed = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.MarkerColor = Color.White;
            series1.Name = "serieTemperatura";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            graficaTemp.Series.Add(series1);
            graficaTemp.Size = new Size(275, 281);
            graficaTemp.TabIndex = 11;
            graficaTemp.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Temperatura interior por hora";
            graficaTemp.Titles.Add(title1);
            // 
            // bindingSourceProducto
            // 
            bindingSourceProducto.DataSource = typeof(Dominio.SimulacionProducto);
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.DataBindings.Add(new Binding("Text", bindingSourceProducto, "Densidad", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0 kg/m³"));
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(61, 57, 53);
            label10.Location = new Point(112, 157);
            label10.Name = "label10";
            label10.Size = new Size(23, 25);
            label10.TabIndex = 32;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(61, 57, 53);
            label11.Location = new Point(6, 157);
            label11.Name = "label11";
            label11.Size = new Size(100, 25);
            label11.TabIndex = 31;
            label11.Text = "Densidad:";
            // 
            // radioLadrillo
            // 
            radioLadrillo.AutoSize = true;
            radioLadrillo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioLadrillo.Location = new Point(18, 282);
            radioLadrillo.Name = "radioLadrillo";
            radioLadrillo.Size = new Size(82, 25);
            radioLadrillo.TabIndex = 30;
            radioLadrillo.Text = "Ladrillo";
            radioLadrillo.UseVisualStyleBackColor = true;
            // 
            // radioMadera
            // 
            radioMadera.AutoSize = true;
            radioMadera.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioMadera.Location = new Point(18, 313);
            radioMadera.Name = "radioMadera";
            radioMadera.Size = new Size(133, 25);
            radioMadera.TabIndex = 29;
            radioMadera.Text = "Fibra de vidrio";
            radioMadera.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(61, 57, 53);
            label9.Location = new Point(6, 223);
            label9.Name = "label9";
            label9.Size = new Size(162, 25);
            label9.TabIndex = 28;
            label9.Text = "Material aislante:";
            // 
            // radioCelulosa
            // 
            radioCelulosa.AutoSize = true;
            radioCelulosa.Checked = true;
            radioCelulosa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioCelulosa.Location = new Point(18, 251);
            radioCelulosa.Name = "radioCelulosa";
            radioCelulosa.Size = new Size(200, 25);
            radioCelulosa.TabIndex = 27;
            radioCelulosa.TabStop = true;
            radioCelulosa.Text = "Aislamiento de celulosa";
            radioCelulosa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.DataBindings.Add(new Binding("Text", bindingSourceProducto, "Horas", true, DataSourceUpdateMode.OnValidation, "0", "0 "));
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 57, 53);
            label4.Location = new Point(98, 189);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 26;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(61, 57, 53);
            label5.Location = new Point(6, 189);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 25;
            label5.Text = "Horas:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.DataBindings.Add(new Binding("Text", bindingSourceProducto, "RValueInches", true, DataSourceUpdateMode.OnValidation, "0", "0 "));
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(61, 57, 53);
            label8.Location = new Point(98, 122);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 24;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(61, 57, 53);
            label7.Location = new Point(6, 122);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 23;
            label7.Text = "R-Value:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 57, 53);
            label6.Location = new Point(6, 86);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 22;
            label6.Text = "Conductividad:";
            // 
            // labelConductividad
            // 
            labelConductividad.Anchor = AnchorStyles.Top;
            labelConductividad.AutoSize = true;
            labelConductividad.DataBindings.Add(new Binding("Text", bindingSourceProducto, "Conductividad", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.000 W/mK"));
            labelConductividad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConductividad.ForeColor = Color.FromArgb(61, 57, 53);
            labelConductividad.Location = new Point(161, 86);
            labelConductividad.Name = "labelConductividad";
            labelConductividad.Size = new Size(60, 25);
            labelConductividad.TabIndex = 21;
            labelConductividad.Text = "50cm";
            // 
            // botonSimular
            // 
            botonSimular.Anchor = AnchorStyles.Top;
            botonSimular.BackColor = Color.FromArgb(113, 38, 132);
            botonSimular.Cursor = Cursors.Hand;
            botonSimular.FlatStyle = FlatStyle.Flat;
            botonSimular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonSimular.ForeColor = Color.FromArgb(255, 255, 248);
            botonSimular.Location = new Point(33, 358);
            botonSimular.Name = "botonSimular";
            botonSimular.Size = new Size(220, 80);
            botonSimular.TabIndex = 17;
            botonSimular.Text = "Simular";
            botonSimular.UseVisualStyleBackColor = false;
            botonSimular.Paint += botonSimular_Paint;
            // 
            // botonProduccion
            // 
            botonProduccion.BackColor = Color.FromArgb(119, 188, 32);
            botonProduccion.Cursor = Cursors.Hand;
            botonProduccion.Dock = DockStyle.Bottom;
            botonProduccion.FlatStyle = FlatStyle.Flat;
            botonProduccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonProduccion.ForeColor = Color.FromArgb(255, 255, 248);
            botonProduccion.Location = new Point(3, 548);
            botonProduccion.Name = "botonProduccion";
            botonProduccion.Size = new Size(287, 40);
            botonProduccion.TabIndex = 16;
            botonProduccion.Text = "Simular producción";
            botonProduccion.UseVisualStyleBackColor = false;
            // 
            // labelEspesor
            // 
            labelEspesor.Anchor = AnchorStyles.Top;
            labelEspesor.AutoSize = true;
            labelEspesor.DataBindings.Add(new Binding("Text", bindingSourceProducto, "EspesorCm", true));
            labelEspesor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEspesor.ForeColor = Color.FromArgb(61, 57, 53);
            labelEspesor.Location = new Point(224, 35);
            labelEspesor.Name = "labelEspesor";
            labelEspesor.Size = new Size(60, 25);
            labelEspesor.TabIndex = 15;
            labelEspesor.Text = "50cm";
            // 
            // sliderEspesor
            // 
            sliderEspesor.Anchor = AnchorStyles.Top;
            sliderEspesor.DataBindings.Add(new Binding("Value", bindingSourceProducto, "EspesorCm", true, DataSourceUpdateMode.OnPropertyChanged));
            sliderEspesor.Location = new Point(3, 38);
            sliderEspesor.Maximum = 50;
            sliderEspesor.Minimum = 10;
            sliderEspesor.Name = "sliderEspesor";
            sliderEspesor.Size = new Size(215, 45);
            sliderEspesor.TabIndex = 8;
            sliderEspesor.Value = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 57, 53);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 5;
            label3.Text = "Espesor aplicado en cm";
            // 
            // labelExterior
            // 
            labelExterior.AutoSize = true;
            labelExterior.DataBindings.Add(new Binding("Text", bindingSourceProducto, "TempInterior", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            labelExterior.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExterior.ForeColor = Color.FromArgb(61, 57, 53);
            labelExterior.Location = new Point(204, 11);
            labelExterior.Name = "labelExterior";
            labelExterior.Size = new Size(53, 25);
            labelExterior.TabIndex = 13;
            labelExterior.Text = "60°C";
            // 
            // labelInterior
            // 
            labelInterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelInterior.AutoSize = true;
            labelInterior.DataBindings.Add(new Binding("Text", bindingSourceProducto, "TempExterior", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            labelInterior.DataBindings.Add(new Binding("DataContext", bindingSourceProducto, "TempExterior", true));
            labelInterior.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInterior.ForeColor = Color.FromArgb(61, 57, 53);
            labelInterior.Location = new Point(210, 10);
            labelInterior.Name = "labelInterior";
            labelInterior.Size = new Size(53, 25);
            labelInterior.TabIndex = 10;
            labelInterior.Text = "60°C";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 57, 53);
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 4;
            label2.Text = "Temperatura Exterior:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 57, 53);
            label1.Location = new Point(0, 11);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 3;
            label1.Text = "Temperatura Interior: ";
            // 
            // splitExterior
            // 
            splitExterior.Dock = DockStyle.Fill;
            splitExterior.Enabled = false;
            splitExterior.Location = new Point(294, 1);
            splitExterior.Name = "splitExterior";
            // 
            // splitExterior.Panel1
            // 
            splitExterior.Panel1.AccessibleName = "panelCasa";
            splitExterior.Panel1.BackColor = Color.FromArgb(192, 64, 0);
            splitExterior.Panel1.Controls.Add(splitCasa);
            // 
            // splitExterior.Panel2
            // 
            splitExterior.Panel2.AccessibleName = "panelExterior";
            splitExterior.Panel2.BackColor = Color.White;
            splitExterior.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitExterior.Panel2.Controls.Add(panelExterior);
            splitExterior.Size = new Size(646, 591);
            splitExterior.SplitterDistance = 352;
            splitExterior.SplitterWidth = 2;
            splitExterior.TabIndex = 3;
            // 
            // splitCasa
            // 
            splitCasa.BackColor = Color.FromArgb(61, 57, 53);
            splitCasa.Dock = DockStyle.Fill;
            splitCasa.Enabled = false;
            splitCasa.Location = new Point(0, 0);
            splitCasa.Name = "splitCasa";
            // 
            // splitCasa.Panel1
            // 
            splitCasa.Panel1.AccessibleName = "panelInterior";
            splitCasa.Panel1.BackColor = Color.White;
            splitCasa.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitCasa.Panel1.Controls.Add(panelInterior);
            // 
            // splitCasa.Panel2
            // 
            splitCasa.Panel2.AccessibleName = "panelPared";
            splitCasa.Panel2.BackColor = Color.FromArgb(255, 128, 0);
            splitCasa.Size = new Size(352, 591);
            splitCasa.SplitterDistance = 316;
            splitCasa.SplitterWidth = 2;
            splitCasa.TabIndex = 0;
            // 
            // panelInterior
            // 
            panelInterior.BackColor = Color.Transparent;
            panelInterior.Controls.Add(label1);
            panelInterior.Controls.Add(labelExterior);
            panelInterior.Dock = DockStyle.Fill;
            panelInterior.Location = new Point(0, 0);
            panelInterior.Name = "panelInterior";
            panelInterior.Size = new Size(316, 591);
            panelInterior.TabIndex = 0;
            // 
            // panelExterior
            // 
            panelExterior.BackColor = Color.Transparent;
            panelExterior.Controls.Add(label2);
            panelExterior.Controls.Add(labelInterior);
            panelExterior.Dock = DockStyle.Fill;
            panelExterior.Location = new Point(0, 0);
            panelExterior.Name = "panelExterior";
            panelExterior.Size = new Size(292, 591);
            panelExterior.TabIndex = 0;
            // 
            // timerSimulacion
            // 
            timerSimulacion.Interval = 250;
            // 
            // VistaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 57, 53);
            ClientSize = new Size(941, 593);
            Controls.Add(splitExterior);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaProducto";
            Padding = new Padding(1);
            Text = "VistaProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)graficaTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderEspesor).EndInit();
            splitExterior.Panel1.ResumeLayout(false);
            splitExterior.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitExterior).EndInit();
            splitExterior.ResumeLayout(false);
            splitCasa.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCasa).EndInit();
            splitCasa.ResumeLayout(false);
            panelInterior.ResumeLayout(false);
            panelInterior.PerformLayout();
            panelExterior.ResumeLayout(false);
            panelExterior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TrackBar sliderEspesor;
        private Label labelExterior;
        private Label labelInterior;
        private Label labelEspesor;
        private Button botonProduccion;
        private Button botonSimular;
        private BindingSource bindingSourceProducto;
        private SplitContainer splitExterior;
        private SplitContainer splitCasa;
        private Panel panelInterior;
        private Panel panelExterior;
        private System.Windows.Forms.Timer timerSimulacion;
        private Label label6;
        private Label labelConductividad;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label9;
        private RadioButton radioCelulosa;
        private RadioButton radioLadrillo;
        private RadioButton radioMadera;
        private Label label10;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaTemp;
    }
}