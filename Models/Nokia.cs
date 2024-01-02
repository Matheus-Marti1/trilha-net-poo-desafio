namespace DesafioPOO.Models
{
    // Implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu Nokia...");
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }
    }
}