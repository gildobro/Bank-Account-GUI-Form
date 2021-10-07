using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP_Lab5_working_
{
    public class AccountManager
    {
        private int numAccounts;
        private int maxAccounts;
        private Account[] accList;

        public AccountManager()
        {
            numAccounts = 0;
            maxAccounts = 100;
            accList = new Account[100];
        }

        public int getNumAccounts() { return numAccounts; }

        public bool addAccount(int aNum, double bal, string own)
        {
            if (numAccounts < maxAccounts)
            {
                accList[numAccounts] = new Account(aNum, bal, own);
                numAccounts++;
                return true;
            }
            return false;
        }

        public Account findAccount(int aNum)
        {
            for (int x = 0; x < numAccounts; x++)
            {
                if (accList[x].getAccNumber() == aNum)
                {
                    return accList[x];
                }
            }
            return null;
        }

        public Account GetAccountByIndex(int index)
        {
            if(index < numAccounts)
            {
                return accList[index];
            }
            return null;
        }
    }
}
