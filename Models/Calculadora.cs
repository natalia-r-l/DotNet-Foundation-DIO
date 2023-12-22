using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Foundation_DIO.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"Soma: {x} + {y} = {x + y}");
        }

         public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x} - {y} = {x - y}");
        }

         public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Multiplicar: {x} x {y} = {x * y}");
        }

         public void Dividir(int x, int y)
        {
            Console.WriteLine($"Dividir: {x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"Potência: {x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Consseno de {angulo} = {Math.Round(coseno, 4)}");
        }

          public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Cos(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}