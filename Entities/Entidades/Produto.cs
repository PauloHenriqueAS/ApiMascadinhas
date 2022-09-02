using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Entities.Entidades
{
    public class Class1
    {
        /// <summary>
        /// Id Produto
        /// </summary>
        public int id_produto { get; set; }

        /// <summary>
        /// Quantidade de Estoque
        /// </summary>
        public int qtd_estoque { get; set; }

        /// <summary>
        /// Blob da Imagem (Base64)
        /// </summary>
        public string blob_imagem { get; set; }

        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string descricao_produto { get; set; }
    }
}
