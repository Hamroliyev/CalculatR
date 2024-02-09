Console.WriteLine("Welcome to Simple calculator");
Console.WriteLine("1 - Simple operation");
Console.WriteLine("2 - Tricky operation");
Console.Write("Choose : ");
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
    default:
        Console.WriteLine("Bye....");
    break;
}

