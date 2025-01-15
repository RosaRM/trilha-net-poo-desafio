namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(int memoria, string numero, string modelo, string imei) : base(memoria, numero, modelo, imei)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Entrando na AppleStore e Instalando o aplicativo {nomeApp}");
        }    
    }
}