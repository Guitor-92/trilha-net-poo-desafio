using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Aplicativo {nomeApp.ToUpper()} ... \n{nomeApp.ToUpper()} instalado com sucesso!");
        }
    }
}