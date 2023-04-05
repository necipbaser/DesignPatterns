using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPatttern
{
	public interface Telephone
	{
		string GetModel();
		string GetBattery();
		int GetWidth();
		int GetHeight();
	}
}
