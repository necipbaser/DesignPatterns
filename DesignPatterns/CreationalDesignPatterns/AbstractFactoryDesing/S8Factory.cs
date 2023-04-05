using DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesing
{
	internal class S8Factory : ITelephoneFactory
	{
		public Telephone GetTelephone(string model, string battery, int width, int height)
		{
			return new S8(model, battery, width, height);
		}
	}
}
