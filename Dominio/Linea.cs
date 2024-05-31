using Dominio.Maquinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Linea
    {
        Tolva tolva = new Tolva();
        Triturador triturador = new Triturador();
        Filtro filtro = new Filtro();
        Refinador refinador = new Refinador();

        public void Start()
        {
            double p_0 = 1000; // Normal

            /////////////////// ETAPA 1 - Ingreso de Papel ////////////////////

            tolva.PapelEntrada = p_0;
            tolva.Velocidad = 10;

            double p_1 = tolva.PapelSalida;

            Console.WriteLine("> Tolva: ");
            Console.WriteLine($"\t Papel de entrada: {p_1} Kg.");
            Console.WriteLine($"\t Velocidad: {tolva.Velocidad} Kg/h.");
            Console.WriteLine($"\t Tiempo: {tolva.Tiempo} h.");

            /////////////////// ETAPA 2 - Trituración ////////////////////

            triturador.PapelEntrada = p_1;
            triturador.Velocidad = 10;

            double p_2 = triturador.PapelSalida;

            Console.WriteLine("> Triturador: ");
            Console.WriteLine($"\t Papel de entrada: {p_2} Kg.");
            Console.WriteLine($"\t Velocidad: {triturador.Velocidad} Kg/h.");
            Console.WriteLine($"\t Tiempo: {triturador.Tiempo} h.");

            /////////////////// ETAPA 3 - Filtrado y Separación de Polvo ////////////////////

            filtro.PapelEntrada = p_2;
            filtro.Velocidad = 10;

            double p_3 = filtro.PapelSalida;

            Console.WriteLine("> Filtro: ");
            Console.WriteLine($"\t Papel de entrada: {p_3} Kg.");
            Console.WriteLine($"\t Velocidad: {filtro.Velocidad} Kg/h.");
            Console.WriteLine($"\t Tiempo: {filtro.Tiempo} h.");

            /////////////////// ETAPA 4 - Refinación y Dosificación de Quimicos ////////////////////

            refinador.PapelEntrada = p_3;
            refinador.Velocidad = 10;

            double p_4 = refinador.PapelSalida;

            Console.WriteLine("> Refinador: ");
            Console.WriteLine($"\t Papel de entrada: {p_4} Kg.");
            Console.WriteLine($"\t AcidoBorico: {refinador.AcidoBorico} Kg.");
            Console.WriteLine($"\t Borax: {refinador.Borax} Kg.");
            Console.WriteLine($"\t Velocidad: {filtro.Velocidad} Kg/h.");
            Console.WriteLine($"\t Tiempo: {filtro.Tiempo} h.");



        }

        public void Show()
        {

        }
    }
}
