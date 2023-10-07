using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{

    class Control
    {
        Calculadora calc;// conectando variavel calc à classe calculadora
        private int opcao;

        public Control()
        {
            calc = new Calculadora(); //instanciando, calc é um objeto de calculadora 
        }// fim construtor

        public int ConsultarOpcao
        {
            get { return opcao; } 
            set { opcao = value; }
        }//fim metodo

        //coletar
        public void ColetarNum1()
        {
            Console.WriteLine("Informe um numero: ");
            calc.ConsultarNum1 = Convert.ToDouble(Console.ReadLine()); 
        }// fim do metodo coletar num1

        public void ColetarNum2()
        {
            Console.WriteLine("Informe outro numero: ");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }// fim do metodo coletar num2

        public void Menu ()
        {
            Console.WriteLine("----Menu----" +
                              "\n0.Sair" +
                              "\n1.Somar" +
                              "\n2.Subtrair" +
                              "\n3.Multiplicar" +
                              "\n4.Dividir" +
                              "Escolhar uma das opçoes ");
            int opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo menu

        //metodo que faça a operação
        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//limpa tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        ColetarNum1();//pegando o primeiro numero
                        ColetarNum2();//pegando segundo numero
                        Console.WriteLine("A soma dos numeros digitados é" + calc.Somar());
                        break;
                    case 2:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A subtracao dos numeros digitados é" + calc.Subtrair());
                        break;
                    case 3:
                        ColetarNum1();
                        ColetarNum2();
                        if (calc.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir por zero");
                        }
                        else
                        {
                            Console.WriteLine("A divisao dos numeros digitados é" + calc.Dividir());
                        }
                        break;
                    case 4:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A multiplicacao dos numeros digitados é" + calc.Multiplicar());
                        break;
                    default:
                        Console.WriteLine("Opcao escolhida nao é validam tente novamente")
                    break;
                }//fim switch
            } while (ConsultarOpcao != 0);
        }// fim operacao



    }// fim da classe
    class Calculadora
    {   
        //Variáveis Globais
        private double num1;
        private double num2;
        //Método construtor -> Instância as variáveis na memória do computador
        public Calculadora()
        {
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
        }//fim do método construtor

        //Métodos Modificadores = GET e SET
        public double ConsultarNum1
        {
            get { return this.num1;  }
            set { this.num1 = value; }
        }//fim do método ConsultarNum1

        public double ConsultarNum2
        {
            get { return this.num2; }
            set { this.num2 = value;}
        }//fim do ConsultarNum2

        //Métodos
        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2; 
        }//fim do somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }//fim do subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }//fim do multiplicar

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//fim do dividir


    }//fim da classe
}//fim do projeto
