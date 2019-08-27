using GhartemSolutions.Templates.ApiBasic.Domain.Business;
using GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using repo = GhartemSolutions.Templates.ApiBasic.Domain.Infrastructure;

namespace GhartemSolutions.Templates.ApiBasic.App
{
    public class Pacote : IPacote
    {
        private repo.IPacote _pacoteDac { get; set; }
        
        public Pacote(repo.IPacote pacoteDac)
        {
            this._pacoteDac = pacoteDac;
        }

        public List<Domain.Model.Pacote.Pacote> Rastrear(string id)
        {
            return _pacoteDac.Rastrear(id);
        }
    }
}
