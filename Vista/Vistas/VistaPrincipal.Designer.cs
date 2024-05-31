namespace Vistas
{
    partial class VistaPrincipal
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
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            botonProducto = new Button();
            labelNroLineas = new Label();
            botonSimular = new Button();
            label1 = new Label();
            botonEliminarLinea = new Button();
            botonAgregarLinea = new Button();
            splitContainer1 = new SplitContainer();
            panelLineas = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            labelGenerales = new Label();
            labelLineas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 234, 234);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(567, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(232, 448);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(botonProducto);
            panel3.Controls.Add(labelNroLineas);
            panel3.Controls.Add(botonSimular);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(botonEliminarLinea);
            panel3.Controls.Add(botonAgregarLinea);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 436);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(119, 188, 32);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 255, 248);
            button2.Location = new Point(3, 145);
            button2.Name = "button2";
            button2.Size = new Size(220, 40);
            button2.TabIndex = 6;
            button2.Text = "Impacto ambiental";
            button2.UseVisualStyleBackColor = false;
            // 
            // botonProducto
            // 
            botonProducto.BackColor = Color.FromArgb(119, 188, 32);
            botonProducto.Cursor = Cursors.Hand;
            botonProducto.Dock = DockStyle.Bottom;
            botonProducto.FlatStyle = FlatStyle.Flat;
            botonProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonProducto.ForeColor = Color.FromArgb(255, 255, 248);
            botonProducto.Location = new Point(0, 396);
            botonProducto.Name = "botonProducto";
            botonProducto.Size = new Size(220, 40);
            botonProducto.TabIndex = 5;
            botonProducto.Text = "Simular producto";
            botonProducto.UseVisualStyleBackColor = false;
            // 
            // labelNroLineas
            // 
            labelNroLineas.Anchor = AnchorStyles.Top;
            labelNroLineas.AutoSize = true;
            labelNroLineas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNroLineas.ForeColor = Color.FromArgb(61, 57, 53);
            labelNroLineas.Location = new Point(146, 103);
            labelNroLineas.Name = "labelNroLineas";
            labelNroLineas.Size = new Size(23, 25);
            labelNroLineas.TabIndex = 3;
            labelNroLineas.Text = "0";
            // 
            // botonSimular
            // 
            botonSimular.Anchor = AnchorStyles.Top;
            botonSimular.BackColor = Color.FromArgb(113, 38, 132);
            botonSimular.Cursor = Cursors.Hand;
            botonSimular.FlatStyle = FlatStyle.Flat;
            botonSimular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonSimular.ForeColor = Color.FromArgb(255, 255, 248);
            botonSimular.Location = new Point(3, 191);
            botonSimular.Name = "botonSimular";
            botonSimular.Size = new Size(220, 80);
            botonSimular.TabIndex = 4;
            botonSimular.Text = "Simular";
            botonSimular.UseVisualStyleBackColor = false;
            botonSimular.Paint += botonSimular_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 57, 53);
            label1.Location = new Point(0, 103);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 2;
            label1.Text = "Nro de Líneas";
            // 
            // botonEliminarLinea
            // 
            botonEliminarLinea.Anchor = AnchorStyles.Top;
            botonEliminarLinea.BackColor = Color.FromArgb(119, 188, 32);
            botonEliminarLinea.Cursor = Cursors.Hand;
            botonEliminarLinea.FlatStyle = FlatStyle.Flat;
            botonEliminarLinea.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonEliminarLinea.ForeColor = Color.FromArgb(255, 255, 248);
            botonEliminarLinea.Location = new Point(0, 49);
            botonEliminarLinea.Name = "botonEliminarLinea";
            botonEliminarLinea.Size = new Size(220, 40);
            botonEliminarLinea.TabIndex = 1;
            botonEliminarLinea.Text = "Eliminar línea";
            botonEliminarLinea.UseVisualStyleBackColor = false;
            // 
            // botonAgregarLinea
            // 
            botonAgregarLinea.Anchor = AnchorStyles.Top;
            botonAgregarLinea.BackColor = Color.FromArgb(119, 188, 32);
            botonAgregarLinea.Cursor = Cursors.Hand;
            botonAgregarLinea.FlatStyle = FlatStyle.Flat;
            botonAgregarLinea.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAgregarLinea.ForeColor = Color.FromArgb(255, 255, 248);
            botonAgregarLinea.Location = new Point(0, 3);
            botonAgregarLinea.Name = "botonAgregarLinea";
            botonAgregarLinea.Size = new Size(220, 40);
            botonAgregarLinea.TabIndex = 0;
            botonAgregarLinea.Text = "Agregar línea";
            botonAgregarLinea.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(1, 1);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelLineas);
            splitContainer1.Panel1.Padding = new Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(566, 448);
            splitContainer1.SplitterDistance = 308;
            splitContainer1.TabIndex = 2;
            // 
            // panelLineas
            // 
            panelLineas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLineas.BackColor = Color.FromArgb(234, 234, 234);
            panelLineas.BackgroundImageLayout = ImageLayout.Center;
            panelLineas.Location = new Point(6, 6);
            panelLineas.Name = "panelLineas";
            panelLineas.Padding = new Padding(3);
            panelLineas.Size = new Size(552, 294);
            panelLineas.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(labelGenerales);
            splitContainer2.Panel1.Padding = new Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(labelLineas);
            splitContainer2.Panel2.Padding = new Padding(3);
            splitContainer2.Size = new Size(566, 136);
            splitContainer2.SplitterDistance = 282;
            splitContainer2.TabIndex = 0;
            // 
            // labelGenerales
            // 
            labelGenerales.AutoSize = true;
            labelGenerales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenerales.ForeColor = Color.FromArgb(234, 234, 234);
            labelGenerales.Location = new Point(2, 3);
            labelGenerales.Name = "labelGenerales";
            labelGenerales.Size = new Size(203, 25);
            labelGenerales.TabIndex = 0;
            labelGenerales.Text = "Estadísticas Generales";
            // 
            // labelLineas
            // 
            labelLineas.AutoSize = true;
            labelLineas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLineas.ForeColor = Color.FromArgb(234, 234, 234);
            labelLineas.Location = new Point(6, 3);
            labelLineas.Name = "labelLineas";
            labelLineas.Size = new Size(190, 25);
            labelLineas.TabIndex = 1;
            labelLineas.Text = "Estadísticas de Línea";
            // 
            // VistaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 57, 53);
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaPrincipal";
            Padding = new Padding(1);
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label labelGenerales;
        private Label labelLineas;
        private Button botonAgregarLinea;
        private Button botonEliminarLinea;
        private Label labelNroLineas;
        private Label label1;
        private Button botonSimular;
        private Panel panel3;
        private Button button2;
        private Button botonProducto;
        private FlowLayoutPanel panelLineas;
    }
}