using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AnalizadorDeBolsaDeValores : IAnalizarBolsaDeValorescs
    {
        public void analizarDatosEnJson(string datos)
        {
            Console.WriteLine("Se analizaron los datos en formato json");
        }
    }
}
