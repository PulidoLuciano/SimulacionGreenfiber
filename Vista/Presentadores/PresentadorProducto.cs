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
            Vista.ScrollEspesor += CambiarEspesor;
            Vista.ClickSimular += GestionarSimulacion;
            Vista.TickTimer += Simular;
            Vista.CambiarMaterial += CambiarMaterialSimulacion;
            _simulacionProducto = new SimulacionProducto();
            Vista.EstablecerSimulacion(_simulacionProducto);
            Vista.CambiarVisualizacionEspesor(_simulacionProducto.EspesorCm);
            Vista.CambiarVisualizacionTemp(_simulacionProducto.TempInterior, _simulacionProducto.TempExterior);
        }

        void Simular(object sender, EventArgs e)
        {
            _simulacionProducto.simularHora();
            Vista.CambiarVisualizacionTemp(_simulacionProducto.TempInterior, _simulacionProducto.TempExterior);
        }

        void GestionarSimulacion(object sender, EventArgs e)
        {
            if (!Vista.TimerSimulacion.Enabled) {
                _simulacionProducto.reiniciar();
                Vista.TimerSimulacion.Start();
            } 
            else Vista.TimerSimulacion.Stop();
            Vista.BloquearControles(Vista.TimerSimulacion.Enabled);
        }

        void CambiarMaterialSimulacion(object sender, EventArgs e)
        {
            _simulacionProducto.MaterialElegido = Vista.MaterialSeleccionado;
            Vista.CambiarVisualizacionTemp(_simulacionProducto.TempInterior, _simulacionProducto.TempExterior);
        }

        public void CambiarEspesor(object sender, EventArgs e)
        {
            Vista.CambiarVisualizacionEspesor(_simulacionProducto.EspesorCm);
        }

        public void VolverAProduccion(object sender, EventArgs e)
        {
            Vista.CerrarVentana();
        }
    }
}
