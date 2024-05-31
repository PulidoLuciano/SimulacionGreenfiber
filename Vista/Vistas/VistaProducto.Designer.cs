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
            panel1 = new Panel();
            botonSimular = new Button();
            botonProduccion = new Button();
            labelEspesor = new Label();
            bindingSourceProducto = new BindingSource(components);
            labelExterior = new Label();
            sliderExterior = new TrackBar();
            labelInterior = new Label();
            sliderEspesor = new TrackBar();
            sliderInterior = new TrackBar();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            splitExterior = new SplitContainer();
            splitCasa = new SplitContainer();
            panelInterior = new Panel();
            panelExterior = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderExterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderEspesor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderInterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitExterior).BeginInit();
            splitExterior.Panel1.SuspendLayout();
            splitExterior.Panel2.SuspendLayout();
            splitExterior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitCasa).BeginInit();
            splitCasa.Panel1.SuspendLayout();
            splitCasa.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 234, 234);
            panel1.Controls.Add(botonSimular);
            panel1.Controls.Add(botonProduccion);
            panel1.Controls.Add(labelEspesor);
            panel1.Controls.Add(labelExterior);
            panel1.Controls.Add(sliderExterior);
            panel1.Controls.Add(labelInterior);
            panel1.Controls.Add(sliderEspesor);
            panel1.Controls.Add(sliderInterior);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(293, 591);
            panel1.TabIndex = 2;
            // 
            // botonSimular
            // 
            botonSimular.Anchor = AnchorStyles.Top;
            botonSimular.BackColor = Color.FromArgb(113, 38, 132);
            botonSimular.Cursor = Cursors.Hand;
            botonSimular.FlatStyle = FlatStyle.Flat;
            botonSimular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonSimular.ForeColor = Color.FromArgb(255, 255, 248);
            botonSimular.Location = new Point(35, 226);
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
            labelEspesor.Location = new Point(227, 172);
            labelEspesor.Name = "labelEspesor";
            labelEspesor.Size = new Size(60, 25);
            labelEspesor.TabIndex = 15;
            labelEspesor.Text = "50cm";
            // 
            // bindingSourceProducto
            // 
            bindingSourceProducto.DataSource = typeof(Dominio.SimulacionProducto);
            // 
            // labelExterior
            // 
            labelExterior.Anchor = AnchorStyles.Top;
            labelExterior.AutoSize = true;
            labelExterior.DataBindings.Add(new Binding("Text", bindingSourceProducto, "TempExterior", true));
            labelExterior.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExterior.ForeColor = Color.FromArgb(61, 57, 53);
            labelExterior.Location = new Point(234, 28);
            labelExterior.Name = "labelExterior";
            labelExterior.Size = new Size(53, 25);
            labelExterior.TabIndex = 13;
            labelExterior.Text = "60°C";
            // 
            // sliderExterior
            // 
            sliderExterior.Anchor = AnchorStyles.Top;
            sliderExterior.DataBindings.Add(new Binding("Value", bindingSourceProducto, "TempExterior", true, DataSourceUpdateMode.OnPropertyChanged));
            sliderExterior.Location = new Point(6, 31);
            sliderExterior.Maximum = 60;
            sliderExterior.Minimum = -10;
            sliderExterior.Name = "sliderExterior";
            sliderExterior.Size = new Size(232, 45);
            sliderExterior.TabIndex = 11;
            // 
            // labelInterior
            // 
            labelInterior.Anchor = AnchorStyles.Top;
            labelInterior.AutoSize = true;
            labelInterior.DataBindings.Add(new Binding("DataContext", bindingSourceProducto, "TempInterior", true));
            labelInterior.DataBindings.Add(new Binding("Text", bindingSourceProducto, "TempInterior", true));
            labelInterior.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInterior.ForeColor = Color.FromArgb(61, 57, 53);
            labelInterior.Location = new Point(234, 100);
            labelInterior.Name = "labelInterior";
            labelInterior.Size = new Size(53, 25);
            labelInterior.TabIndex = 10;
            labelInterior.Text = "60°C";
            // 
            // sliderEspesor
            // 
            sliderEspesor.Anchor = AnchorStyles.Top;
            sliderEspesor.DataBindings.Add(new Binding("Value", bindingSourceProducto, "EspesorCm", true, DataSourceUpdateMode.OnPropertyChanged));
            sliderEspesor.Location = new Point(6, 175);
            sliderEspesor.Maximum = 50;
            sliderEspesor.Minimum = 3;
            sliderEspesor.Name = "sliderEspesor";
            sliderEspesor.Size = new Size(215, 45);
            sliderEspesor.TabIndex = 8;
            sliderEspesor.Value = 3;
            // 
            // sliderInterior
            // 
            sliderInterior.Anchor = AnchorStyles.Top;
            sliderInterior.DataBindings.Add(new Binding("Value", bindingSourceProducto, "TempInterior", true, DataSourceUpdateMode.OnPropertyChanged));
            sliderInterior.Location = new Point(6, 103);
            sliderInterior.Maximum = 60;
            sliderInterior.Minimum = -10;
            sliderInterior.Name = "sliderInterior";
            sliderInterior.Size = new Size(232, 45);
            sliderInterior.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 57, 53);
            label3.Location = new Point(6, 147);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 5;
            label3.Text = "Espesor aplicado en cm";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 57, 53);
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 4;
            label2.Text = "Temp. Interior en °C";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 57, 53);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 3;
            label1.Text = "Temp. Exterior en °C";
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
            panelInterior.Dock = DockStyle.Fill;
            panelInterior.Location = new Point(0, 0);
            panelInterior.Name = "panelInterior";
            panelInterior.Size = new Size(316, 591);
            panelInterior.TabIndex = 0;
            panelInterior.BackColorChanged += panelInterior_BackColorChanged;
            // 
            // panelExterior
            // 
            panelExterior.BackColor = Color.Transparent;
            panelExterior.Dock = DockStyle.Fill;
            panelExterior.Location = new Point(0, 0);
            panelExterior.Name = "panelExterior";
            panelExterior.Size = new Size(292, 591);
            panelExterior.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)bindingSourceProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderExterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderEspesor).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderInterior).EndInit();
            splitExterior.Panel1.ResumeLayout(false);
            splitExterior.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitExterior).EndInit();
            splitExterior.ResumeLayout(false);
            splitCasa.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCasa).EndInit();
            splitCasa.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TrackBar sliderEspesor;
        private TrackBar sliderInterior;
        private Label labelExterior;
        private TrackBar sliderExterior;
        private Label labelInterior;
        private Label labelEspesor;
        private Button botonProduccion;
        private Button botonSimular;
        private BindingSource bindingSourceProducto;
        private SplitContainer splitExterior;
        private SplitContainer splitCasa;
        private Panel panelInterior;
        private Panel panelExterior;
    }
}