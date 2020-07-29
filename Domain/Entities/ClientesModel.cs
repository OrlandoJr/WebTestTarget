using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("tb_Clientes")]
    public class ClientesModel
    {
        public ClientesModel()
        {
            Enderecos = new HashSet<EnderecosModel>();
        }

        [Key]
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public ICollection<EnderecosModel> Enderecos { get; set; }

    }
    
}
