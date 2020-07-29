using System;

namespace Application.ViewModel
{
    public class ClientesPutViewModel
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
    }
}
