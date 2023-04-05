// See https://aka.ms/new-console-template for more information


using DesignPatterns.CreationalDesignPatterns;

internal class Program
{
	public static void Main(string[] args)
	{
		//singleton
		//SingletonDesignPattern singleton = SingletonDesignPattern.getSingleton();

		for (int i = 0; i < 10; i++)
		{
			SingletonDesignPattern singleton = SingletonDesignPattern.getSingleton();
		}
	}
}