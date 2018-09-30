using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException
{
    class InsufficientFundException :Exception
    {
        private string _message;
        private Account _account = null;

        public InsufficientFundException(string message,Account account) : this(message)
        {
            this._account = account;
        }

        public InsufficientFundException(string message)
        {
            this._message = message;
        }

        public override string Message
        {
            get
            {
                if (this._account!=null)
                {
                    return this._message + "\n" + this._account;
                }
                return this._message;
            }
        }
    }
}
