using System;
					
public class Program
{
	public static void Main()
	{
		int num = 0;
		int.TryParse(Console.ReadLine(), out num);
		
		string result = "\n";
		for (int i = 1; i <= num; i++)
		{
			int n = (int) Math.Pow(i, 2);
			for (int x = 0; x < 4; x++)
			{
				result += (n + (x * i)).ToString() + " ";
			}
			result += "\n";
		}
		Console.WriteLine(result);
	}
}