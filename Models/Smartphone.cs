namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        public string Modelo { get; set; }

        public string IMEI { get; set; }

        public int Memoria { get; set; }


        public Smartphone(int memoria,string numero, string modelo, string imei)
        {
            Memoria = memoria;
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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