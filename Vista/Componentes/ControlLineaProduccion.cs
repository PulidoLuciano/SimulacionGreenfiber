using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Componentes
{
    public partial class ControlLineaProduccion : UserControl
    {
        public bool Seleccionado { get; set; }

        public ControlLineaProduccion()
        {
            InitializeComponent();
            Seleccionado = false;
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
