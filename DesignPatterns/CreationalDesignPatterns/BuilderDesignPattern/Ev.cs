using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern
{
	public class Ev
	{
		private string il;
		private string ilce;
		private string mahalle;

		private int binaYili;
		private int balkonSayisi;
		private int odaSayisi;
		private int banyoSayisi;
		private int tuvaletSayisi;

		private bool _isDublex;
		private bool _isEsyali;
		private bool hasOtopark;
		private bool hasCocukParki;
		private bool hasKlima;
		private bool hasHavuz;
		public Ev()
		{
		}

		public Ev(string il, string ilce, string mahalle, int binaYili, int balkonSayisi, int odaSayisi, int banyoSayisi, int tuvaletSayisi, bool isDublex, bool isEsyali, bool hasOtopark, bool hasCocukParki, bool hasKlima, bool hasHavuz)
		{
			this.il = il;
			this.ilce = ilce;
			this.mahalle = mahalle;
			this.binaYili = binaYili;
			this.balkonSayisi = balkonSayisi;
			this.odaSayisi = odaSayisi;
			this.banyoSayisi = banyoSayisi;
			this.tuvaletSayisi = tuvaletSayisi;
			this._isDublex = isDublex;
			this._isEsyali = isEsyali;
			this.hasOtopark = hasOtopark;
			this.hasCocukParki = hasCocukParki;
			this.hasKlima = hasKlima;
			this.hasHavuz = hasHavuz;
		}

		public override string ToString()
		{
			return "Ev{" +
			   "il='" + il + '\'' +
			   ", ilce='" + ilce + '\'' +
			   ", mahalle='" + mahalle + '\'' +
			   ", binaYili=" + binaYili +
			   ", balkonSayisi=" + balkonSayisi +
			   ", odaSayisi=" + odaSayisi +
			   ", banyoSayisi=" + banyoSayisi +
			   ", tuvaletSayisi=" + tuvaletSayisi +
			   ", isDublex=" + _isDublex +
			   ", isEsyali=" + _isEsyali +
			   ", hasOtopark=" + hasOtopark +
			   ", hasCocukParki=" + hasCocukParki +
			   ", hasKlima=" + hasKlima +
			   ", hasHavuz=" + hasHavuz +
			   '}';
		}

		public String getIl()
		{
			return il;
		}

		public void setIl(String il)
		{
			this.il = il;
		}

		public String getIlce()
		{
			return ilce;
		}

		public void setIlce(String ilce)
		{
			this.ilce = ilce;
		}

		public String getMahalle()
		{
			return mahalle;
		}

		public void setMahalle(String mahalle)
		{
			this.mahalle = mahalle;
		}

		public int getBinaYili()
		{
			return binaYili;
		}

		public void setBinaYili(int binaYili)
		{
			this.binaYili = binaYili;
		}

		public int getBalkonSayisi()
		{
			return balkonSayisi;
		}

		public void setBalkonSayisi(int balkonSayisi)
		{
			this.balkonSayisi = balkonSayisi;
		}

		public int getOdaSayisi()
		{
			return odaSayisi;
		}

		public void setOdaSayisi(int odaSayisi)
		{
			this.odaSayisi = odaSayisi;
		}

		public int getBanyoSayisi()
		{
			return banyoSayisi;
		}

		public void setBanyoSayisi(int banyoSayisi)
		{
			this.banyoSayisi = banyoSayisi;
		}

		public int getTuvaletSayisi()
		{
			return tuvaletSayisi;
		}

		public void setTuvaletSayisi(int tuvaletSayisi)
		{
			this.tuvaletSayisi = tuvaletSayisi;
		}

		public bool isDublex()
		{
			return _isDublex;
		}

		public void setDublex(bool dublex)
		{
			_isDublex = dublex;
		}

		public bool isEsyali()
		{
			return _isEsyali;
		}

		public void setEsyali(bool esyali)
		{
			_isEsyali = esyali;
		}

		public bool isHasOtopark()
		{
			return hasOtopark;
		}

		public void setHasOtopark(bool hasOtopark)
		{
			this.hasOtopark = hasOtopark;
		}

		public bool isHasCocukParki()
		{
			return hasCocukParki;
		}

		public void setHasCocukParki(bool hasCocukParki)
		{
			this.hasCocukParki = hasCocukParki;
		}

		public bool isHasKlima()
		{
			return hasKlima;
		}

		public void setHasKlima(bool hasKlima)
		{
			this.hasKlima = hasKlima;
		}

		public bool isHasHavuz()
		{
			return hasHavuz;
		}

		public void setHasHavuz(bool hasHavuz)
		{
			this.hasHavuz = hasHavuz;
		}
	}
}
