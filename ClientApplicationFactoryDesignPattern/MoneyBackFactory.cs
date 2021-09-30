using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplicationFactoryDesignPattern
{
    class MoneyBackFactory : CardFactory
    {
        private readonly int _creditLimit;
        private readonly int _annualCharge;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
