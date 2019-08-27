using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote
{
    public class Pacote
    {
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public Localidade Localidade { get; set; }
    }
}
