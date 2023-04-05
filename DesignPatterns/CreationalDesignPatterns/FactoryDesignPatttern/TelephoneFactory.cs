using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPatttern
{
	public class TelephoneFactory
	{
		public static Telephone GetTelephone(string model, string battery, int en, int boy)
		{
			Telephone telephone;
			if ("S8".Equals(model))
			{
				telephone = new S8(model, battery, en, boy);	
			}else if("Note8".Equals(model))
			{
				telephone = new Note8(model, battery, en, boy);
			}
			else
			{
				throw new Exception("It is not a valid model.");
			}

			return telephone;
		}
	}
}
