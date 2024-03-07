using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CreatedAt, CategoryId) VALUES ('Smartphone X1', 'Smartphone de última geração com tela de 6.5 polegadas', 1200.00, 'http://example.com/smartphone_x1.jpg', 50, now(), 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CreatedAt, CategoryId) VALUES ('Livro TDD Descomplicado', 'Livro sobre desenvolvimento de software guiado por testes', 45.90, 'http://example.com/livro_tdd.jpg', 100, now(), 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CreatedAt, CategoryId) VALUES ('Cadeira Gamer Pro', 'Cadeira gamer ergonômica com ajustes personalizáveis', 890.00, 'http://example.com/cadeira_gamer.jpg', 30, now(), 3)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CreatedAt, CategoryId) VALUES ('Tênis Runner High', 'Tênis para corrida com amortecimento superior', 299.99, 'http://example.com/tenis_runner.jpg', 60, now(), 5)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUrl, Stock, CreatedAt, CategoryId) VALUES ('Kit de Beleza Natural', 'Kit de produtos de beleza orgânicos e veganos', 189.90, 'http://example.com/kit_beleza.jpg', 40, now(), 6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products WHERE Name IN ('Smartphone X1', 'Livro TDD Descomplicado', 'Cadeira Gamer Pro', 'Tênis Runner High', 'Kit de Beleza Natural')");

        }
    }
}
