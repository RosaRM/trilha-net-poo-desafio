namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(int memoria, string numero, string modelo, string imei) : base(memoria, numero, modelo, imei)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Entrando na PlayStore e Instalando o aplicativo {nomeApp}");
        }
    }
}