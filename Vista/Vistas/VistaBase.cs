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

namespace Presentacion.Vistas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="IVista"/> para formularios de Windows.
    /// Esta clase sirve para ser heredada.
    /// <para>
    /// Se recomienda el uso de la versión genérica de la clase <see cref="VistaBase{T}"/>
    /// con asociación fuertemente tipada al presentador.
    /// </para>
    /// </summary>
    public partial class VistaBase : Form, IVista
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IVista.Presentador"/>
        /// </summary>
        public virtual IPresentador Presentador { get; set; }

        /// <summary>
        /// Implementación de <see cref="IVista.Mostrar(IVista)"/>
        /// </summary>
        public void Mostrar(IVista padre = null)
        {
            if (padre != null)
            {
                MdiParent = (Form)padre;
            }
            Show();
        }

        /// <summary>
        /// Implementación de <see cref="IVista.MostrarComoDialogo"/>
        /// </summary>
        public void MostrarComoDialogo()
        {
            ShowDialog();
        }

        public bool MostrarConfirmacion(string mensaje)
        {
            return MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
