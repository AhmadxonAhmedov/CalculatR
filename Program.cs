
Console.WriteLine("Tub sonlarni aniqlovchi loyixa: "); // TUB SON => o`ziga va birga bo`linuvchi son

            Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();
    int userNumber = Convert.ToInt32(userInput);

      for (int i = 2; i < userNumber; i++ )
         {
           int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                 if(i % j == 0) 
                {
                     sum++;
                }
                }
                if(sum == 2)
                {
                    Console.WriteLine(i);
                }
            }