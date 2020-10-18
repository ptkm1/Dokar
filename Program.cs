using System;
using System.Collections.Generic;

namespace provadoka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dokar> Doka = new List<Dokar>(); //Instanciando a classe
           
           

            //Inputs
            Console.WriteLine("//////////////////////////////ADICIONAR 1 veiculo/////////////////////////////////");
            Console.WriteLine("Digite o marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricacao");
            int anofabricacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor");
            string cor = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            double valor = Convert.ToDouble(Console.ReadLine());
            //Inputs 2
            Console.WriteLine("//////////////////////////////ADICIONAR 2 veiculo/////////////////////////////////");
            Console.WriteLine("Digite o marca");
            string marca1 = Console.ReadLine();
            Console.WriteLine("Digite o modelo");
            string modelo1 = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricacao");
            int anofabricacao1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor");
            string cor1 = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            //Inputs 3
            Console.WriteLine("//////////////////////////////ADICIONAR 3 veiculo/////////////////////////////////");
            Console.WriteLine("Digite o marca");
            string marca2 = Console.ReadLine();
            Console.WriteLine("Digite o modelo");
            string modelo2 = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricacao");
            int anofabricacao2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor");
            string cor2 = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            //Instanciando os 3 carros, para posteriormente adicionar na Lista
            Dokar d1 = new Dokar(marca, modelo, anofabricacao, cor, valor);
            Dokar d2 = new Dokar(marca1, modelo1, anofabricacao1, cor1, valor1);
            Dokar d3 = new Dokar(marca2, modelo2, anofabricacao2, cor2, valor2);

            //ADICIONAR COISAS na classe
            Doka.Add(d1);
            Doka.Add(d2);
            Doka.Add(d3);
            
            Console.WriteLine("///////////////////////TODOS OS VEICULOS DA LOJA DOKAR////////////////////////////////////////");
            // Imprimindo a Lista de TODOS OS VEICULOS
            foreach(Dokar x in Doka)
            {
                Console.WriteLine($"Marca: {x.Marca}, Modelo: {x.Modelo}, Ano de fabricação: {x.AnoFabricacao} Cor: {x.Cor} Valor: {x.Valor} ");
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////");

            //BUSCAR POR MARCA
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("digite a Marca para buscar");
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            string buscarMarca = Console.ReadLine();
            List<Dokar> resultadoMarca = Doka.FindAll(x =>x.Marca==buscarMarca);

            foreach(Dokar x in resultadoMarca)
            {
                Console.WriteLine($"Marca: {x.Marca}, Modelo: {x.Modelo}, Ano de fabricação: {x.AnoFabricacao} Cor: {x.Cor} Valor: {x.Valor} ");
                
            }

            //BUSCAR POR MODELO
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("digite o modelo para buscar");
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            string buscarModelo = Console.ReadLine();
            List<Dokar> resultadoModelo = Doka.FindAll(x =>x.Modelo==buscarModelo);
              foreach(Dokar x in resultadoModelo)
            {
                Console.WriteLine($"Marca: {x.Marca}, Modelo: {x.Modelo}, Ano de fabricação: {x.AnoFabricacao} Cor: {x.Cor} Valor: {x.Valor} ");
                
            }

            //BUSCAR POR ANO
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("digite o Ano para buscar");
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            int buscarPorAno = int.Parse(Console.ReadLine());
            Console.WriteLine($"////////////////////////////Carro fabricado no ano de {buscarPorAno}///////////////////////////////////");
            List<Dokar> resultadoAno = Doka.FindAll(x =>x.AnoFabricacao==buscarPorAno);
              foreach(Dokar x in resultadoAno)
            {
                Console.WriteLine($"Marca: {x.Marca}, Modelo: {x.Modelo}, Ano de fabricação: {x.AnoFabricacao} Cor: {x.Cor} Valor: {x.Valor} ");
                
            }

            
            //BUSCAR VEICULOS MENORES QUE 15000.00
            Console.WriteLine("///////////VEICULOS MENOS QUE 15000.00/////////////////////////");
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            foreach (Dokar y in Doka)
            {
                if(y.Valor < 15000.00){
                    Console.WriteLine($"Marca: {y.Marca}, Modelo: {y.Modelo} ");
                }
            }


            //BUSCAR PELA COR
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("Carros de cor Branca");
            foreach(Dokar y in Doka){
                if(y.Cor == "branca" || y.Cor == "branco"){
                    Console.WriteLine($"Marca: {y.Marca}, Modelo: {y.Modelo}, Ano de fabricação: {y.AnoFabricacao} Cor: {y.Cor} Valor: {y.Valor} ");
                }
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            

            //REMOVER
            //Excluindo Carro da lista e imprimindo lista atualizada
            Doka.Remove(d1); //Removendo o veiculo de Dokar
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("Após Remover o 1 CARRO");
            foreach(Dokar x in Doka)
            {
                Console.WriteLine($"Marca: {x.Marca}, Modelo: {x.Modelo}, Ano de fabricação: {x.AnoFabricacao} Cor: {x.Cor} Valor: {x.Valor} ");
            }


        }
    }
}
