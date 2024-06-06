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
        event EventHandler TickTimer;
        event EventHandler CambiarMaterial;

        public int MaterialSeleccionado { get; }
        System.Windows.Forms.Timer TimerSimulacion { get; }

        public void CerrarVentana();
        public void EstablecerSimulacion(SimulacionProducto simulacion);
        public void CambiarVisualizacionTemp(double tempInterior, double tempExterior, int hora);
        public void CambiarVisualizacionEspesor(double espesor);
        public void BloquearControles(bool bloquear);
    }
}
