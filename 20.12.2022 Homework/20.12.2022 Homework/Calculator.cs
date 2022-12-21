using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _20._12._2022_Homework
{
    internal class Calculator
    {
        public string Calculation(int num1, int num2, string operation)
        {
            double result = 0;


            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result.ToString();

                case "-":
                    result = num1 - num2;
                    return result.ToString();

                case "*":
                    result = num1 * num2;
                    return result.ToString();

                case "/":
                    result = num1 / num2;
                    return result.ToString();
               
                default:
                    return "please add correct operation";
              


            }

        }

    }
}




