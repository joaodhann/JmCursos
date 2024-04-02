using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int contD = 0;
            int contA = 0;
            int contM = 0;
            int contE = 0;
            string rsp = "S";
            while (rsp == "S")
            {
                Console.WriteLine("Digite qual seu curso: (D)Desenvolvimento | (A)Administração | (M)Mecatrônica | (E)Edificação: ");
                string curso = Console.ReadLine();
                switch (curso)
                {
                    case "D":
                        if (contD < 5)
                        {
                            contD++;
                            Console.WriteLine("Parabéns você foi matriculado");
                        }
                        else
                        {
                            Console.WriteLine("Perdeu a matrícula");
                        }
                        break;
                    case "A":
                        if (contA < 5)
                        {
                            contA++;
                            Console.WriteLine("Parabéns você foi matriculado");
                        }
                        else
                        {
                            Console.WriteLine("Perdeu a matrícula");
                        }
                        break;
                    case "M":
                        if (contM < 5)
                        {
                            contM++;
                            Console.WriteLine("Parabéns você foi matriculado");
                        }
                        else
                        {
                            Console.WriteLine("Perdeu a matrícula");
                        }
                        break;
                    case "E":
                        if (contE < 5)
                        {
                            contE++;
                            Console.WriteLine("Parabéns você foi matriculado");
                        }
                        else
                        {
                            Console.WriteLine("Perdeu a matrícula");
                        }
                        break;
                    default:
                        Console.WriteLine("ERRO");
                        break;
                }
                Console.WriteLine("Vagas que sobraram: " +
                                  " Desenvolvimento: " + (5 - contD) +
                                  "|  Administração: " + (5 - contA) +
                                  "|  Mecatrônica: " + (5 - contM) +
                                  "|  Edificação: " + (5 - contE));
                Console.WriteLine("Deseja matricular outro aluno? (S)Sim | (N)Não");
                rsp = Console.ReadLine().ToUpper().Substring(0, 1);
                Console.Clear();
            }
            Console.WriteLine("Alunos matriculados: " +
                              " Desenvolvimento: " + contD +
                              "|  Administração: " + contA +
                              "|  Mecatrônica: " + contM +
                              "|  Edificação: " + contE +
                              "| Total de matrículas: " + (contD + contA + contM + contE));
            Console.ReadKey();
        }
    }
}
