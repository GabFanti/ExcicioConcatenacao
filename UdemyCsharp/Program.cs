﻿using System;
using System.Globalization;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é " + preco1.ToString("F2") );
            Console.WriteLine(produto2 + ", cujo o preço é " + preco2.ToString("F2") );
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, código: " + codigo + " e genero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casa decimais " + preco3.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais) " + preco3.ToString("F3"));
            Console.WriteLine("Separador decimal Invariant culture "+ preco3.ToString("F3", CultureInfo.InvariantCulture) );
        }
    }
}
