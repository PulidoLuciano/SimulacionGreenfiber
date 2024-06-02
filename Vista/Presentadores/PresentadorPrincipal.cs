using Dominio;
using Presentacion.Componentes;
using Presentacion.Interfaces;
using Presentacion.Tareas;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistas;

namespace Presentacion.Presentadores
{
    public class PresentadorPrincipal : PresentadorBase<TareaPrincipal, IVistaPrincipal>
    {
        SimulacionProduccion _simulacion;
        
        public PresentadorPrincipal(IVistaPrincipal vista) : base(vista)
        {
            Vista.AbrirVistaProducto += AbrirVistaProducto;
            Vista.AgregarLineaProduccion += AgregarLinea;
            Vista.Resize += MostrarLineas;
            Vista.QuitarLineaProduccion += EliminarLineas;
            Vista.Simular += SimularProduccion;
            _simulacion = new SimulacionProduccion();
            ActualizarSimulacion();
            ActualizarLineasVista();
        }
        private void ActualizarSimulacion()
        {
            Vista.ActualizarSimulacion(_simulacion);
        }

        private void ActualizarLineasVista()
        {
            Vista.ListarLineas(_simulacion.LineasProduccion);
        }

        public void AbrirVistaProducto(object sender, EventArgs e)
        {
            Tarea.NavegarA<PresentadorProducto>();
        }

        public void AgregarLinea(object sender, EventArgs e)
        {
            _simulacion.agregarLinea();
            ActualizarLineasVista();
        }

        public void MostrarLineas(object sender, EventArgs e)
        {
            ActualizarLineasVista();
        }

        public void EliminarLineas(object sender, EventArgs args)
        {
            List<ControlLineaProduccion> controles = Vista.ControlesLineas;
            int index = 0;
            while (true)
            {
                index = controles.FindIndex(c => c.Seleccionado);
                if(index == -1) break;
                controles.RemoveAt(index);
                _simulacion.LineasProduccion.RemoveAt(index);
            }
            ActualizarLineasVista();
        }

        public void SimularProduccion(object sender, EventArgs args)
        {
            _simulacion.simular();
            ActualizarSimulacion();
        }
    }
}
