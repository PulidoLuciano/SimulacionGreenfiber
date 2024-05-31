using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Infraestructura
{
    /// <summary>
    /// Este Singleton funciona como una fábrica, utilizando el contenedor de DI (Unity en este caso)
    /// para resolver (crear) las clases que no pueden ser inyectadas.
    /// La clase evita generar una dependencia del contenedor (Unity) en otras partes de la aplicación.
    /// </summary>
    public class Factoria
    {
        private static volatile Factoria _instance;
        private static readonly object _syncLock = new object(); //para hacer el singleton thread safe

        private Factoria()
        {

        }

        public static Factoria Instance
        {
            get
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Factoria();
                    }
                    return _instance;
                }
            }
        }

        private UnityContainer _container;

        public void SetContenedor(UnityContainer container)
        {
            _container = container;
        }

        public T Crear<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
