namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescreve o método "InstalarAplicativo"        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Entrando na PlayStore e Instalando o aplicativo {nomeApp}");
        }
    }
}