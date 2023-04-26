using System;
using TronNet;
using TronNet.Accounts;
using TronNet.Contracts;
using TronNet.Protocol;
using TronNet.Crypto;
using TronNet.ABI;
namespace FirstPart
{
    class Program
    {
        public class AccountData
        {
            private TronECKey key;
            private TronAccount acc;
            public AccountData()
            {
                TronNetwork netw = new TronNetwork();
                netw = TronNetwork.MainNet;
                key = TronECKey.GenerateKey(netw);
                acc = new TronAccount(key);
            }
            public void printAccountData()
            {
                Console.WriteLine("Adress: " + acc.Address);
                Console.WriteLine("Private key: " + acc.PrivateKey);
            }
            public TronECKey getKey()
            {
                return key;
            }
            public TronAccount getAccount()
            {
                return acc;
            }
            public string getAddres()
            {
                return acc.Address;
            }
            public string getPrivateKey()
            {
                return acc.PrivateKey;
            }

        }
        static void Main(string[] args)
        {
            AccountData account = new AccountData();
            account.printAccountData();
        }
    }
}
