using System;

public class Program
{
	public static void Main()
	{
		int num = 0;
		int.TryParse(Console.ReadLine(), out num);
		num = (int)Math.Pow(num, 2);
		int index = 1;
		int x = 0;
		string result = "\n";
		bool changeDir = false;
		for (int i = 1; i <= num; i++)
		{
			result += i.ToString() + " ";
			x++;
			if (x >= index)
			{
				x = 0;
				if (index >= Math.Sqrt(num))
				{
					changeDir = true;
				}
				if (changeDir) index--;
				else index++;
				result += "\n";
			}
		}

		Console.WriteLine(result);
	}
}