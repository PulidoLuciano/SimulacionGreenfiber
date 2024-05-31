using Presentacion.Interfaces;
using Presentacion.Presentadores;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class VistaPrincipal : VistaPrincipalConPresentador, IVistaPrincipal
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        public event EventHandler AbrirVistaProducto
        {
            add { botonProducto.Click += value; }
            remove { botonProducto.Click -= value;}
        }
        public event EventHandler AgregarLineaProduccion;
        public event EventHandler QuitarLineaProduccion;
        public event EventHandler Simular;

        private void botonSimular_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(PointF.Empty, new PointF(botonSimular.Width, botonSimular.Height), Color.FromArgb(19, 108, 182), Color.FromArgb(212, 16, 127)), new RectangleF(PointF.Empty, botonSimular.Size));
            SizeF size = g.MeasureString(btn.Text, btn.Font);
            PointF topLeft = new PointF(btn.Width / 2 - size.Width / 2, btn.Height / 2 - size.Height / 2);
            g.DrawString(btn.Text, btn.Font, Brushes.White, topLeft);
            //Maximizar la vista en el Mdi
            Dock = DockStyle.Fill;
        }
    }

    public class VistaPrincipalConPresentador : VistaBase<PresentadorPrincipal> { }
}
