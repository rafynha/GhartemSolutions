using GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Infrastructure
{
    public interface IPacote : IRepository<Pacote>
    {
        List<Pacote> Rastrear(string id);
    }
}
