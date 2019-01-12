using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500ExerciciosResolvidos {
    class Program {
        static void Main(string[] args) {

            //algoritmo 11
            //Console.WriteLine("Aprendendo Algoritmo!");

            //algoritmo 12
            //Console.Write("Aprendendo Algoritmo!");
            //Console.Write("Com Anita e Guto");

            //algoritmo 13
            //Console.WriteLine("Aprendendo Algoritmo!");
            //Console.WriteLine("Com Anita e Guto");

            //algoritmo 14
            //Console.WriteLine("Aprendendo Algoritmo!!!");
            //Console.WriteLine("Com Anita e Guto");

            //algoritmo 15
            /*
            Console.WriteLine("Aprendendo Algoritmo");
            Console.WriteLine("Com Anita e Guto");
            Console.WriteLine();
            Console.WriteLine("E implementando no UAL");
            Console.WriteLine("Fica tudo mais fácil!!!");
            */

            //algoritmo 16
            //int x;
            //x = 10;
            //Console.WriteLine(x);

            //algoritmo 17
            //int x;
            //x = 10;
            //Console.WriteLine("Valor de x = "+ x);

            //algoritmo 18
            //int x;
            //x = 10;
            //Console.WriteLine("Valor de x = "+ (x+1) );

            //algoritmo 19
            /*
            Console.WriteLine("raiz " + Math.Sqrt(64));
            Console.WriteLine("raiz com exp e log e realint " + Convert.ToDouble(Math.Pow(0.5,Math.Log(64))));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-100));
            Console.WriteLine(Convert.ToDouble(10));
            Console.WriteLine(Convert.ToInt32(7.58));
            */
            //...apenas algumas funcoes...

            //algoritmo 20
            /*
            string nome = "Guilherme";
            int idade = 42;
            Console.WriteLine("Olá {0}, a sua idade é {1}", nome, idade);

            Console.WriteLine();

            string texto = "guilherme silveira,42,são paulo,brasil";
            string[] colunas = texto.Split(',');
            foreach (string i in colunas) {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            string curso = "fn13";
            string maiusculo = curso.ToUpper();
            Console.WriteLine(maiusculo); // imprime FN13

            Console.WriteLine();

            string replace = curso.Replace("1", "2");
            Console.WriteLine(curso); // imprime FN23;

            Console.WriteLine();

            string nomeCompleto = "guilherme silveira";
            string nome1 = nomeCompleto.Substring(0, 9);
            Console.WriteLine(nome1); // imprime guilherme;

            Console.WriteLine();

            int posicaoDoEspaco = nomeCompleto.IndexOf("silve");
            Console.WriteLine(posicaoDoEspaco); // imprime 10

            Console.WriteLine();

            int inicioDoSegundoNome = nomeCompleto.IndexOf("s");
            Console.WriteLine(nomeCompleto.Substring(inicioDoSegundoNome)); // imprime silveira
            */
            //Apenas algumas funcoes com string

            //irei pular pro exercicios 23 porque o 21 e o 22 sao toscos

            //algoritmo 23
            //int a, d;
            //Console.WriteLine("Digite numero de 3 casas");
            //a = int.Parse(Console.ReadLine());
            //d = a % 100 / 10;
            //Console.WriteLine("algorismo da casa das dezenas: " + d);

            //algoritmo 24
            //int a, d;
            //Console.WriteLine("Digite numero de 3 casas");
            //a = int.Parse(Console.ReadLine());
            //d = (a / 10) % 10;
            //Console.WriteLine("algorismo da casa das dezenas: " + d);

            //algoritmo 25\
            /*
            int data, dia, mes, ano;
            Console.WriteLine("Digite a data no formato ddmmaa");
            data = int.Parse(Console.ReadLine());
            dia = data / 10000;
            mes = data % 10000 / 100;
            ano = data % 100;
            Console.WriteLine("Dia " + dia);
            Console.WriteLine("Mes " + mes);
            Console.WriteLine("Ano " + ano);
            */

            //algoritmo 26
            /*
            int data, dia, mes, ano, ndata;
            Console.WriteLine("Digite data no formato DDMMAA: ");
            data = int.Parse(Console.ReadLine());
            dia = data / 10000;
            mes = data % 10000 / 100;
            ano = data % 100;
            ndata = mes * 10000 + dia * 100 + ano;
            Console.WriteLine("Data no formato MMDDAA: " + ndata);
            */

            //algoritmo 27
            /*
            int x, y;

            x = 2;
            y = 5;
            Console.WriteLine("X = " + x);
            x++;
            Console.WriteLine("Y = " + y);
            y--;
            Console.WriteLine("Novo valor de X = " + x);
            Console.WriteLine("Novo valor de Y = " + y);
            */

            //algoritmo 28
            //Console.WriteLine("E PRECISO FAZER TODOS OS ALGORITMOS PARA APRENDER ");

            //algoritmo 29
            //Console.WriteLine("DIEGO ");

            //algoritmo 30
            //int produto;
            //produto = 28 * 43;
            //Console.WriteLine("O produto entre os dois é: " + produto);

            //algoritmo 31
            //int media;
            //media = (9 + 8 + 7) / 3;
            //Console.WriteLine("A média aritmetica é: " + media);

            //algoritmo 32
            /*
            int numeroInteiro;
            Console.WriteLine("Entre com um número: ");
            numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine("Número: " + numeroInteiro);
            */

            //algoritmo 33
            /*
            int numeroUm, numeroDois;
            Console.WriteLine("Entre com um número: ");
            numeroUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com outro número: ");
            numeroDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 1: " + numeroUm);
            Console.WriteLine("Número 2: " + numeroDois);
            */

            //algoritmo 34
            /*
            int numero, suc, ant;
            Console.WriteLine("Digite um número");
            numero = int.Parse(Console.ReadLine());
            suc = numero+1;
            ant = numero-1;
            Console.WriteLine("Sucessor do número digitado: " + suc);
            Console.WriteLine("Antecessor do número digitado: " + ant);
            */

            //algoritmo 35
            /*
            string nome, endereco, tel;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            tel = Console.ReadLine();
            Console.WriteLine("NOME:  " + nome);
            Console.WriteLine("ENDEREÇO:  " + endereco);
            Console.WriteLine("TELEFONE:  " + tel);
            */

            //algoritmo 36
            /*
            int n1, n2, soma;
            Console.WriteLine("Digite o primeiro número da soma: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número da soma: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("Soma: " + soma);
            */

            //algoritmo 37
            /*
            int n1, n2, produto;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            produto = n1 * n2;
            Console.WriteLine("Produto: " + produto);
            */

            //algoritmo 38
            /*
            double n1, parte;
            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            parte = n1 / 3;
            Console.WriteLine("Terça parte: " + parte);
            */

            //algoritmo 39
            /*
            double n1, n2, media;
            Console.WriteLine("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine("Média das notas: " + media);
            */

            //algoritmo 40
            /*
            int n1, n2, quoc, rest;
            Console.WriteLine("Entre com o dividendo: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o divisor: ");
            n2 = int.Parse(Console.ReadLine());
            quoc = n1 / n2;
            rest = n1 % n2;
            Console.WriteLine("Dividendo: " + n1);
            Console.WriteLine("Divisor: " + n2);
            Console.WriteLine("Quociente: " + quoc);
            Console.WriteLine("Resto: " + rest);
            */

            //algoritmo 41
            /*
            double n1, n2, n3, n4, mp;
            Console.WriteLine("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            n4 = double.Parse(Console.ReadLine());

            mp = (n1 * 1 + n2 * 2 + n3 * 3 + n4 * 4) / 10;
            Console.WriteLine("Média ponderada: " + mp);
            */

            //algoritmo 42
            /*
            double angulo, rang;
            Console.WriteLine("Digite um angulo em graus: ");
            angulo = double.Parse(Console.ReadLine());
            rang = angulo * Math.PI / 180;
            Console.WriteLine("Seno: " + Math.Sin(rang));
            Console.WriteLine("Co-seno: " + Math.Cos(rang));
            Console.WriteLine("Tangente: " + Math.Tan(rang));
            Console.WriteLine("Co-secante: " + 1/Math.Sin(rang));
            Console.WriteLine("Secante: " + 1 / Math.Cos(rang));
            Console.WriteLine("Cotangente: " + 1 / Math.Tan(rang));
            */

            //algoritmo 43
            /*
            double n, log;
            Console.WriteLine("Entre com o logaritmo: ");
            n = double.Parse(Console.ReadLine());
            log = Math.Log(n) / Math.Log(10);
            Console.WriteLine("Logaritmo: " + log);
            */

            //algoritmo 44
            /*
            double n, log, bas;
            Console.WriteLine("Entre com o logaritmando: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a base: ");
            bas = double.Parse(Console.ReadLine());
            log = Math.Log(n) / Math.Log(bas);

            Console.WriteLine("Logaritmo de: " + n + " na base " + bas +" tem o logaritmo igual: " + log);
            */

            //algoritmo 45
            /*
            double n;
            Console.WriteLine("Entre com um numero: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Número: " + n);
            Console.WriteLine("Quadrado: " + Math.Pow(n,2));
            Console.WriteLine("Raiz quadrada: " + Math.Sqrt(n));
            */

            //algoritmo 46
            /*
            double saldo, nsaldo;
            Console.WriteLine("Digite o saldo: ");
            saldo = double.Parse(Console.ReadLine());
            nsaldo = saldo * 1.01;
            Console.WriteLine("Novo saldo: " + nsaldo);
            */

            //algoritmo 47
            /*
            int num, c, d, u, num1;
            Console.WriteLine("Entre com um número de 3 dígitos: ");
            num = int.Parse(Console.ReadLine());
            c = num / 100;
            d = num % 100 / 10;
            u = num % 10;
            num1 = u * 100 + d * 10 + c;
            Console.WriteLine("Número: " + num);
            Console.WriteLine("Invertido: " + num1);
            */

            //algoritmo 48
            /*
            double sm, qtdade, preco, vp, vd;
            Console.WriteLine("Digite o valor do salario minimo: ");
            sm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de quilowatt: ");
            qtdade = double.Parse(Console.ReadLine());

            preco = sm / 700;
            vp = qtdade * preco;
            vd = vp * 0.9;
            Console.WriteLine("Preço do quilowatt: " + preco);
            Console.WriteLine("Valor a pagar: " + vp);
            Console.WriteLine("Valor com 10% de desconto: " + vd);
            */

            //algoritmo 49


            Console.ReadLine();
        }
    }
}
