﻿namespace Presentacion.Componentes
{
    partial class ControlLineaProduccion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlLineaProduccion));
            panelDatos = new Panel();
            label16 = new Label();
            textBoxPotenciaEmpaquetadora = new TextBox();
            EmpaquetadoraBS = new BindingSource(components);
            label17 = new Label();
            label14 = new Label();
            textBoxPotenciaRefinadora = new TextBox();
            RefinadoraBS = new BindingSource(components);
            label15 = new Label();
            label12 = new Label();
            textBoxPotenciaLimpiadora = new TextBox();
            LimpiadoraBS = new BindingSource(components);
            label13 = new Label();
            label11 = new Label();
            textBoxPotenciaTrituradora = new TextBox();
            TrituradoraBS = new BindingSource(components);
            label10 = new Label();
            label8 = new Label();
            textBoxCapacidadEmpaquetadora = new TextBox();
            label9 = new Label();
            label6 = new Label();
            textBoxCapacidadRefinadora = new TextBox();
            label7 = new Label();
            label5 = new Label();
            textBoxCapacidadTrituradora = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label18 = new Label();
            pictureBox3 = new PictureBox();
            labelNroLinea = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpaquetadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RefinadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrituradoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelDatos
            // 
            panelDatos.Anchor = AnchorStyles.Bottom;
            panelDatos.Controls.Add(label16);
            panelDatos.Controls.Add(textBoxPotenciaEmpaquetadora);
            panelDatos.Controls.Add(label17);
            panelDatos.Controls.Add(label14);
            panelDatos.Controls.Add(textBoxPotenciaRefinadora);
            panelDatos.Controls.Add(label15);
            panelDatos.Controls.Add(label12);
            panelDatos.Controls.Add(textBoxPotenciaLimpiadora);
            panelDatos.Controls.Add(label13);
            panelDatos.Controls.Add(label11);
            panelDatos.Controls.Add(textBoxPotenciaTrituradora);
            panelDatos.Controls.Add(label10);
            panelDatos.Controls.Add(label8);
            panelDatos.Controls.Add(textBoxCapacidadEmpaquetadora);
            panelDatos.Controls.Add(label9);
            panelDatos.Controls.Add(label6);
            panelDatos.Controls.Add(textBoxCapacidadRefinadora);
            panelDatos.Controls.Add(label7);
            panelDatos.Controls.Add(label5);
            panelDatos.Controls.Add(textBoxCapacidadTrituradora);
            panelDatos.Controls.Add(label4);
            panelDatos.Location = new Point(181, 165);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(839, 167);
            panelDatos.TabIndex = 5;
            panelDatos.Click += panelDatos_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(234, 234, 234);
            label16.Location = new Point(782, 109);
            label16.Name = "label16";
            label16.Size = new Size(46, 20);
            label16.TabIndex = 20;
            label16.Text = "Watts";
            // 
            // textBoxPotenciaEmpaquetadora
            // 
            textBoxPotenciaEmpaquetadora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxPotenciaEmpaquetadora.DataBindings.Add(new Binding("Text", EmpaquetadoraBS, "Potencia", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxPotenciaEmpaquetadora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPotenciaEmpaquetadora.Location = new Point(690, 102);
            textBoxPotenciaEmpaquetadora.Name = "textBoxPotenciaEmpaquetadora";
            textBoxPotenciaEmpaquetadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaEmpaquetadora.Size = new Size(86, 27);
            textBoxPotenciaEmpaquetadora.TabIndex = 19;
            textBoxPotenciaEmpaquetadora.KeyPress += soloPermitirNumeros;
            // 
            // EmpaquetadoraBS
            // 
            EmpaquetadoraBS.DataSource = typeof(Dominio.Empaquetadora);
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(234, 234, 234);
            label17.Location = new Point(668, 79);
            label17.Name = "label17";
            label17.Size = new Size(69, 20);
            label17.TabIndex = 18;
            label17.Text = "Potencia";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(234, 234, 234);
            label14.Location = new Point(564, 105);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 17;
            label14.Text = "Watts";
            // 
            // textBoxPotenciaRefinadora
            // 
            textBoxPotenciaRefinadora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxPotenciaRefinadora.DataBindings.Add(new Binding("Text", RefinadoraBS, "Potencia", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxPotenciaRefinadora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPotenciaRefinadora.Location = new Point(472, 98);
            textBoxPotenciaRefinadora.Name = "textBoxPotenciaRefinadora";
            textBoxPotenciaRefinadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaRefinadora.Size = new Size(86, 27);
            textBoxPotenciaRefinadora.TabIndex = 16;
            textBoxPotenciaRefinadora.KeyPress += soloPermitirNumeros;
            // 
            // RefinadoraBS
            // 
            RefinadoraBS.DataSource = typeof(Dominio.Refinadora);
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(234, 234, 234);
            label15.Location = new Point(454, 75);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 15;
            label15.Text = "Potencia";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(234, 234, 234);
            label12.Location = new Point(358, 105);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 14;
            label12.Text = "Watts";
            // 
            // textBoxPotenciaLimpiadora
            // 
            textBoxPotenciaLimpiadora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxPotenciaLimpiadora.DataBindings.Add(new Binding("Text", LimpiadoraBS, "Potencia", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxPotenciaLimpiadora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPotenciaLimpiadora.Location = new Point(266, 98);
            textBoxPotenciaLimpiadora.Name = "textBoxPotenciaLimpiadora";
            textBoxPotenciaLimpiadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaLimpiadora.Size = new Size(86, 27);
            textBoxPotenciaLimpiadora.TabIndex = 13;
            textBoxPotenciaLimpiadora.KeyPress += soloPermitirNumeros;
            // 
            // LimpiadoraBS
            // 
            LimpiadoraBS.DataSource = typeof(Dominio.Limpiadora);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(234, 234, 234);
            label13.Location = new Point(248, 75);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 12;
            label13.Text = "Potencia";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(234, 234, 234);
            label11.Location = new Point(133, 105);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 11;
            label11.Text = "Watts";
            // 
            // textBoxPotenciaTrituradora
            // 
            textBoxPotenciaTrituradora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxPotenciaTrituradora.DataBindings.Add(new Binding("Text", TrituradoraBS, "Potencia", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxPotenciaTrituradora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxPotenciaTrituradora.Location = new Point(41, 98);
            textBoxPotenciaTrituradora.Name = "textBoxPotenciaTrituradora";
            textBoxPotenciaTrituradora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaTrituradora.Size = new Size(86, 27);
            textBoxPotenciaTrituradora.TabIndex = 10;
            textBoxPotenciaTrituradora.KeyPress += soloPermitirNumeros;
            // 
            // TrituradoraBS
            // 
            TrituradoraBS.DataSource = typeof(Dominio.Trituradora);
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(234, 234, 234);
            label10.Location = new Point(23, 75);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 9;
            label10.Text = "Potencia";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(234, 234, 234);
            label8.Location = new Point(782, 42);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 8;
            label8.Text = "Kg";
            // 
            // textBoxCapacidadEmpaquetadora
            // 
            textBoxCapacidadEmpaquetadora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxCapacidadEmpaquetadora.DataBindings.Add(new Binding("Text", EmpaquetadoraBS, "CapacidadPromedio", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxCapacidadEmpaquetadora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxCapacidadEmpaquetadora.Location = new Point(690, 35);
            textBoxCapacidadEmpaquetadora.Name = "textBoxCapacidadEmpaquetadora";
            textBoxCapacidadEmpaquetadora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadEmpaquetadora.Size = new Size(86, 27);
            textBoxCapacidadEmpaquetadora.TabIndex = 7;
            textBoxCapacidadEmpaquetadora.KeyPress += soloPermitirNumeros;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(234, 234, 234);
            label9.Location = new Point(672, 14);
            label9.Name = "label9";
            label9.Size = new Size(144, 20);
            label9.TabIndex = 6;
            label9.Text = "Capacidad por hora";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(234, 234, 234);
            label6.Location = new Point(564, 42);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 5;
            label6.Text = "Kg";
            // 
            // textBoxCapacidadRefinadora
            // 
            textBoxCapacidadRefinadora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxCapacidadRefinadora.DataBindings.Add(new Binding("Text", RefinadoraBS, "CapacidadPromedio", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxCapacidadRefinadora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxCapacidadRefinadora.Location = new Point(472, 35);
            textBoxCapacidadRefinadora.Name = "textBoxCapacidadRefinadora";
            textBoxCapacidadRefinadora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadRefinadora.Size = new Size(86, 27);
            textBoxCapacidadRefinadora.TabIndex = 4;
            textBoxCapacidadRefinadora.KeyPress += soloPermitirNumeros;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(234, 234, 234);
            label7.Location = new Point(454, 14);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 3;
            label7.Text = "Capacidad por hora";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(234, 234, 234);
            label5.Location = new Point(133, 42);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 2;
            label5.Text = "Kg";
            // 
            // textBoxCapacidadTrituradora
            // 
            textBoxCapacidadTrituradora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxCapacidadTrituradora.DataBindings.Add(new Binding("Text", TrituradoraBS, "CapacidadPromedio", true, DataSourceUpdateMode.OnValidation, null, "N2"));
            textBoxCapacidadTrituradora.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxCapacidadTrituradora.Location = new Point(41, 35);
            textBoxCapacidadTrituradora.Name = "textBoxCapacidadTrituradora";
            textBoxCapacidadTrituradora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadTrituradora.Size = new Size(86, 27);
            textBoxCapacidadTrituradora.TabIndex = 1;
            textBoxCapacidadTrituradora.KeyPress += soloPermitirNumeros;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(234, 234, 234);
            label4.Location = new Point(23, 14);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 0;
            label4.Text = "Capacidad por hora";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.Location = new Point(848, 50);
            panel10.Name = "panel10";
            panel10.Size = new Size(152, 109);
            panel10.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(633, 50);
            panel9.Name = "panel9";
            panel9.Size = new Size(152, 109);
            panel9.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(418, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(152, 109);
            panel7.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(203, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(152, 109);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 8);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 6;
            label1.Text = "Trituración";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(418, 8);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 8;
            label2.Text = "Limpieza";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(627, 8);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 9;
            label3.Text = "Refinación";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.BackColor = Color.DimGray;
            label18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(848, 8);
            label18.Name = "label18";
            label18.Size = new Size(172, 32);
            label18.TabIndex = 10;
            label18.Text = "Empaquetado";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(791, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 40);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // labelNroLinea
            // 
            labelNroLinea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNroLinea.AutoSize = true;
            labelNroLinea.BackColor = Color.DimGray;
            labelNroLinea.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNroLinea.ForeColor = Color.White;
            labelNroLinea.Location = new Point(1156, 8);
            labelNroLinea.Name = "labelNroLinea";
            labelNroLinea.Size = new Size(42, 32);
            labelNroLinea.TabIndex = 14;
            labelNroLinea.Text = "10";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(576, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 40);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(361, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 40);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // ControlLineaProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.DimGray;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelNroLinea);
            Controls.Add(pictureBox3);
            Controls.Add(label18);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel10);
            Controls.Add(label1);
            Controls.Add(panelDatos);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "ControlLineaProduccion";
            Padding = new Padding(8);
            Size = new Size(1209, 343);
            Click += ControlLineaProduccion_Click;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpaquetadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)RefinadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrituradoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelDatos;
        private Label label8;
        private TextBox textBoxCapacidadEmpaquetadora;
        private Label label9;
        private Label label6;
        private TextBox textBoxCapacidadRefinadora;
        private Label label7;
        private Label label5;
        private TextBox textBoxCapacidadTrituradora;
        private Label label4;
        private Label label16;
        private TextBox textBoxPotenciaEmpaquetadora;
        private Label label17;
        private Label label14;
        private TextBox textBoxPotenciaRefinadora;
        private Label label15;
        private Label label12;
        private TextBox textBoxPotenciaLimpiadora;
        private Label label13;
        private Label label11;
        private TextBox textBoxPotenciaTrituradora;
        private Label label10;
        private BindingSource TrituradoraBS;
        private BindingSource LimpiadoraBS;
        private BindingSource RefinadoraBS;
        private BindingSource EmpaquetadoraBS;
        private Panel panel10;
        private Panel panel9;
        private Panel panel7;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label18;
        private PictureBox pictureBox3;
        private Label labelNroLinea;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
