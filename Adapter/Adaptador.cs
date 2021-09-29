using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaptador : ITarget
    {
        private AnalizadorDeBolsaDeValores analizadorDeBolsaDeValores;

        public Adaptador(AnalizadorDeBolsaDeValores analizadorDeBolsaDeValores)
        {
            this.analizadorDeBolsaDeValores = analizadorDeBolsaDeValores;
        }

        public void AnalizarDatosEnXml(string datos)
        {
            analizadorDeBolsaDeValores.analizarDatosEnJson(datos);
        }
    }
}
