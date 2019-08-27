using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Business
{
    public interface IPacote
    {
        List<Pacote> Rastrear(string id);
    }
}
