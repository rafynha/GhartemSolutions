using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Exception
{
    public class AcessoNegadoException  : System.Exception
    {
        private const string customMessage = "Acesso negado.";

        public string DetailsMessage
        {
            get
            {
                return customMessage;
            }
        }

        public string FaultCode
        {
            get
            {
                return "Forbidden";
            }
        }

        public TraceLevel Level
        {
            get
            {
                return TraceLevel.Info;
            }
        }

        public AcessoNegadoException()
            : base(customMessage)
        { }

        public AcessoNegadoException(string message)
            : base(message)
        { }

        public AcessoNegadoException(string message, System.Exception innerException)
            : base(message, innerException)
        { }

        public AcessoNegadoException(System.Exception innerException)
            : base(customMessage, innerException)
        { }
    }
}
