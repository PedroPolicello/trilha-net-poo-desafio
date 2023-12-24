namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Vamos instalar o aplicativo {nomeApp}.\n1- Vá para a Apple Store.\n2- Em seguida digite {nomeApp} para buscar o aplicativo.\n3- Clique em seu icone.\n4- Então clique em instalar.");
        }

        public override void Quebrar()
        {
            Console.WriteLine("O Iphone quebrou.");
        } 
    }
}