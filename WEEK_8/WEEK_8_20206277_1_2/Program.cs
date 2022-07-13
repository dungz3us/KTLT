using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_20206277_1_2
{
    class Program
    {
        public class EvaluateString
        {
            public static int evaluate(string expression)
            {
                char[] tokens = expression.ToCharArray();
        
                // Stack for numbers: 'values'
                Stack<int> values = new Stack<int>();
        
                // Stack for Operators: 'ops'
                Stack<char> ops = new Stack<char>();
        
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] == ' ')
                    {
                        continue;
                    }
        
                    if (tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        StringBuilder sbuf = new StringBuilder();
                        
                        while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                        {
                            sbuf.Append(tokens[i++]);
                        }
                        values.Push(int.Parse(sbuf.ToString()));

                        i--;
                    }
        
                    else if (tokens[i] == '(')
                    {
                        ops.Push(tokens[i]);
                    }
        
                    else if (tokens[i] == ')')
                    {
                        while (ops.Peek() != '(')
                        {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                        }
                        ops.Pop();
                    }
        
                    else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                    {
                        while (ops.Count > 0 && hasPrecedence(tokens[i],ops.Peek()))
                        {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                        }
                        ops.Push(tokens[i]);
                    }
                }
        
                while (ops.Count > 0)
                {
                    values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                }
                return values.Pop();
            }
        
            public static bool hasPrecedence(char op1, char op2)
            {
                if (op2 == '(' || op2 == ')')
                {
                    return false;
                }
                if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        
            public static int applyOp(char op, int b, int a)
            {
                switch (op)
                {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new System.NotSupportedException("Cannot divide by zero");
                    }
                    return a / b;
                }
                return 0;
            }
        
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter an expression to evaluate: ");
                string expression = Console.ReadLine();
                Console.WriteLine(expression + " = " + evaluate(expression));
                Console.ReadLine();
            }
        }
    }
}
