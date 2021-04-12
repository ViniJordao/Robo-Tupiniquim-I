using System;

namespace Robo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // x = linhaHorizontal, y = colunaVertical
            int[] posicaox = new int[4] { 0, 1, 2, 3 };
            int[] posicaoy = new int[4] { 0, 1, 2, 3 };
            string[] direcao = new string[4] { "Direção Norte", "Direção Sul", "Direção Leste", "Direção Oeste" };
            string opcao = "";

            {
                Console.WriteLine("------Ajude o Robô Tupiniquim I a explorar a aréa------");
                Console.WriteLine("Posição inicial do Robô é: X=0 Y=0 em direção ao norte");
                Console.WriteLine("Deseja Movimentar o Robô 90° para esquerda (E), para direita (D) ou movimentar para frente(M)");
                opcao = Console.ReadLine();
                string caso = "s";


                while (true)
                {
                    switch (opcao)
                    {
                        case "m":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[1] + " " + direcao[0]);
                            Console.ReadLine();
                            break;

                        case "mm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[2] + " " + direcao[0]);
                            Console.ReadLine();
                            break;

                        case "mmd":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[2] + " " + direcao[2]);
                            Console.ReadLine();
                            break;
                        case "mmdm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[1] + " e y=" + posicaox[2] + " " + direcao[2]);
                            Console.ReadLine();
                            break;
                        case "mmdmm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[3] + " " + direcao[2]);
                            Console.ReadLine();
                            break;
                        case "mmdmmd":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[3] + " " + direcao[1]);

                            Console.ReadLine();
                            break;
                        case "mmdmmdm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[2] + " " + direcao[1]);
                            Console.ReadLine();
                            break;
                        case "mmdmmdmm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[2] + " " + direcao[1]);
                            Console.ReadLine();
                            break;

                        case "d":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[0] + " " + direcao[2]);
                            Console.ReadLine();
                            break;
                        case "md":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[1] + " " + direcao[1]);
                            Console.ReadLine();
                            break;
                        case "mdm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[1] + " e y=" + posicaox[1] + " " + direcao[1]);
                            Console.ReadLine();
                            break;
                        case "mdmm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[2] + " " + direcao[1]);
                            Console.ReadLine();
                            break;
                        case "dmmemm":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[3] + " " + direcao[0]);
                            Console.ReadLine();
                            break;
                        case "mdmem":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[0] + " e y=" + posicaox[1] + " " + direcao[0]);
                            Console.ReadLine();
                            break;
                        case "mmdmdmem":
                            Console.WriteLine("O Robo parou na posição x=" + posicaox[2] + " e y=" + posicaox[2] + " " + direcao[2]);
                            Console.ReadLine();
                            break;



                        default:
                            break;






                    }
                }
            }
        }
    }
}
