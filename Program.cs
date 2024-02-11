Console.WriteLine("Welcome to Simple calculator");
bool isContinued = true;
while (isContinued)
{
    Console.WriteLine("1 - Simple operation");
    Console.WriteLine("2 - Tricky operation");
    Console.WriteLine("3 - To see prime numbers till the given number");
    Console.WriteLine("4 - To see three prime numbers after the given numbers in the sequence");
    Console.WriteLine("5 - To see fibonacci numbers till the given number");
    Console.WriteLine("Write anything else to exit");
    Console.Write("Choose : ");
    bool isPrime = false;
    string inputNumber;
    int number;
    string inputChoice = Console.ReadLine();
    switch (inputChoice)
    {
        case "1":
            Console.Write("Write operation : ");
            string inputOperation = Console.ReadLine();
            int firstNumber;
            int secondNumber;

            if (inputOperation.Contains('+'))
            {
                firstNumber = Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('+')));
                secondNumber = Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('+')+1));
                Console.WriteLine($"Result : {firstNumber + secondNumber}");
            }
            if (inputOperation.Contains('-'))
            {
                firstNumber = Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('-')));
                secondNumber = Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('-')+1));
                Console.WriteLine($"Result : {firstNumber - secondNumber}");
            }
            if (inputOperation.Contains('*'))
            {
                firstNumber = Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('*')));
                secondNumber = Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('*')+1));
                Console.WriteLine($"Result : {firstNumber * secondNumber}");
            }
            if (inputOperation.Contains('/'))
            {
                firstNumber = Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('/')));
                secondNumber = Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('/')+1));
                Console.WriteLine($"Result : {firstNumber / secondNumber}");
            }
            if (inputOperation.Contains('^'))
            {
                firstNumber = Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('^')));
                secondNumber = Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('^')+1));
                Console.WriteLine($"Result : {Math.Pow(firstNumber,secondNumber)}");
            }
            if (!inputOperation.Contains('+') && !inputOperation.Contains('-')&&!inputOperation.Contains('*')&&!inputOperation.Contains('/')&&!inputOperation.Contains('^'))
            {
                Console.WriteLine("Invalid operation");
            }
        break;
        case "2":
            Console.Write("Enter angle for its trigonemetric value : alfa = ");
            string inputAngle = Console.ReadLine();
            int angle = Convert.ToInt32(inputAngle);
            Console.WriteLine($"sin(alfa) = {Math.Asin(angle)}");
            Console.WriteLine($"cos(alfa) = {Math.Acos(angle)}");
            Console.WriteLine($"tan(alfa) = {Math.Atan(angle)}");
            Console.WriteLine($"ctan(alfa) = {1/Math.Atan(angle)}");
        break;
        case  "3":
            Console.Write("Enter the number : ");
            inputNumber = Console.ReadLine();
            number = Convert.ToInt32(inputNumber);
            Console.Write("Prime numbers : 2");
            for(int i=2; i<=number; i++){
                for(int j=2; j<=Math.Sqrt(i); j++)
                {
                    if(i%j==0){
                        isPrime=false;
                        break;
                    }
                }

                if(isPrime)
                {
                    Console.Write(" "+i);
                }
            
                isPrime=true;
            }
            Console.WriteLine();
        break;
        case "4":
            Console.Write("Enter the number : ");
            string inputNumberFibonacci = Console.ReadLine();
            int numberFibonacci = Convert.ToInt32(inputNumberFibonacci);
            int firstNumberFibo = 0;
            int secondNumberFibo = 1;
            int fibo = 0;
            Console.Write("Fibonacci numbers : ");
            for (int i = 2; i < numberFibonacci; i++)
            {
                fibo = firstNumberFibo + secondNumberFibo;
                Console.Write(" "+ fibo);
                firstNumberFibo = secondNumberFibo;
                secondNumber = fibo;
            }
            Console.WriteLine();
        break;
        case "5":
            Console.Write("Enter the number : ");
            inputNumber = Console.ReadLine();
            number = Convert.ToInt32(inputNumber);
            Console.Write("Prime numbers : 2");
            while (true)
            {
                
            }
            Console.WriteLine();
        break;
        default:
            Console.WriteLine("Bye....");
            isContinued = false;
        break;
    }
}

