using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Clients
    {
        protected List<BanckAcc> BanckAccs;
        protected List<VipAcc> VipAccs;

        public void Add(int id, decimal amount, decimal interestRate, DateTime registrationDate, decimal addedMoney)
        {
            if (addedMoney == 0)
                BanckAccs.Add(new BanckAcc(id, amount, interestRate, registrationDate));
            else
                VipAccs.Add(new VipAcc(id, amount, interestRate, registrationDate, addedMoney));
        }


    }
}
