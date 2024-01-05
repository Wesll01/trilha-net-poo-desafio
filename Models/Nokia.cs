using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca) : base(numero, modelo, marca)
        {
            // Construtor da classe base (Smartphone) é chamado para definir o número, modelo e marca
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia...");
            // Lógica específica para instalar um aplicativo em um dispositivo Nokia
        }
    }
}
