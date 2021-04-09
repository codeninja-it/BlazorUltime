using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUltime.Pages
{
	/// <summary>
	/// Classe descrittiva per l'elemento di banca dati Nota
	/// </summary>
	public class Nota
	{
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
	}
}
