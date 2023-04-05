using DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesing
{
	public interface ITelephoneFactory
	{
		Telephone GetTelephone(string model, string battery, int width, int height);
	}
}
