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
    /// Implementación base de la interfaz <see cref="IVista{T}"/> para formularios de Windows.
    /// Tiene una asociación fuertemente tipada al presentador. Esta clase sirve para ser heredada.
    /// <para>
    /// Se recomienda el uso de esta clase para heredar en los formularios de Windows.
    /// </para>
    /// </summary>
    public class VistaBase<T> : VistaBase, IVista<T>
        where T : class, IPresentador
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IVista{T}.Presentador"/>
        /// </summary>
        public new T Presentador { get; set; }

        /// <summary>
        /// Implementación de <see cref="IVista.Presentador"/> 
        /// como puerta de enlace la propiedad fuertemente tipada
        /// <see cref="IVista{T}.Presentador"/>
        /// </summary>
        IPresentador IVista.Presentador
        {
            get { return Presentador; }
            set { Presentador = value as T; }
        }
    }
}
