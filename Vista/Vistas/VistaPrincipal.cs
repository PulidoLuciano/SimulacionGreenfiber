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
            panelGraficos.Visible = false;
        }

        public event EventHandler AbrirVistaProducto
        {
            add { botonProducto.Click += value; }
            remove { botonProducto.Click -= value; }
        }
        public event EventHandler AgregarLineaProduccion
        {
            add { botonAgregarLinea.Click += value; }
            remove { botonAgregarLinea.Click -= value; }
        }
        public event EventHandler QuitarLineaProduccion
        {
            add { botonEliminarLinea.Click += value; }
            remove { botonEliminarLinea.Click -= value; }
        }
        public event EventHandler Simular
        {
            add { botonSimular.Click += value; }
            remove { botonSimular.Click -= value; }
        }
        public event EventHandler Reiniciar;

        public event EventHandler SeleccionarLinea
        {
            add { comboLineas.SelectedIndexChanged += value; }
            remove { comboLineas.SelectedIndexChanged -= value; }
        }
        public event EventHandler TemporizadorClick
        {
            add { timerSimulacionProducto.Tick += value; }
            remove { timerSimulacionProducto.Tick -= value; }
        }

        public void DetenerTemporizador()
        {
            timerSimulacionProducto.Dispose();
            MessageBox.Show("Simulación finalizada.");
        }

        public void ActualizarSimulacion(SimulacionProduccion simulacion)
        {
            simulacionProduccionBS.DataSource = simulacion;
            simulacionProduccionBS.ResetBindings(false);
            lineasBS.ResetBindings(false);
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

        public void ListarLineas(List<Linea> lineas)
        {
            panelLineas.Controls.Clear();
            _controlesLineas.Clear();
            int j = 1;

            lineas.ToList().ForEach((l) =>
            {
                ControlLineaProduccion control = new ControlLineaProduccion(l, j);
                _controlesLineas.Add(control);
                panelLineas.Controls.Add(control);
                control.Width = panelLineas.Width - 20;
                j++;
            });

            List<int> indexs = new List<int>();
            for (int i = 1; i <= lineas.Count; i++)
            {
                indexs.Add(i);
            }
            comboLineas.DataSource = indexs;
            labelNroLineas.Text = lineas.Count.ToString();
        }

        public void MostrarDatosLinea(List<Linea> lineas)
        {
            lineasBS.Clear();
            lineasBS.Add(lineas[comboLineas.SelectedIndex]);
            lineasBS.ResetBindings(false);
        }

        private void buttonSimularHoras_Click(object sender, EventArgs e)
        {
            timerSimulacionProducto.Start();
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            panelGraficos.Visible = (panelLineas.Visible);
            panelLineas.Visible = !(panelLineas.Visible);
            botonGraficos.Text = (panelLineas.Visible) ? "Comparar líneas" : "Ajustar líneas";
        }
    }

    public class VistaPrincipalConPresentador : VistaBase<PresentadorPrincipal> { }
}
