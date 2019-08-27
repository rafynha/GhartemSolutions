using GhartemSolutions.Templates.ApiBasic.Domain.Infrastructure;
using GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Insfrastructure
{
    public class Pacote : IPacote
    {
        public int? Create(Domain.Model.Pacote.Pacote entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Model.Pacote.Pacote> GeatAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Model.Pacote.Pacote GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Domain.Model.Pacote.Pacote GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Model.Pacote.Pacote> Rastrear(string id)
        {
            List<Domain.Model.Pacote.Pacote> retorno = new List<Domain.Model.Pacote.Pacote>();
            var web = new HtmlWeb();
            var doc = web.Load($"https://www.linkcorreios.com.br/{id}");
            var tbLinhas = doc.DocumentNode.SelectNodes("//div[@id='conteudo']//table[@class='table table-bordered']//tbody//tr");

            Domain.Model.Pacote.Pacote pacote = new Domain.Model.Pacote.Pacote();

            for (int i = 0; i < tbLinhas?.Count; i++)
            {
                var col = tbLinhas[i].SelectNodes("td");
                if (tbLinhas.IndexOf(tbLinhas[i]) % 2 == 0)
                {
                    DateTime dt;
                    if (DateTime.TryParse(col[0].InnerText, out dt))
                        pacote.Data = dt;
                    pacote.Status = col[1]?.InnerText;
                }
                else
                {
                    pacote.Localidade = new Localidade();
                    pacote.Localidade.Origem = col[0].InnerText;
                    pacote.Localidade.Destino = col.Count > 1 ? col[1].InnerText : null;
                    retorno.Add(pacote);
                    pacote = new Domain.Model.Pacote.Pacote();
                }
            }
            return retorno;
        }

        public int? Update(Domain.Model.Pacote.Pacote entity)
        {
            throw new NotImplementedException();
        }
    }
}
