namespace Aula16MetodoConst
{
    public class Produto
    {
        public string nome { get; set; }
        public int codigo { get; set; }
        public int estoque { get; set; }

        public Produto(){

        }

        public Produto(int _codigo){
            this.codigo = _codigo;

        }

        public Produto(string _nome, int _codigo, int _estoque){

            this.codigo = _codigo;
            this.nome = _nome;
            this.estoque = _estoque;
        }
    }
}