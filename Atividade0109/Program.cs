using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade0109;
using Newtonsoft.Json;

namespace Atividade0109
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            //Escola escola = new Escola();
            //Escola.DescobrirNome();
            //Sesi sesi = new Sesi();
            //Sesi.CaucularMedia();
            //Senai senai = new Senai();
            //Senai.CaucularMedia();

            //ex2
            //Desenvolvedor1 desenvolvedor = new Desenvolvedor1();
            //Desenvolvedor1.CalcularExtras();
            //Bancario1 bancario1 = new Bancario1();
            //bancario1.CalcularExtras();
            //GerenteTI gerenteTI = new GerenteTI();
            //gerenteTI.CalcularExtras();

            //ex3

            //Estudante estudante = new Estudante();
            //estudante.idade = 1;
            //estudante.nome = "ana";
            //estudante.cidade ="garca";
            //estudante.estado ="sp";

            //Projeto projeto = new Projeto();
            //projeto.nome = "julia";
            //projeto.cidade ="garca";
            //projeto.estado ="sp";
            //projeto.idade = 1;


            //ex6
            //Losango losango = new Losango();
            //losango.CalcularArea();
            //Retangulo retangulo = new Retangulo();
            //retangulo.CalcularArea();
            //Console.WriteLine("calcular retangulo");
            //Console.ReadKey();

            //ex8
            //Midia midia = new Midia();
            //midia.ImprimirDados();
            //Console.ReadKey();
            //DVD dVD = new DVD();
            //dVD.VerFilmes();
            //Console.ReadKey();
            //USB usb = new USB();
            //usb.LerMusicas();
            //Console.ReadKey();

            //ex9

            Console.WriteLine("digite o valor que gostaria de depositar");
            double ValorDoDeposito = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o valor de saque ");
            double ValorDoSaque = Convert.ToDouble(Console.ReadLine());

            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Depositar(ValorDoDeposito);
            contaBancaria.Sacar(ValorDoSaque);
            contaBancaria.Saldo = ValorDoDeposito;
            Console.ReadKey();






        }

        //ex4
        //public static void DigitarInformacoes()
        //{
        //    Programador programador = new Programador();
        //    programador.Programar();

        //    Console.WriteLine("digite suas informacoes");
        //    string nome = Console.ReadLine();
        //    string cidade = Console.ReadLine();
        //    string rg = Console.ReadLine();
        //    string area = Console.ReadLine();
        //    int idade = Convert.ToInt32(Console.ReadLine());


        //    Console.WriteLine(" suas informacoes sao " + "nome" + "cidade" + "area" + "rg");

        //    string stringJson = JsonConvert.SerializeObject(programador);
        //    File.WriteAllText("text.Json", "stringJson");



        //ex5
        //public static void Definir()
        //{
        //    Empresario empresario = new Empresario();
        //    empresario.nome = "conny";
        //    empresario.endereco = "garca 1";
        //    empresario.CNPJ = "000000000000";
        //    empresario.NomeEmpresa = "cats";
        //    empresario.cidade = "garça";
        //}
        //public static void Json()
        //{
        //    Empresario empresario = new Empresario();
        //    empresario.nome = "ana";
        //    empresario.endereco = "residencial monte verde";
        //    empresario.CNPJ = "000000000";
        //    empresario.NomeEmpresa = "variedades";
        //    empresario.cidade = "garça";
        //    Console.WriteLine(empresario.nome);
        //    Console.WriteLine(empresario.endereco);
        //    Console.WriteLine(empresario.CNPJ);
        //    Console.WriteLine(empresario.NomeEmpresa);
        //    Console.WriteLine(empresario.cidade);

        //    Empresario empresario22 = new Empresario();
        //    empresario22.nome = "musiau";
        //    empresario22.endereco = "joao zapata";
        //    empresario22.CNPJ = "000000000";
        //    empresario22.NomeEmpresa = "garen";
        //    empresario22.cidade = "jafa";
        //    Console.WriteLine(empresario.nome);
        //    Console.WriteLine(empresario.endereco);
        //    Console.WriteLine(empresario.CNPJ);
        //    Console.WriteLine(empresario.NomeEmpresa);
        //    Console.WriteLine(empresario.cidade);

        //    Empresario empresario33 = new Empresario();
        //    empresario.nome = "guilheme";
        //    empresario33.endereco = "frei aurelio ";
        //    empresario33.CNPJ = "0000000000000";
        //    empresario33.NomeEmpresa = "sesi";
        //    empresario33.cidade = "garça";
        //    Console.WriteLine(empresario.nome);
        //    Console.WriteLine(empresario.endereco);
        //    Console.WriteLine(empresario.CNPJ);
        //    Console.WriteLine(empresario.NomeEmpresa);
        //    Console.WriteLine(empresario.cidade);

        //    Empresario empresario44 = new Empresario();
        //    empresario44.nome = "miguel";
        //    empresario44.endereco = "araceli";
        //    empresario44.CNPJ = "000000000";
        //    empresario44.NomeEmpresa = "ze leite";
        //    empresario44.cidade = "marilia";
        //    Console.WriteLine(empresario.nome);
        //    Console.WriteLine(empresario.endereco);
        //    Console.WriteLine(empresario.CNPJ);
        //    Console.WriteLine(empresario.NomeEmpresa);
        //    Console.WriteLine(empresario.cidade);

        //    string stringjson = JsonConvert.SerializeObject(empresario, Newtonsoft.Json.Formatting.Indented);
        //    string stringjson1 = JsonConvert.SerializeObject(empresario, Newtonsoft.Json.Formatting.Indented);
        //    string stringjson2 = JsonConvert.SerializeObject(empresario, Newtonsoft.Json.Formatting.Indented);
        //    string stringjson3 = JsonConvert.SerializeObject(empresario, Newtonsoft.Json.Formatting.Indented);

        //    File.WriteAllText("text.json", stringjson + stringjson1 + stringjson2 + stringjson3);
        //}


        //ex7
        //public void Animal()
        //{
        //    Animal animal = new Animal();
        //    animal.nome = "nina";
        //    animal.idade = 9; 

        //   Gato gato = new Gato();
        //   gato.nome = "bolinha";
        //   gato.idade = 3;

        //   gato.Pelo = "branco";

        //   Cachorro cachorro = new Cachorro();
        //   cachorro.nome= "mesclado";
        //   cachorro.idade = 20;

        //   cachorro.racaa= "pinscher";

        //   string stringJson = JsonConvert.SerializeObject(animal);
        //   File.WriteAllText("text.Json", "stringJson");



    }


}





