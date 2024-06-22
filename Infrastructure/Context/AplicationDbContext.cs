using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly string? _connectionString;

        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Regions> Regions { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetSection("DbContextSettings").GetSection("ConnectionString").Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Entity<Regions>().HasData(
                new { Ddd = 11, RegionName = "São Paulo – SP" },
                new { Ddd = 12, RegionName = "São José dos Campos – SP" },
                new { Ddd = 13, RegionName = "Santos – SP" },
                new { Ddd = 14, RegionName = "Bauru – SP" },
                new { Ddd = 15, RegionName = "Sorocaba – SP" },
                new { Ddd = 16, RegionName = "Ribeirão Preto – SP" },
                new { Ddd = 17, RegionName = "São José do Rio Preto – SP" },
                new { Ddd = 18, RegionName = "Presidente Prudente – SP" },
                new { Ddd = 19, RegionName = "Campinas – SP" },
                new { Ddd = 21, RegionName = "Rio de Janeiro – RJ" },
                new { Ddd = 22, RegionName = "Campos dos Goytacazes – RJ" },
                new { Ddd = 24, RegionName = "Volta Redonda – RJ" },
                new { Ddd = 27, RegionName = "Vitória / Vila Velha – ES" },
                new { Ddd = 28, RegionName = "Cachoeiro de Itapemirim – ES" },
                new { Ddd = 31, RegionName = "Belo Horizonte – MG" },
                new { Ddd = 32, RegionName = "Juiz de Fora – MG" },
                new { Ddd = 33, RegionName = "Governador Valadares – MG" },
                new { Ddd = 34, RegionName = "Uberlândia – MG" },
                new { Ddd = 35, RegionName = "Poços de Caldas – MG" },
                new { Ddd = 37, RegionName = "Divinópolis – MG" },
                new { Ddd = 38, RegionName = "Montes Claros – MG" },
                new { Ddd = 41, RegionName = "Curitiba – PR" },
                new { Ddd = 42, RegionName = "Ponta Grossa – PR" },
                new { Ddd = 43, RegionName = "Londrina – PR" },
                new { Ddd = 44, RegionName = "Maringá – PR" },
                new { Ddd = 45, RegionName = "Foz do Iguaçú – PR" },
                new { Ddd = 46, RegionName = "Pato Branco / Francisco Beltrão – PR" },
                new { Ddd = 47, RegionName = "Joinville – SC" },
                new { Ddd = 48, RegionName = "Florianópolis – SC" },
                new { Ddd = 49, RegionName = "Chapecó – SC" },
                new { Ddd = 51, RegionName = "Porto Alegre – RS" },
                new { Ddd = 53, RegionName = "Pelotas – RS" },
                new { Ddd = 54, RegionName = "Caxias do Sul – RS" },
                new { Ddd = 55, RegionName = "Santa Maria – RS" },
                new { Ddd = 61, RegionName = "Brasília – DF" },
                new { Ddd = 62, RegionName = "Goiânia – GO" },
                new { Ddd = 63, RegionName = "Palmas – TO" },
                new { Ddd = 64, RegionName = "Rio Verde – GO" },
                new { Ddd = 65, RegionName = "Cuiabá – MT" },
                new { Ddd = 66, RegionName = "Rondonópolis – MT" },
                new { Ddd = 67, RegionName = "Campo Grande – MS" },
                new { Ddd = 68, RegionName = "Rio Branco – AC" },
                new { Ddd = 69, RegionName = "Porto Velho – RO" },
                new { Ddd = 71, RegionName = "Salvador – BA" },
                new { Ddd = 73, RegionName = "Ilhéus – BA" },
                new { Ddd = 74, RegionName = "Juazeiro – BA" },
                new { Ddd = 75, RegionName = "Feira de Santana – BA" },
                new { Ddd = 77, RegionName = "Barreiras – BA" },
                new { Ddd = 79, RegionName = "Aracaju – SE" },
                new { Ddd = 81, RegionName = "Recife – PE" },
                new { Ddd = 82, RegionName = "Maceió – AL" },
                new { Ddd = 83, RegionName = "João Pessoa – PB" },
                new { Ddd = 84, RegionName = "Natal – RN" },
                new { Ddd = 85, RegionName = "Fortaleza – CE" },
                new { Ddd = 86, RegionName = "Teresina – PI" },
                new { Ddd = 87, RegionName = "Petrolina – PE" },
                new { Ddd = 88, RegionName = "Juazeiro do Norte – CE" },
                new { Ddd = 89, RegionName = "Picos – PI" },
                new { Ddd = 91, RegionName = "Belém – PA" },
                new { Ddd = 92, RegionName = "Manaus – AM" },
                new { Ddd = 93, RegionName = "Santarém – PA" },
                new { Ddd = 94, RegionName = "Marabá – PA" },
                new { Ddd = 95, RegionName = "Boa Vista – RR" },
                new { Ddd = 96, RegionName = "Macapá – AP" },
                new { Ddd = 97, RegionName = "Coari – AM" },
                new { Ddd = 98, RegionName = "São Luís – MA" },
                new { Ddd = 99, RegionName = "Imperatriz – MA" }
                );
        }
    }
}
