Console.WriteLine("Fibanaci raqamni aniqlaydigan loyixa: "); // 10 ning fibonacilari => 1, 2, 3, 5, 8
Console.Write("Enter a number: ");
            string userStrInput = Console.ReadLine();
            int userInput = Convert.ToInt32(userStrInput);
            int num1 = 0; int num2 = 1; int result = 0;
            for(int i = 0; i < userInput; i++)
            {
                result = num1 + num2; // result = 1;2;3;5;8;
                num1 = num2; //num1 = 1;2;3;5
                num2 = result;//1;2;3;5;8;
                if(result <= userInput)
                {
                    Console.WriteLine(result);
                }
            }