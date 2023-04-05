using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPatttern
{
	public class Note8 : Telephone
	{
		public Note8(string model, string battery, int width, int height)
		{
			Model = model;
			Battery = battery;
			Width = width;
			Height = height;
		}

		private string Model { get; set; }
		private string Battery { get; set; }
		private int Width { get; set; }
		private int Height { get; set; }

		public string GetBattery()
		{
			return Battery;
		}

		public int GetHeight()
		{
			return Height;
		}

		public string GetModel()
		{
			return Model;
		}

		public int GetWidth()
		{
			return Width;
		}

		public override string ToString()
		{
			return "Node8: " + "Model=" + Model + " Battery=" + Battery + " Width=" + Width + " Height=" + Height;
		}
	}
}
