// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

  
 int SumNumbers(int M, int N)
        {
            if (M == N) return M;                       
            if (M < N) return N + SumNumbers(M, N - 1); 
            else return N + SumNumbers(M, N + 1);        
        }
 Console.Write("M = ");
 int M = int.Parse(Console.ReadLine());
 Console.Write("N = ");
 int N = int.Parse(Console.ReadLine());
 Console.WriteLine($"{SumNumbers(M, N)}");
 Console.ReadLine();
        