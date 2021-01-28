﻿using System;

namespace _Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic se puede ver como una forma de System.Object
            //en el sentido de que cualquier valor se puede asignadar a dynamic
            //La diferencia es que no es fuertemente tipificado
            //Se le puede asignar cualquier tipo al inicio y posteriormente
            //asignar otro

            dynamic a = 5;
            Console.WriteLine("Tipo {0}, valor: {1}",a.GetType(),a);

            a = "Hola a todos";
            Console.WriteLine("Tipo {0}, valor: {1}",a.GetType(),a);

            //A diferencia de object, en dynamic se conoce el tipo hasta el
            //el tiempo de ejecucion
            //Dynamic se puede usar como tipo de retorno
            //No se puede usar en expresiones lambda o en metodos anonimos
            //Puede resultar util si nos comunicamos con bibliotecas COM
        }
    }
}
