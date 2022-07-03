using APICore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;


namespace APICore.DataLayer
{
    public class PrizeDbContext:DbContext
    {
        public PrizeDbContext(DbContextOptions<PrizeDbContext>options):base(options)
        {

        }

        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Laureate> Laureates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Prize>(entity =>
            {
                entity.HasIndex(e => e.prizeID);
                entity.Property(e => e.year);
                entity.Property(e => e.category);

            });
            modelBuilder.Entity<Laureate>(entity =>
            {

                entity.Property(e => e.id);
                entity.Property(e => e.firstname);
                entity.Property(e => e.surname);
                entity.Property(e => e.motivation);
                entity.Property(e => e.share);

            });

        }
        protected override void Seed(PrizeDbContext context)
        { 
            Prize data = JsonConvert.DeserializeObject<Prize>(File.ReadAllText(@"C:\Users\DELL\source\repos\EFCoreWebAPI\VeiwModel\prize.json"));
            IList<Prize> prizes = new List<Prize>();
            foreach (Prize item in prizes)
            context.Prizes.Add(item);
            base.Seed(context);	 
        }

    }
}
