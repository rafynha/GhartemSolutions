using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Exception
{
    public class ErroInternoException : System.Exception
    {
        private const string customMessage = "Um erro interno ocorreu.";

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
                return "InternalFault";
            }
        }

        public TraceLevel Level
        {
            get
            {
                return TraceLevel.Error;
            }
        }

        public ErroInternoException()
            : base(customMessage)
        { }

        public ErroInternoException(string message)
            : base(message)
        { }

        public ErroInternoException(string message, System.Exception innerException)
            : base(message, innerException)
        { }

        public ErroInternoException(System.Exception innerException)
            : base(customMessage, innerException)
        { }
    }
}
