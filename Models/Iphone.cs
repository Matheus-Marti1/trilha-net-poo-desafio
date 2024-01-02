namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu Iphone...");
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }
    }
}