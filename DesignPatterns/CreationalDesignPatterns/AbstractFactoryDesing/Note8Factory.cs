using DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesing
{
	public class Note8Factory : ITelephoneFactory
	{	
	
		public Telephone GetTelephone(string model, string battery, int width, int height)
		{
			return new Note8(model, battery, width, height);
		}
	}
}
