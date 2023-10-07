using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //conectar o console com a control
            Control controle = new Control();// declaro e instancio a variavel
            controle.Operacao();// chamando metodo operacao
            Console.ReadLine();//Leia - Uso para manter o prompt aberto
        }//Fim do método main
    }//fim da classe Program
}//fim do projeto

