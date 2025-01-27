﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa, altura, imc;
            string diagnostico;

            Console.WriteLine("-- Calculadora de IMC --\n");

            Console.Write("Digite seu peso em kg...: ");
            massa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em m..: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = massa / Math.Pow(altura, 2);

            Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");

            if (imc < 17)
            {
                diagnostico = "Muito abaixo do peso";
            }
            else if (imc < 18.5)
            {
                diagnostico = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                diagnostico = "Peso normal";
            }
            else if (imc < 30)
            {
                diagnostico = "Acima do peso";
            }
            else if (imc < 35)
            {
                diagnostico = "Obesidade I";
            }
            else if (imc < 40)
            {
                diagnostico = "Obesidade II (severa)";
            }
            else
            {
                diagnostico = "Obesidade III (mórbida)";
            }

            Console.WriteLine($"Diagnóstico: {diagnostico}");
        }
    }
}
