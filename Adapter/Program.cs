using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var datosXml = "";

            var servicioAnalizador = new AnalizadorDeBolsaDeValores();

            var adaptadorXml = new Adaptador(servicioAnalizador);

            adaptadorXml.AnalizarDatosEnXml(datosXml);
        }
    }
}
