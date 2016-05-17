using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class Calculator
    {
        //Em toda classe estática, os atributos têm de ser estáticos
        public static int firstOperand;
        public static int secondOperand;

        //Em toda classe estática, os métodos têm de ser estáticos
        public static int Calculate(int a, int b, Operator op)
        {
            if (op.Equals(Operator.PlusOp)) return a + b;
            if (op.Equals(Operator.MinusOp)) return a - b;
            if (op.Equals(Operator.MultOp)) return a * b;
            if (op.Equals(Operator.DivOp)) return a / b;

            return 0;
        }

        public static int FirstOperand
        {
            get { return firstOperand; }
            set { firstOperand = value; }
        }

        public static int SecondOperand
        {
            get { return secondOperand; }
            set { secondOperand = value; }
        }

        //Enum, assim como destrutores e indexadores, não aceita o modificador static
        public enum Operator
        {
            MinusOp = '-',
            PlusOp = '+',
            MultOp = '*',
            DivOp = '/'
        }

        public static Operator GetRandomOperator() 
        {
            var listOp = new List<Operator>() 
            {
                Operator.DivOp,
                Operator.MinusOp,
                Operator.MultOp,
                Operator.PlusOp
            };

            Random r = new Random();
            //seleciona aleatoriamente o índice do operador da lista de operadores
            //por exemplo, o operador "Minus" = 1
            int i = r.Next(listOp.Count);
            var op = listOp[i]; 

            return op;
        }

        static Calculator()
        {
            FirstOperand = new Random().Next(45);
            SecondOperand = new Random().Next(100);
        }
    }
}