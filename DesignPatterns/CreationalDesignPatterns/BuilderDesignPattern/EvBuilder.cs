using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.BuilderDesignPattern
{
	public class EvBuilder
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

		public static EvBuilder StartBuild(string il,string ilce, string mahalle)
		{
			var evBuilder = new EvBuilder();
			evBuilder.setIl(il);
			evBuilder.setIlce(ilce);
			evBuilder.setMahalle(mahalle);
			return evBuilder;
		}

		public Ev Build()
		{
			Ev ev = new Ev();
			//ev.setIl(il);
			//ev.setIlce(ilce);
			//ev.setMahalle(mahalle);
			ev.setBinaYili(binaYili);
			ev.setBalkonSayisi(balkonSayisi);
			ev.setOdaSayisi(odaSayisi);
			ev.setBalkonSayisi(balkonSayisi);
			ev.setTuvaletSayisi(tuvaletSayisi);
			ev.setDublex(_isDublex);
			ev.setEsyali(_isEsyali);
			ev.setHasOtopark(hasOtopark);
			ev.setHasCocukParki(hasCocukParki);
			ev.setHasKlima(hasKlima);
			ev.setHasHavuz(hasHavuz);
			return ev;
		}

		public EvBuilder setIl(String il)
		{
			this.il = il;
			return this;
		}


		public EvBuilder setIlce(String ilce)
		{
			this.ilce = ilce;
			return this;
		}


		public EvBuilder setMahalle(String mahalle)
		{
			this.mahalle = mahalle;
			return this;
		}


		public EvBuilder setBinaYili(int binaYili)
		{
			this.binaYili = binaYili;
			return this;
		}


		public EvBuilder setBalkonSayisi(int balkonSayisi)
		{
			this.balkonSayisi = balkonSayisi;
			return this;
		}


		public EvBuilder setOdaSayisi(int odaSayisi)
		{
			this.odaSayisi = odaSayisi;
			return this;
		}


		public EvBuilder setBanyoSayisi(int banyoSayisi)
		{
			this.banyoSayisi = banyoSayisi;
			return this;
		}

		public EvBuilder setTuvaletSayisi(int tuvaletSayisi)
		{
			this.tuvaletSayisi = tuvaletSayisi;
			return this;
		}

		public EvBuilder setDublex(bool dublex)
		{
			_isDublex = dublex;
			return this;
		}


		public EvBuilder setEsyali(bool esyali)
		{
			_isEsyali = esyali;
			return this;
		}


		public EvBuilder setHasOtopark(bool hasOtopark)
		{
			this.hasOtopark = hasOtopark;
			return this;
		}


		public EvBuilder setHasCocukParki(bool hasCocukParki)
		{
			this.hasCocukParki = hasCocukParki;
			return this;
		}

		public EvBuilder setHasKlima(bool hasKlima)
		{
			this.hasKlima = hasKlima;
			return this;
		}

		public EvBuilder setHasHavuz(bool hasHavuz)
		{
			this.hasHavuz = hasHavuz;
			return this;
		}
	}
}
