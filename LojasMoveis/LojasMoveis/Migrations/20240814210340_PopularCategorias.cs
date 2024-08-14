using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojasMoveis.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Planejados','Especializados em móveis sob medida para diferentes ambientes como cozinhas, quartos e escritórios.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis para Escritório','Focados em mobília para ambientes corporativos, como mesas, cadeiras ergonômicas, e estantes.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Residenciais','Lojas que oferecem uma variedade de móveis para a casa, incluindo salas de estar, quartos, e áreas externas.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis de Luxo','Especializados em peças de alta qualidade e design exclusivo, muitas vezes feitos sob encomenda.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Sustentáveis','Lojas que priorizam a produção sustentável, utilizando materiais recicláveis e processos eco-friendly.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Rústicos','Focados em móveis de madeira maciça, com acabamento artesanal e estilo campestre.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Modulares','Lojas que vendem móveis modulares, permitindo configurações personalizadas de acordo com o espaço disponível.')");

            migrationBuilder.Sql("Insert into Categorias(CategoriaNome, Descricao)" +
                "Values('Móveis Retrô e Vintage','Especializados em peças de design clássico, inspiradas em décadas passadas.')");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
