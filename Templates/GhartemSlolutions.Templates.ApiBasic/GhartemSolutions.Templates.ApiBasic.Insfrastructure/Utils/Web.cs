using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Insfrastructure.Utils
{
    public class Web
    {
        public static string Get(string urlRaiz, string urlAcao = "", Dictionary<string, string> cabecalhoHttp = null)
        {
            string retorno;
            var requisicaoWeb = WebRequest.CreateHttp(urlRaiz + urlAcao);
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWeb";

            //MontarCabecalho(cabecalhoHttp, requisicaoWeb);

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                retorno = objResponse.ToString();

                streamDados.Close();
                resposta.Close();
            }
            return retorno;
        }
    }
}
