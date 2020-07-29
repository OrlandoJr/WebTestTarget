using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel
{
    public class ClientesViewModel
    {
        public ClientesViewModel()
        {
            Enderecos = new HashSet<EnderecosViewModel>();
        }

        [Key]
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public ICollection<EnderecosViewModel> Enderecos { get; set; }
    }
    
}
