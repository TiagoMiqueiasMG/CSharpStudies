﻿using System;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime é um structs
            // Sempre que criar um DateTime, ele semre vai ter um valor
            // var data = DateTime.Now;
            
            
            // Para criar uma data 
            // Usando uma sobrecarda de método
            // Aqui vamos criar uma data com ano, mes. dia, hora, 
            // minutos e segundos
            var data = new DateTime(2020, 10, 12, 8, 23, 14);
            Console.WriteLine(data);

            // Podendo obter as datas separadas 
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);

            // Para saber o dia da semana
            // Vai exibir que dia da semana é referente a data
            Console.WriteLine(data.DayOfWeek);

            // Podendo ser convertido para int
            Console.WriteLine((int)data.DayOfWeek);

            //Para saber qual dia do ano é
            Console.WriteLine(data.DayOfYear);

            // Formantando data
            var dataNova = DateTime.Now;
            // Podendo alterar a posição do dia, mês e ano
            // E colocar outros caracteres no lugar da barra
            // Como * - ...
            var formatada = string.Format("{0:dd/MM/yyyy}", dataNova);
            
            // Formatando com horas, minutos e segundos: 
            var formatDataHora = string.Format("{0:dd/MM/yyyy hh:mm:ss}", dataNova);
            Console.WriteLine(formatada);
            Console.WriteLine(formatDataHora);

            // z = timezone ( Aonde que essa hora está sendo baseada)
            // Relacionado aos meridionais
            var formatDataHora2 = string.Format("{0:dd/MM/yyyy hh:mm:ss z}", dataNova);
            Console.WriteLine(formatDataHora2);
        }
    }
}