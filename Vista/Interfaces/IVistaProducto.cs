using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Interfaces
{
    public interface IVistaProducto : IVista
    {
        event EventHandler ClickProduccion;
        event EventHandler ScrollTempInterior;
        event EventHandler ScrollTempExterior;
        event EventHandler ScrollEspesor;
        event EventHandler ClickSimular;

        public void CerrarVentana();
        public void EstablecerSimulacion(SimulacionProducto simulacion);
        public void CambiarVisualizacion(double tempInterior, double tempExterior, double espesor);
    }
}
