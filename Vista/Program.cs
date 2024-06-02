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

            System.Diagnostics.Debug.WriteLine($"PapelNetoReciclado: {l.PapelNetoReciclado} Kg");
            System.Diagnostics.Debug.WriteLine($"ProductoNetoProducido: {l.ProductoNetoProducido} Kg");
            System.Diagnostics.Debug.WriteLine($"TotalBolsas: {l.TotalBolsas} bolsas");
            System.Diagnostics.Debug.WriteLine($"Basura: {l.BasuraProducida} Kg");
            System.Diagnostics.Debug.WriteLine($"Desperdicio Refinadora: {l.DesperdicioRefinadora} Kg");
            System.Diagnostics.Debug.WriteLine($"Desperdicio Empaquetadora: {l.DesperdicioEmpaquetadora} Kg");
            System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de refinado: {l.LotePapel} Kg");
            System.Diagnostics.Debug.WriteLine($"Sobrante de la etapa de empaquetado: {l.AlmacenCelulosa} Kg");
            System.Diagnostics.Debug.WriteLine($"Cantidad de papel escaso: {l.PapelEscaso} Kg");
            System.Diagnostics.Debug.WriteLine($"Cantidad de papel intermedio: {l.PapelIntermedio} Kg");
            System.Diagnostics.Debug.WriteLine($"Cantidad de papel excesivo: {l.PapelExcesivo} Kg");
            System.Diagnostics.Debug.WriteLine($"Consumo total de ácido bórico: {l.ConsumoAcidoBorico} Kg");
            System.Diagnostics.Debug.WriteLine($"Consumo total de bórax: {l.ConsumoBorax} Kg");
            System.Diagnostics.Debug.WriteLine($"Potencia total consumida: {l.PotenciaTotal} kW");
            System.Diagnostics.Debug.WriteLine($"Cantidad de árboles salvados: {l.ArbolesSalvados} árboles");


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