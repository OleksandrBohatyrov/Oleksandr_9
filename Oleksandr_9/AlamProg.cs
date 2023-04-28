using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oleksandr_9
{
    public class AlamProg
    {

        
        public static void Matrica()
        {

            Random rnd = new Random();

            int[,] matrica = new int[10, 10]; //создаю двумерный массив

            for (int i = 0; i < matrica.GetLength(0); i++) //рандом 
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    matrica[i, j] = rnd.Next(1, 11);
                }
            }

            for (int i = 0; i < matrica.GetLength(0); i++) // вывожу массив в консоль
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0; //делаю переменную для суммы
            double korrutamine = 1; //для произведения

            for (int i = 0; i < 10; i++) //сумма и произведения всех чисел
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += matrica[i, j];
                    korrutamine *= matrica[i, j];
                    Console.WriteLine(korrutamine);
                }
            }

            Console.WriteLine("Summa: {0}\nKorrutamine: {1}\n", sum, korrutamine);



        }

        public static void Treugolniki()
        {

            // Создаю стороны треугольников
            double a1 = 1, b1 = 2, c1 = 2; //сумма двух сторон должна быть всегда больше третьей
            double a2 = 5, b2 = 7, c2 = 8;
            double a3 = 10, b3 =11, c3 = 13;

            // Сравнение периметров треугольников. P = a + b +c
            double p1 = a1 + b1 + c1;
            double p2 = a2 + b2 + c2;
            double p3 = a3 + b3 + c3;
            double maxPerimeter = Math.Max(Math.Max(p1, p2), p3); //Находим наибольшое значение периметра. Так как Math.Max сравнивает только 2 значения, мы сначала сравниваем первые 2 периметра, а потом наибольший с третьим

            if (maxPerimeter == p1)
            {
                Console.WriteLine("Kolmnurk 1 on suurim perimeeter: {0}", maxPerimeter);
            }
            else if (maxPerimeter == p2)
            {

                Console.WriteLine("Kolmnurk 2 on suurim perimeeter: {0}", maxPerimeter);
            }
            else
            {
                Console.WriteLine("Kolmnurk 3 on suurim perimeeter: {0}", maxPerimeter);
            }

            // Сравнение площадей треугольников
            double s1 = (a1 + b1 + c1) / 2; // находим полупериметр
            double s2 = (a2 + b2 + c2) / 2;
            double s3 = (a3 + b3 + c3) / 2;
            double S1 = Math.Sqrt(s1 * (s1 - a1) * (s1 - b1) * (s1 - c1)); //по формуле находим площадь 
            double S2 = Math.Sqrt(s2 * (s2 - a2) * (s2 - b2) * (s2 - c2));
            double S3 = Math.Sqrt(s3 * (s3 - a3) * (s3 - b3) * (s3 - c3));
            double maxArea = Math.Max(Math.Max(S1, S2), S3); // находим наибольшую площадь

            if (maxArea == S1)
            {
                Console.WriteLine("Kolmnurk 1 on suurim pindala: {0}", maxArea);
            }
            else if (maxArea == S2)
            {
                Console.WriteLine("Kolmnurk 2 on suurim pindala:: {0}", maxArea);
            }
            else
            {
                Console.WriteLine("Kolmnurk 3 on suurim pindala: {0}", maxArea);
            }

        }

        public static void Perekonanimi()
        {

            List<string> perekonanimi = new List<string>();

            // Добавляю в список фамилии
            perekonanimi.Add("Bohatyrov");
            perekonanimi.Add("Kemppi");
            perekonanimi.Add("Yekasov");
            perekonanimi.Add("Tsepelevits");
            perekonanimi.Add("Kulakovski");

            // Сотрировка по алфавиту
            perekonanimi.Sort();

            // Вывожу в консоль
            Console.WriteLine("Perekonnanimede nimekiri: ");
            foreach (string a in perekonanimi)
            {
                Console.WriteLine(a);
            }

         


        }



    }

}

