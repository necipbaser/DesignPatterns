using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns
{
	public class SingletonDesignPattern
	{
		private static readonly object Instancelock = new object();

		//eager loading
		//private static SingletonDesignPattern singleton = new SingletonDesignPattern();

		//lazy loading
		private static SingletonDesignPattern singleton;
		private static int count = 0;
		private SingletonDesignPattern()
		{
			Console.WriteLine($"created {count}");
		}

		public static SingletonDesignPattern getSingleton()
		{
			//double checked locking
			if (singleton == null)
			{
				//threadsafe control
				lock (Instancelock)
				{
					if (singleton == null)
					{
						singleton = new SingletonDesignPattern();
					}
				}
			}
			count++;
			return singleton;
		}
	}
}