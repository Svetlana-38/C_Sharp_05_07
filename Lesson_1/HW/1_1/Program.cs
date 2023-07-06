
        //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Введите два числа: ");

        int a = int.Parse(Console.ReadLine()!);

        int b = int.Parse(Console.ReadLine()!);

        if (a > b)
        {
            Console.WriteLine(" {0} - наибольшее число ", a);
            Console.WriteLine(" {0} - наименьшее число ", b);
        }
        else {
              if (a < b)
        {
            Console.WriteLine(" {0} - наибольшее число ", b);
            Console.WriteLine(" {0} - наименьшее число ", a);
        }
               else
             {
            Console.WriteLine(" Они равны ");
           }

        }
