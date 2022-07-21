using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Coca-Cola','Refrigerante de Cola 350ml',5.45,'cocacola.jpg',50,now(),1)");
            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Sanduiche de presunto','Sanduiche de presunto do chaves',6.50,'sanduichedepresunto.jpg',10,now(),2)");
            migrationBuilder.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Doce de leite','Doce de leite 200g',4.25,'docedeleite.jpg',5,now(),3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
