using Presentacion.Interfaces;
using Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Presentacion.Presentadores
{
    public class PresentadorProducto : PresentadorBase<TareaProducto, IVistaProducto>
    {
        SimulacionProducto _simulacionProducto;

        public PresentadorProducto(IVistaProducto vista) : base(vista)
        {
            Vista.ClickProduccion += VolverAProduccion;
            Vista.ScrollTempExterior += CambiarTemperaturas;
            Vista.ScrollTempInterior += CambiarTemperaturas;
            Vista.ScrollEspesor += CambiarTemperaturas;
            _simulacionProducto = new SimulacionProducto();
            Vista.EstablecerSimulacion(_simulacionProducto);
            Vista.CambiarVisualizacion(_simulacionProducto.TempInterior, _simulacionProducto.TempExterior, _simulacionProducto.EspesorCm);
        }

        public void CambiarTemperaturas(object sender, EventArgs e)
        {
            Vista.CambiarVisualizacion(_simulacionProducto.TempInterior, _simulacionProducto.TempExterior, _simulacionProducto.EspesorCm);
        }

        public void VolverAProduccion(object sender, EventArgs e)
        {
            Vista.CerrarVentana();
        }
    }
}
