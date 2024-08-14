using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojasMoveis.Migrations
{
    public partial class PopularMoveis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (2, 'estante', 'estante, cadeira e mesa', 1, 'https://drive.google.com/file/d/17D5khsDuUVEZLlEx8TMU8S77-gkuDWRo/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/17D5khsDuUVEZLlEx8TMU8S77-gkuDWRo/view?usp=drive_link', 0, 'moveis escritorio', 2500.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (4, 'sofá', 'sofá personalizado', 1, 'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 0, 'moveis luxo', 5000.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (1, 'cadeira', 'cadeira ergonômica', 1, 'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 0, 'moveis confort', 1000.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (3, 'mesa', 'mesa de jantar', 1, 'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/1ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 0, 'moveis modernos', 3500.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (5, 'armário', 'armário de cozinha', 1, 'https://drive.google.com/file/d/2ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/2ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 0, 'moveis cozinha', 1500.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (6, 'cama', 'cama king size', 1, 'https://drive.google.com/file/d/3ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/3ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 1, 'moveis quarto', 4500.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (7, 'escrivaninha', 'escrivaninha com gavetas', 1, 'https://drive.google.com/file/d/4ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/4ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 0, 'moveis home office', 2500.00)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Moveis (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsMovelPreferido, Nome, Preco) " +
                "VALUES (8, 'prateleira', 'prateleira de parede', 1, 'https://drive.google.com/file/d/5ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', " +
                "'https://drive.google.com/file/d/5ZtCT6Na4PQntwRFfociGF62UOQNjb-fY/view?usp=drive_link', 1, 'moveis decorativos', 800.00)"
            );
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
