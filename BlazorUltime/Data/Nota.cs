using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUltime.Data
{
	/// <summary>
	/// Classe descrittiva per l'elemento di banca dati Nota
	/// </summary>
	public class Nota
	{
		public int ID { get; set; }
		/// <summary>
		/// titolo della nota in formato string
		/// </summary>
		public string Titolo { get; set; }
		/// <summary>
		/// corpo della nota in formato string
		/// </summary>
		public string Corpo { get; set; }
		/// <summary>
		/// Giorno ed ora di creazione della nostra nota
		/// </summary>
		public DateTime Quando { get; set; }
		/// <summary>
		/// colore espresso in esadecimale
		/// </summary>
		public String Colore { get; set; }
	}
}
