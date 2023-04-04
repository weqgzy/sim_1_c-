Main();

void Main()
{
	bool isWorking = true;

	while (isWorking)
	{
		Console.WriteLine("Input task");

		string task = Console.ReadLine();

		switch (task)
		{
			case "exit": isWorking = false; break;
			case "start": Task1(); break;
			default:
				break;
		}
	}
}

void Task1()
{
	
	int a = ReadInt("a");
	int less = a;
	if (a == 0)
	{
 do
 {
    Console.WriteLine(a);
    a = a+2;
 } while (a < 8);
 System.Console.WriteLine("четные числа до 8"); 
    }

  if (a == 1)
  { 
  System.Console.WriteLine(2);
  System.Console.WriteLine(2 + 2);
  System.Console.WriteLine("четные числа до 5");
  }

}
int ReadInt(string argument)
{
    int number;

	Console.Write($"Input {argument}:") ;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("It's not a number!");
	}

	return number;

}
