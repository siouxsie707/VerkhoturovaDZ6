using System;

public enum AccountType
{
    Savings,
    Checking,
    Business
}

namespace BankAccountAndBuilding
{
    public class BankAccount
    {
        private static int nextAccountNumber = 0; // Начинаем с 0
        private string accountNumber; // Храним номер счета как строку
        private decimal balance;
        private AccountType accountType;

        public BankAccount(AccountType accountType, string accountNumber)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = 0; // Начальный баланс
        }

        public static string GenerateUniqueAccountNumber()
        {
            nextAccountNumber++;
            return nextAccountNumber.ToString().PadLeft(20, '0'); // Генерируем 20-значный номер, дополняя нулями слева
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}, Тип счета: {accountType}, Баланс: {balance:C}");
        }

        public void SetBalance(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}