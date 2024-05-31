namespace Vistas
{
     partial class VistaContenedora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaContenedora));
            topPanel = new Panel();
            logo = new PictureBox();
            titleLabel = new Label();
            botonMinimizar = new Button();
            botonMaximizar = new Button();
            botonCerrar = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(119, 188, 32);
            topPanel.Controls.Add(logo);
            topPanel.Controls.Add(titleLabel);
            topPanel.Controls.Add(botonMinimizar);
            topPanel.Controls.Add(botonMaximizar);
            topPanel.Controls.Add(botonCerrar);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1035, 35);
            topPanel.TabIndex = 0;
            topPanel.MouseDoubleClick += topPanel_MouseDoubleClick;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(5, 1);
            logo.Name = "logo";
            logo.Size = new Size(32, 32);
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Brush Script MT", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(255, 255, 248);
            titleLabel.Location = new Point(35, -1);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(101, 36);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "greenfiber";
            // 
            // botonMinimizar
            // 
            botonMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonMinimizar.FlatAppearance.BorderSize = 0;
            botonMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 161, 36);
            botonMinimizar.FlatStyle = FlatStyle.Flat;
            botonMinimizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMinimizar.ForeColor = Color.FromArgb(255, 255, 248);
            botonMinimizar.Location = new Point(858, 0);
            botonMinimizar.Margin = new Padding(0);
            botonMinimizar.Name = "botonMinimizar";
            botonMinimizar.Size = new Size(60, 35);
            botonMinimizar.TabIndex = 3;
            botonMinimizar.Text = "-";
            botonMinimizar.UseVisualStyleBackColor = true;
            botonMinimizar.Click += botonMinimizar_Click;
            // 
            // botonMaximizar
            // 
            botonMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonMaximizar.FlatAppearance.BorderSize = 0;
            botonMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 161, 36);
            botonMaximizar.FlatStyle = FlatStyle.Flat;
            botonMaximizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonMaximizar.ForeColor = Color.FromArgb(255, 255, 248);
            botonMaximizar.Location = new Point(918, 0);
            botonMaximizar.Margin = new Padding(0);
            botonMaximizar.Name = "botonMaximizar";
            botonMaximizar.Size = new Size(60, 35);
            botonMaximizar.TabIndex = 2;
            botonMaximizar.Text = "[ ]";
            botonMaximizar.UseVisualStyleBackColor = true;
            botonMaximizar.Click += botonMaximizar_Click;
            // 
            // botonCerrar
            // 
            botonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonCerrar.FlatAppearance.BorderSize = 0;
            botonCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 161, 36);
            botonCerrar.FlatStyle = FlatStyle.Flat;
            botonCerrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCerrar.ForeColor = Color.FromArgb(255, 255, 248);
            botonCerrar.Location = new Point(978, 0);
            botonCerrar.Margin = new Padding(0);
            botonCerrar.Name = "botonCerrar";
            botonCerrar.Size = new Size(60, 35);
            botonCerrar.TabIndex = 1;
            botonCerrar.Text = "X";
            botonCerrar.UseVisualStyleBackColor = true;
            botonCerrar.Click += botonCerrar_Click;
            // 
            // VistaContenedora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 602);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "VistaContenedora";
            Text = "Simulación de producción - Greenfiber";
            Resize += Form1_Resize;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button botonCerrar;
        private Button botonMaximizar;
        private Button botonMinimizar;
        private Label titleLabel;
        private PictureBox logo;
    }
}
