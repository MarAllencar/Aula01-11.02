using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_Ex01Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data deseu nascimento no formato dd/MM/yyyy: ");

            //Armazenado o que o usuário digitar numa variável.
            DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine());

            //Guardando em uma variável numérica a quantidade de dias vividos.
            int nrDias = DateTime.Now.Subtract(dtNascimento).Days;

            //Retornando ao usuário informações sobre seu nascimento.
            Console.WriteLine("Você já viveu " + nrDias + " Dias.");

            Console.ReadKey();
        }
    }
}
