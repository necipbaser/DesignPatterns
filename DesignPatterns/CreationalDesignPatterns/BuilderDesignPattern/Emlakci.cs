using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern
{
	public static class Emlakci
	{
		public static void writeEv(Ev ev)
		{
            Console.WriteLine("*****************" + ev);
            Console.WriteLine("ev eklendi" + ev);
        }
	}
}
