        Console.WriteLine("Введите номер одной из 3 домашних");

          int Domaha = Convert.ToInt32(Console.ReadLine());
            switch (Domaha) {
            case 1:
                Console.WriteLine("Введите день недели как цыфру: ");

              int denb = int.Parse(Console.ReadLine()); 
                if (denb >= 1 && denb <= 5) 
                { 
                    Console.Write(" Не выходной"); 
                } 
 
                else if (denb >= 6 && denb <= 7) 
                { 
                    Console.Write(" Выходной день"); 
                } 
                else Console.Write(" Не существует такого дня недели");
                break;
                //
                case 2:
                Console.WriteLine("Введите любое трехзначное число: ");

                var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));

                while (n >= 100)
        {
                n /= 10;
        }

          var r = n % 10;
          Console.WriteLine("Второе число: " + r);
          break;
          
          case 3:
          Console.WriteLine("Введите трехзначное число: ");
          int chislo = Convert.ToInt32(Console.ReadLine());
          if (chislo > 99 && chislo < 1000)
          {
            Console.WriteLine(chislo % 10);
          }
          else {
            Console.WriteLine("Не трехзначное число!");
          }
          break;
   
   }