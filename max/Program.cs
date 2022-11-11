//* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большtе, а какое меньшее. a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

 Console.WriteLine("максимальное значение для двух целых чисел");
            Console.Write("Введите первое число ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            double b = Convert.ToInt32(Console.ReadLine());
           double max;
           if (a > b)
           {
               max = a;
               
           }
           else
           {
               max = b;
           }
           Console.WriteLine("макс число :{0}", max);
           