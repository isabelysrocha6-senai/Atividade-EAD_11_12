// ...existing code...
using System;
using System.Collections.Generic;

namespace Atividade_11_12
{
    class Program
    {
        static void Main()
        {
            var materias = new List<Materia>
            {
                new Materia { Nome = "Matemática", Nota = 9.5 },
                new Materia { Nome = "Português", Nota = 8.7 },
                new Materia { Nome = "Física", Nota = 9.8 },
            };

            double soma = 0;
            double maiorNota = double.MinValue;
            Materia materiaMaior = null;

            foreach (var m in materias)
            {
                soma += m.Nota;
                if (m.Nota > maiorNota)
                {
                    maiorNota = m.Nota;
                    materiaMaior = m;
                }
            }

            Console.WriteLine();
            if (materiaMaior != null)
                Console.WriteLine($"Maior nota entre todas as matérias: {maiorNota} ({materiaMaior.Nome})");
            else
                Console.WriteLine("Nenhuma matéria informada.");
        }
    }
}