using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Exception
{
    public class ParametrosInvalidosException  : System.Exception
    {
        private const string customMessage = "Parâmetros informados inválidos.";

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
                return "BadRequest";
            }
        }

        public TraceLevel Level
        {
            get
            {
                return TraceLevel.Warning;
            }
        }

        public ParametrosInvalidosException()
            : base(customMessage)
        { }

        public ParametrosInvalidosException(string message)
            : base(message)
        { }

        public ParametrosInvalidosException(string message, System.Exception innerException)
            : base(message, innerException)
        { }

        public ParametrosInvalidosException(System.Exception innerException)
            : base(customMessage, innerException)
        { }
    }
}
