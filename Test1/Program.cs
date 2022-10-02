// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

 string Arr(int n)
        {
            if (n == 1) return "1";
            else
            return n + Arr(n - 1) ;
        }
                    
 Console.WriteLine(String.Join("," , (Arr(8))));
        