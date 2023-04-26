# TestPayPoint
# Первая часть задания: Создание адреса
##Реализация:
Я создал класс, который хранит данные о нашем адресе, и имеет функцию вывода общих данных в консоль, и отдельных данных для дальнейшего развития функционала.
```csharp
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
```

Main:
```csharp
 static void Main(string[] args)
        {
            AccountData account = new AccountData();
            account.printAccountData();
        }
```
Вывод в консоль:
Adress: TVoxZJox9pG1saSr114gRt5chk1iu9H6Ft
Private key: 59fab8f020a9c9629e327a3e7079cefdda3e11203bdc0b1d297ea2da42e80e17
