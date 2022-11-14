using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class clscalculation
{
    public void addition(int a, int b)
    {
        Console.WriteLine("out addition is {0}", a + b);
    }
    public void substraction(int a, int b)
    {
        Console.WriteLine("out substraction {0}", a - b);
    }
}
partial class clscalculation
{
    public void multiplication(int a, int b)
    {
        Console.WriteLine("out multiplication", a * b);
    }
    public void Division(int a, int b)
    {
        Console.WriteLine("out Division is {0}", a / b);
    }
}
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {

            clscalculation objcal = new clscalculation();
            objcal.addition ( 8, 2);
            objcal.substraction ( 8, 2);
            objcal.multiplication (8, 2);
            objcal.Division( 8, 2);
            Console.Read();
        }
    }
    partial class clscalculation
    {
        public void addition(int a, int b)
        {
            Console.WriteLine(" output is = {0}", a + b);
        }
        public void substraction(int a, int b)
        {
            Console.WriteLine(" output is = {0}", a - b);
        }
        public void multiplication(int a, int b)
        {
            Console.WriteLine(" output is = {0}", a * b);
        }
        public void Division(int a, int b)
        {
            Console.WriteLine(" output is = {0}", a / b);
        }
    }
}
