namespace provadoka
{
    public class Dokar
    {
        //Metodos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }


        public Dokar(string marca, string modelo, int anofabricacao, string cor, double valor){ //Construtor
            this.Marca = marca;
            this.Modelo = modelo;
            this.AnoFabricacao = anofabricacao;
            this.Cor = cor;
            this.Valor = valor;
        }

    }
}