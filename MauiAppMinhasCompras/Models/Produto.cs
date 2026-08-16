using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {

        String _descricao;
        Double _Quantidade;
        Double _Preco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { 
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("A descrição do produto não pode ser vazia");
                }
                _descricao = value;
            }
        }
        public double Quantidade { 
            get => _Quantidade;
            set
            {
                if (value < 0)
                {
                    throw new Exception("A quantidade do produto não pode ser negativa");
                }
                _Quantidade = value;
            }
        }
        public double Preco { 
            get => _Preco;
            set
            {
                if (value < 0)
                {
                    throw new Exception("O preço do produto não pode ser negativo");
                }
                _Preco = value;
            }
        }

        public double Total {
            get { return Quantidade * Preco; }
        }


    }
}
