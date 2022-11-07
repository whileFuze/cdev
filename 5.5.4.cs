using System;


class Class1
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.WriteLine("Напишите что-то");
		var str = Console.ReadLine();

		Console.WriteLine("Укажите глубину эха");
		var deep = int.Parse(Console.ReadLine());

		Echo(str, deep);

		Console.ReadKey();
	}

	static void Echo(string saidword, int deep)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		string modif = saidword;

		
		if (modif.Length > 2) modif = modif.Remove(0, 2);
		Console.BackgroundColor = (ConsoleColor)deep;
		Console.WriteLine("..." + modif);
		if (deep > 1)
		{
			Echo(saidword, deep - 1);
		}
	}
}
