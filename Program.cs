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
	int b = ReadInt("b");
    int c = ReadInt("c");
	int less = a;

	if (isWorking(a , b , c))
      if (a == 4)
      
	{
		less = a;
        Console.Write("четное - ");
	}

    else
    {
        Console.WriteLine("нечетное число,введите четное число в ячейку ");
    }

	Console.WriteLine(less);
    
      
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

bool isWorking(int a, int b,int c)
{
	return a > b;

}

