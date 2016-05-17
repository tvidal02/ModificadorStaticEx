using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //class Test {
        //    static int n1 = 0;

        //    public static void Y() 
        //    {
        //        this.n1 = 1;
        //    }

        //    //public void X() 
        //    //{
        //    //    this.n1 = 1;
        //    //}
        //}

        static void Main(string[] args)
        {
            var x = new Test();
            

            //Propriedades estáticas também são acessadas pelo nome da classe
            int num1 = Calculator.FirstOperand;
            int num2 = Calculator.SecondOperand;
            var opr = Calculator.GetRandomOperator();

            int res = Calculator.Calculate(num1, num2, opr);
            Console.WriteLine("Resultado: " + res);
            
            Console.ReadKey();
        }
    }
}