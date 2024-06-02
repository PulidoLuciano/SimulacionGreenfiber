namespace Presentacion.Componentes
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
            panel1 = new Panel();
            labelTrituracion = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panelLinea = new Panel();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelLinea.SuspendLayout();
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpaquetadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RefinadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiadoraBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrituradoraBS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelTrituracion);
            panel1.Location = new Point(181, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 142);
            panel1.TabIndex = 0;
            // 
            // labelTrituracion
            // 
            labelTrituracion.Anchor = AnchorStyles.Bottom;
            labelTrituracion.AutoSize = true;
            labelTrituracion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTrituracion.Location = new Point(35, 119);
            labelTrituracion.Name = "labelTrituracion";
            labelTrituracion.Size = new Size(84, 21);
            labelTrituracion.TabIndex = 0;
            labelTrituracion.Text = "Trituracion";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(386, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 142);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 119);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 1;
            label1.Text = "Limpieza";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(573, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 142);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 121);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "Refinación";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(771, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 142);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 2;
            label3.Text = "Empaquetado";
            // 
            // panelLinea
            // 
            panelLinea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelLinea.Controls.Add(panel1);
            panelLinea.Controls.Add(panel4);
            panelLinea.Controls.Add(panel2);
            panelLinea.Controls.Add(panel3);
            panelLinea.Location = new Point(11, 11);
            panelLinea.Name = "panelLinea";
            panelLinea.Size = new Size(1099, 148);
            panelLinea.TabIndex = 4;
            panelLinea.Click += panelLinea_Click;
            // 
            // panelDatos
            // 
            panelDatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panelDatos.Location = new Point(11, 165);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1099, 167);
            panelDatos.TabIndex = 5;
            panelDatos.Click += panelDatos_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(234, 234, 234);
            label16.Location = new Point(881, 105);
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
            textBoxPotenciaEmpaquetadora.Location = new Point(789, 98);
            textBoxPotenciaEmpaquetadora.Name = "textBoxPotenciaEmpaquetadora";
            textBoxPotenciaEmpaquetadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaEmpaquetadora.Size = new Size(86, 27);
            textBoxPotenciaEmpaquetadora.TabIndex = 19;
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
            label17.Location = new Point(771, 75);
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
            label14.Location = new Point(683, 101);
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
            textBoxPotenciaRefinadora.Location = new Point(591, 94);
            textBoxPotenciaRefinadora.Name = "textBoxPotenciaRefinadora";
            textBoxPotenciaRefinadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaRefinadora.Size = new Size(86, 27);
            textBoxPotenciaRefinadora.TabIndex = 16;
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
            label15.Location = new Point(573, 71);
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
            label12.Location = new Point(496, 101);
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
            textBoxPotenciaLimpiadora.Location = new Point(404, 94);
            textBoxPotenciaLimpiadora.Name = "textBoxPotenciaLimpiadora";
            textBoxPotenciaLimpiadora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaLimpiadora.Size = new Size(86, 27);
            textBoxPotenciaLimpiadora.TabIndex = 13;
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
            label13.Location = new Point(386, 71);
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
            label11.Location = new Point(291, 101);
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
            textBoxPotenciaTrituradora.Location = new Point(199, 94);
            textBoxPotenciaTrituradora.Name = "textBoxPotenciaTrituradora";
            textBoxPotenciaTrituradora.RightToLeft = RightToLeft.Yes;
            textBoxPotenciaTrituradora.Size = new Size(86, 27);
            textBoxPotenciaTrituradora.TabIndex = 10;
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
            label10.Location = new Point(181, 71);
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
            label8.Location = new Point(881, 38);
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
            textBoxCapacidadEmpaquetadora.Location = new Point(789, 31);
            textBoxCapacidadEmpaquetadora.Name = "textBoxCapacidadEmpaquetadora";
            textBoxCapacidadEmpaquetadora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadEmpaquetadora.Size = new Size(86, 27);
            textBoxCapacidadEmpaquetadora.TabIndex = 7;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(234, 234, 234);
            label9.Location = new Point(771, 10);
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
            label6.Location = new Point(683, 38);
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
            textBoxCapacidadRefinadora.Location = new Point(591, 31);
            textBoxCapacidadRefinadora.Name = "textBoxCapacidadRefinadora";
            textBoxCapacidadRefinadora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadRefinadora.Size = new Size(86, 27);
            textBoxCapacidadRefinadora.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(234, 234, 234);
            label7.Location = new Point(573, 10);
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
            label5.Location = new Point(291, 38);
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
            textBoxCapacidadTrituradora.Location = new Point(199, 31);
            textBoxCapacidadTrituradora.Name = "textBoxCapacidadTrituradora";
            textBoxCapacidadTrituradora.RightToLeft = RightToLeft.Yes;
            textBoxCapacidadTrituradora.Size = new Size(86, 27);
            textBoxCapacidadTrituradora.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(234, 234, 234);
            label4.Location = new Point(181, 10);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 0;
            label4.Text = "Capacidad por hora";
            // 
            // ControlLineaProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(75, 54, 33);
            Controls.Add(panelDatos);
            Controls.Add(panelLinea);
            DoubleBuffered = true;
            Name = "ControlLineaProduccion";
            Padding = new Padding(8);
            Size = new Size(1121, 343);
            Click += ControlLineaProduccion_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelLinea.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpaquetadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)RefinadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiadoraBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrituradoraBS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label labelTrituracion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelLinea;
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
    }
}
