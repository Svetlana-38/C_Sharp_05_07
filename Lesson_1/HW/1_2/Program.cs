//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 Console.WriteLine("Введите три числа: ");

        int a = int.Parse(Console.ReadLine()!);

        int b = int.Parse(Console.ReadLine()!);

        int c = int.Parse(Console.ReadLine()!);

        if (a > b)
        {Console.Max()
            Console.WriteLine(" {0} - наибольшее число ", a);
        }
        else {
              if (b > a > c) 
            Console.WriteLine(" {0} - наибольшее число ", b); 
        } 
      else {
        Console.WriteLine(" {0} - наибольшее число ", c);
    }      