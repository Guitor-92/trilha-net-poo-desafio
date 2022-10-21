namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMei { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMei = iMEI;
            Memoria = memoria;
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