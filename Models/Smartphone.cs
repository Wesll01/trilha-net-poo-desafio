using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } // Propriedade para o modelo do smartphone
        public string Marca { get; set; } // Propriedade para a marca do smartphone

        public Smartphone(string numero, string modelo, string marca)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
