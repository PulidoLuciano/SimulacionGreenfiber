using Dominio;
using Presentacion.Componentes;
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
        List<ControlLineaProduccion> _controlesLineas;
        List<ControlLineaProduccion> IVistaPrincipal.ControlesLineas { get { return _controlesLineas; } }
        
        public VistaPrincipal()
        {
            InitializeComponent();
            _controlesLineas = new List<ControlLineaProduccion>();
        }

        public event EventHandler AbrirVistaProducto
        {
            add { botonProducto.Click += value; }
            remove { botonProducto.Click -= value;}
        }
        public event EventHandler AgregarLineaProduccion
        {
            add { botonAgregarLinea.Click += value;}
            remove { botonAgregarLinea.Click -= value; }
        }
        public event EventHandler QuitarLineaProduccion
        {
            add { botonEliminarLinea.Click += value; }
            remove { botonEliminarLinea.Click -= value; }
        }
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

        public void ListarLineas(List<Linea> lineas)
        {
            panelLineas.Controls.Clear();
            _controlesLineas.Clear();

            lineas.ToList().ForEach(l =>
            {
                ControlLineaProduccion control = new ControlLineaProduccion();
                _controlesLineas.Add(control);
                panelLineas.Controls.Add(control);
                control.Width = panelLineas.Width - 20;
            });

            labelNroLineas.Text = lineas.Count.ToString();
        }
    }

    public class VistaPrincipalConPresentador : VistaBase<PresentadorPrincipal> { }
}
