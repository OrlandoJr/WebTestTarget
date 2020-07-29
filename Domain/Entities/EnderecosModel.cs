using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("tb_Enderecos")]
    public class EnderecosModel
    {
        [Key]
        public int EnderecoID { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int ClienteID { get; set; }
        public ClientesModel Cliente { get; set; }


    }
}
