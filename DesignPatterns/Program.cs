﻿// See https://aka.ms/new-console-template for more information


using DesignPatterns.CreationalDesignPatterns;
using DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesing;
using DesignPatterns.CreationalDesignPatterns.FactoryDesignPatttern;

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

		//Factory Desing Pattern
		Telephone s8 = TelephoneFactory.GetTelephone("S8","2600mah",12,18);
		Telephone note8 = TelephoneFactory.GetTelephone("Note8", "3000mah", 14, 22);

        Console.WriteLine(s8.ToString());
        Console.WriteLine(note8.ToString());

		//Abstract Desing Pattern
		S8Factory s8Factory = new S8Factory();
		var s8Phone = s8Factory.GetTelephone("S8", "2600mah", 12, 18);

		Note8Factory note8Factory = new Note8Factory();
		var note8Phone = note8Factory.GetTelephone("note8", "3000mah", 14, 20);
    }
}