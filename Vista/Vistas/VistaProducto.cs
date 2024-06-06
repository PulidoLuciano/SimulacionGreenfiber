using Dominio;
using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace Presentacion.Vistas
{
    public partial class VistaProducto : VistaProductoConPresentador, IVistaProducto
    {
        public int MaterialSeleccionado 
        {
            get
            {
                return (radioCelulosa.Checked) ? 0 : (radioLadrillo.Checked) ? 1 : 2;
            }
        }
        System.Windows.Forms.Timer IVistaProducto.TimerSimulacion { get => timerSimulacion; }

        public VistaProducto()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public event EventHandler ScrollTempInterior;
        public event EventHandler ScrollTempExterior;
        public event EventHandler CambiarMaterial
        {
            add
            {
                radioCelulosa.CheckedChanged += value;
                radioLadrillo.CheckedChanged += value;
                radioMadera.CheckedChanged += value;
            }
            remove
            {
                radioCelulosa.CheckedChanged -= value;
                radioLadrillo.CheckedChanged -= value;
                radioMadera.CheckedChanged -= value;
            }
        }

        public event EventHandler TickTimer
        {
            add { timerSimulacion.Tick += value; }
            remove => timerSimulacion = null;
        }
        public event EventHandler ScrollEspesor
        {
            add { sliderEspesor.Scroll += value; }
            remove { sliderEspesor.Scroll -= value; }
        }
        public event EventHandler ClickSimular
        {
            add { botonSimular.Click += value; }
            remove { botonSimular.Click -= value; }
        }

        public event EventHandler ClickProduccion
        {
            add { botonProduccion.Click += value; }
            remove { botonProduccion.Click -= value; }
        }

        public void CerrarVentana()
        {
            this.Close();
        }

        void SimularTimer()
        {
        }

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

        public void EstablecerSimulacion(SimulacionProducto simulacion)
        {
            bindingSourceProducto.DataSource = simulacion;
        }

        public void CambiarVisualizacionTemp(double tempInterior, double tempExterior, int hora)
        {
            panelExterior.BackColor = (tempExterior >= 15) ?
                Color.FromArgb((int)Math.Truncate(3.33 * tempExterior - 50), 255, 0, 0) :
                Color.FromArgb((int)Math.Truncate(-6 * tempExterior + 90), 0, 0, 255);
            panelInterior.BackColor = (tempInterior >= 15) ?
                Color.FromArgb((int)Math.Truncate(3.33 * tempInterior - 50), 255, 0, 0) :
                Color.FromArgb((int)Math.Truncate(-6 * tempInterior + 90), 0, 0, 255);
            bindingSourceProducto.ResetBindings(false);
            graficaTemp.Series["serieTemperatura"].Points.AddXY(hora, tempInterior);
        }

        public void CambiarVisualizacionEspesor(double espesor)
        {
            splitCasa.SplitterDistance = splitCasa.Width - (int)Math.Truncate(espesor + 22);
        }

        public void BloquearControles(bool bloquear)
        {
            botonSimular.Text = (bloquear) ? "Detener" : "Simular";
            sliderEspesor.Enabled = !bloquear;
            radioCelulosa.Enabled = !bloquear;
            radioLadrillo.Enabled = !bloquear;
            radioMadera.Enabled = !bloquear;
            botonProduccion.Enabled = !bloquear;
            if(bloquear) graficaTemp.Series["serieTemperatura"].Points.Clear();
        }
    }

    public class VistaProductoConPresentador : VistaBase<PresentadorProducto> { }
}
