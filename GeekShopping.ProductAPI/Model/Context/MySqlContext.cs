using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        // Populando a table com dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Product> productsList = new List<Product>
            {
                new Product
                {
                    Id = 3,
                    Name = "Camiseta You Shall Not Pass",
                    Description = "Foram essas as palavras que tornaram o mago cinza imortalizado, " +
                        "pegando toda a experiência da vitória para si, subindo de classe e virando o" +
                        " poderoso mago branco. Enfrentar um chefe de alto nível sozinho pode te render um desafio mortal," +
                        " mas a vitória te faz ficar alguns níveis a frente de seu grupo.",
                    Price = new decimal(50.00),
                    CategoryName = "camisetas",
                    ImageUrl = "https://cdn.nerdstore.com.br/wp-content/uploads/2021/03/camiseta-you-shall-not-pass-01.jpg",
                    CreatedAt = DateTime.Now,
                },
                new Product
                {
                    Id = 4,
                    Name = "Camiseta Árvore de Gondor – Black Edition",
                    Description = "A Árvore de Gondor representa a paz e prosperidade dos Homens, as estrelas se referem aos " +
                        "sete barcos dos Homens de Númenor que traziam as Palantír, cada um com o desenho de uma estrela." +
                        "Sua estampa favorita,  agora na sua versão black edition, em uma super camiseta pronta para desbravar a Terra Média!",
                    Price = new decimal(79.90),
                    CategoryName = "camisetas",
                    ImageUrl = "https://cdn.nerdstore.com.br/wp-content/uploads/2022/04/vitrine-camiseta-arvore-de-gondor-black-edition-01-nerdstore.jpg",
                    CreatedAt = DateTime.Now,
                }
            };

            foreach(Product product in productsList)
            {
                modelBuilder.Entity<Product>().HasData(product);
            }
        }
    }
}
