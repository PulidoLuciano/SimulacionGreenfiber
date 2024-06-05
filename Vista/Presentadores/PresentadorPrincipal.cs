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
            Vista.Simular += SimularJornadaCompleta;
            Vista.TemporizadorClick += SimularHora;
            Vista.Reiniciar += ReiniciarProduccion;
            Vista.SeleccionarLinea += SeleccionarLinea;
            _simulacion = new SimulacionProduccion();
            _simulacion.agregarLinea();
            ActualizarSimulacion();
            ActualizarLineasVista();
        }


        private void SeleccionarLinea(object sender, EventArgs e)
        {
            Vista.MostrarDatosLinea(_simulacion.LineasProduccion);
        }

        private void FinalizarSimulacion()
        {
            Vista.DetenerTemporizador();
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

        public void SimularJornadaCompleta(object sender, EventArgs args)
        {
            _simulacion.simular();
            ActualizarSimulacion();
        }

        public void SimularHora(object sender, EventArgs args)
        {
            if (_simulacion.HorasTranscurridas == 0)
            {
                _simulacion.reiniciar();
                _simulacion.reiniciar_lineas();
            }
            if (_simulacion.HorasTranscurridas < _simulacion.HorasJornada)
            {
                _simulacion.simular_hora();
                _simulacion.HorasTranscurridas++;
            }
            else
            {
                FinalizarSimulacion();
                _simulacion.HorasTranscurridas = 0;
            }

            ActualizarSimulacion();

        }

        public void ReiniciarProduccion(object sender, EventArgs args)
        {
            _simulacion.reiniciar();
            ActualizarSimulacion();
            ActualizarLineasVista();
        }
    }
}
