using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Eletrônicos', 'http://example.com/eletronicos.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Livros', 'http://example.com/livros.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Casa e Decoração', 'http://example.com/casa_decoracao.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Moda e Acessórios', 'http://example.com/moda_acessorios.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Esportes e Lazer', 'http://example.com/esportes_lazer.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Beleza e Saúde', 'http://example.com/beleza_saude.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Brinquedos e Jogos', 'http://example.com/brinquedos_jogos.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Alimentos e Bebidas', 'http://example.com/alimentos_bebidas.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Ferramentas e Jardim', 'http://example.com/ferramentas_jardim.jpg')");
            migrationBuilder.Sql("INSERT INTO Categories (Name, ImageUrl) VALUES ('Pet Shop', 'http://example.com/pet_shop.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories WHERE Name IN ('Eletrônicos', 'Livros', 'Casa e Decoração', 'Moda e Acessórios', 'Esportes e Lazer', 'Beleza e Saúde', 'Brinquedos e Jogos', 'Alimentos e Bebidas', 'Ferramentas e Jardim', 'Pet Shop')");
        }
    }
}
