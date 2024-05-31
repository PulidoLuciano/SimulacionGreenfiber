using Infraestructura;
using Presentacion.Interfaces;
using Presentacion.Tareas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;

namespace Presentacion
{
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas _instance;
        private static readonly object _syncLock = new object();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                lock (_syncLock)
                {
                    return _instance = _instance ?? new AdministradorDeTareas();
                }
            }
        }
        #endregion

        public void Iniciar<TTarea>(IVista mdiPadre = null)
            where TTarea : ITarea
        {
            var tarea = Factoria.Instance.Crear<TTarea>();
            tarea.MdiPadre = mdiPadre;
            tarea.Iniciar();
        }
    }
}
