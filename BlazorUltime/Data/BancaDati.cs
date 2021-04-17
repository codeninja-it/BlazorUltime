using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUltime.Data
{
	public class BancaDati : DbContext
	{
		public DbSet<Nota> note { get; set; }

		public DbSet<Reperto> reperti { get; set; }

		public BancaDati(DbContextOptions options) : base(options) { }
	}
}
