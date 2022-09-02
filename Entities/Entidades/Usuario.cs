using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Entities.Entidades
{
    public class Usuario
    {
        /// <summary>
        /// Id Usuário
        /// </summary>
        public int id_usuario { get; set; }
        
        /// <summary>
        /// Nome do Usuário
        /// </summary>
        public string nome_usuario { get; set; }

        /// <summary>
        /// Data de Cadastro
        /// </summary>
        public DateTime data_cadastro { get; set; }

        /// <summary>
        /// Cargo
        /// </summary>
        public string cargo { get; set; }

        /// <summary>
        /// Nível Profissional
        /// </summary>
        public string nivel_profissional { get; set; }
    }
}
