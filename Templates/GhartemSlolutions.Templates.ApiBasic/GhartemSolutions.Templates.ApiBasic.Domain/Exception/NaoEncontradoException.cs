using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Exception
{
    public class NaoEncontradoException : System.Exception
    {
        private const string customMessage = "O recurso pesquisado não foi encontrado.";

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
                return "NotFoundFault";
            }
        }

        public TraceLevel Level
        {
            get
            {
                return TraceLevel.Info;
            }
        }

        public NaoEncontradoException()
            : base(customMessage)
        { }

        public NaoEncontradoException(string message)
            : base(message)
        { }

        public NaoEncontradoException(string message, System.Exception innerException)
            : base(message, innerException)
        { }

        public NaoEncontradoException(System.Exception innerException)
            : base(customMessage, innerException)
        { }
    }
}
