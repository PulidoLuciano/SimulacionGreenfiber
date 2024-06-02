using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion.Componentes
{
    public partial class ControlLineaProduccion : UserControl
    {
        public bool Seleccionado { get; set; }
        Linea _linea;

        public ControlLineaProduccion(Linea linea)
        {
            InitializeComponent();
            Seleccionado = false;
            _linea = linea;
            ActualizarTrituradora(_linea.MaquinaTrituradora);
            ActualizarLimpiadora(_linea.MaquinaLimpiadora);
            ActualizarRefinadora(_linea.MaquinaRefinadora);
            ActualizarEmpaquetadora(_linea.MaquinaEmpaquetadora);
        }

        public void ActualizarTrituradora(Trituradora trituradora)
        {
            TrituradoraBS.DataSource = trituradora;
            TrituradoraBS.ResetBindings(false);
        }

        public void ActualizarLimpiadora(Limpiadora limpiadora)
        {
            LimpiadoraBS.DataSource = limpiadora;
            LimpiadoraBS.ResetBindings(false);
        }

        public void ActualizarRefinadora(Refinadora refinadora)
        {
            RefinadoraBS.DataSource = refinadora;
            RefinadoraBS.ResetBindings(false);
        }

        public void ActualizarEmpaquetadora(Empaquetadora empaquetadora)
        {
            EmpaquetadoraBS.DataSource = empaquetadora;
            EmpaquetadoraBS.ResetBindings(false);
        }

        void Seleccionar()
        {
            Seleccionado = !Seleccionado;
            BackColor = (Seleccionado) ? Color.FromArgb(120, 100, 80) : Color.FromArgb(75, 54, 33);
        }

        private void ControlLineaProduccion_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void panelDatos_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void panelLinea_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
