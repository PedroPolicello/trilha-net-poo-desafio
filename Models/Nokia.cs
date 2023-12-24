namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Vamos instalar o aplicativo {nomeApp}.\n1- Vá para a Google Store.\n2- Em seguida digite {nomeApp} para buscar o aplicativo.\n3- Clique em seu icone.\n4- Então clique em instalar.");
        }

        public override void Quebrar()
        {
            Console.WriteLine("Não foi possivel quebrar.");
        }
    }
}