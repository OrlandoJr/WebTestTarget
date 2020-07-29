using System;

namespace Application.ViewModel
{
    public class EnderecosPostViewModel
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int ClientesID { get; set; }
        public ClientesViewModel Cliente { get; set; }
    }
}
