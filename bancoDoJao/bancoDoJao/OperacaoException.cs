using System;
using System.Collections.Generic;
using System.Text;

namespace bancoDoJao
{
    class OperacaoException : Exception
    {
        public OperacaoException(string msg) : base(msg)
        {

        }

    }
}
