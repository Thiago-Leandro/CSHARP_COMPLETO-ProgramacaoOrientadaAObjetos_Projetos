using System.Globalization;

namespace _42._Começando_a_resolver_um_segundo_problema {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quatidade) {
            Quantidade = Quantidade += quatidade;
        }

        public void RemoverProdutos(int quatidade) {
            Quantidade = Quantidade -= quatidade;
        }

        public override string ToString() {
            return  Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $ "
                +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
