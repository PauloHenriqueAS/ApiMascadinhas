using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Entities.Entidades
{
    public class Mascada
    {
        /// <summary>
        /// Id Mascada
        /// </summary>
        public int id_mascada { get; set; }

        /// <summary>
        /// Id Usuário
        /// </summary>
        public int id_usuario { get; set; }

        /// <summary>
        /// Id Produto
        /// </summary>
        public int id_produto { get; set; }

        /// <summary>
        /// Descrição da Mascada
        /// </summary>
        public string descricao_mascada { get; set; }

        /// <summary>
        /// Data da Execução da Mascada
        /// </summary>
        public DateTime data_execucao { get; set; }

        /// <summary>
        /// Flag se Resolvido
        /// </summary>
        public bool flg_resolvido { get; set; }

        /// <summary>
        /// Flag se pagamento efetuado
        /// </summary>
        public bool flg_paga_efetuado { get; set; }
    }
}
