namespace parcial.Migrations
{
    using parcial.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Parcial.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Parcial.Models.AppDbContext context)
        {
            if (!context.Producto.Any())
            {
                var faker = new Bogus.Faker<Models.Producto>()
                    .RuleFor(x => x.Nombre, f => f.Commerce.ProductName())
                    .RuleFor(x => x.Precio, f => decimal.Parse(f.Commerce.Price()))
                    .RuleFor(x => x.Precio, f => f.Random.Int(0, 50));

                var p = faker.Generate(15);

                List<Producto> fakeProductos = faker.Generate(15);

                context.Producto.AddRange(fakeProductos);
                context.SaveChanges();
            }
        }
    }
}
