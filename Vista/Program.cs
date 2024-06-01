using Vistas;
using Presentacion.Vistas;
using Unity;
using Infraestructura;
using Vistas.Interfaces;
using Presentacion.Interfaces;
using Presentacion.Tareas;
using Dominio;
using Extreme;
using Extreme.Statistics.Distributions;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Linea l = new Linea();
            l.iniciar();

            Console.WriteLine($"PapelNetoReciclado: {l.PapelNetoReciclado} Kg");
            Console.WriteLine($"ProductoNetoProducido: {l.ProductoNetoProducido} Kg");
            Console.WriteLine($"TotalBolsas: {l.TotalBolsas} bolsas");
            Console.WriteLine($"Basura: {l.BasuraProducida} Kg");


            /*for(int i = 0; i < 1000; i++) {
                double u = 0;
                NumerosAleatorios.Generador.G(ref u);
                Console.WriteLine(u);
            }*/


            var container = new UnityContainer();
            Factoria.Instance.SetContenedor(container);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Registracion de Tipos
            container.RegisterType<IVistaContenedora, VistaContenedora>();
            container.RegisterType<IVistaPrincipal, VistaPrincipal>();
            container.RegisterType<IVistaProducto, VistaProducto>();
            #endregion

            AdministradorDeTareas.Instance.Iniciar<TareaContenedora>();
            Application.Run(Application.OpenForms[0]);
        }
    }
}