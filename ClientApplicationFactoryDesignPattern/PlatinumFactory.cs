using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplicationFactoryDesignPattern
{
    class PlatinumFactory : CardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
