using System;

namespace BankAccountAndBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 7.1
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("Выберите тип счета (0 - Savings, 1 - Checking, 2 - Business): ");
            int accountTypeInput = int.Parse(Console.ReadLine());
            AccountType accountType = (AccountType)accountTypeInput;

            Console.Write("Введите номер счета (максимум 20 цифр): ");
            string accountNumber = Console.ReadLine();

            BankAccount account = new BankAccount(accountType, accountNumber);

            Console.Write("Введите начальный баланс: ");
            decimal initialBalance;
            while (!decimal.TryParse(Console.ReadLine(), out initialBalance))
            {
                Console.Write("Ошибка ввода. Пожалуйста, введите начальный баланс: ");
            }
            account.SetBalance(initialBalance);
            account.DisplayInfo();
            Console.WriteLine();

            // Упражнение 7.2
            Console.WriteLine("Упражнение 7.2");
            string uniqueAccountNumber2 = BankAccount.GenerateUniqueAccountNumber();
            BankAccount account2 = new BankAccount(AccountType.Checking, uniqueAccountNumber2);
            account2.SetBalance(500);
            account2.DisplayInfo();
            Console.WriteLine();

            // Упражнение 7.3
            Console.WriteLine("Упражнение 7.3");
            Console.Write("Введите сумму для пополнения счета: ");
            decimal depositAmount;
            while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                Console.Write("Ошибка ввода. Пожалуйста, введите сумму для пополнения: ");
            }
            account.SetBalance(account.GetBalance() + depositAmount);
            account.DisplayInfo();

            Console.Write("Введите сумму для снятия со счета: ");
            decimal withdrawAmount;
            while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount))
            {
                Console.Write("Ошибка ввода. Пожалуйста, введите сумму для снятия: ");
            }
            if (withdrawAmount <= account.GetBalance())
            {
                account.SetBalance(account.GetBalance() - withdrawAmount);
                account.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия.");
            }

            // Домашнее задание 7.1
            Console.WriteLine("Домашнее задание 7.1");
            Building building = new Building();
            building.SetHeight(50);
            building.SetFloors(10);
            building.SetApartments(100);
            building.SetEntrances(4);
            building.DisplayInfo();
            Console.WriteLine($"Количество квартир на этаже: {building.ApartmentsPerFloor()}");
            Console.WriteLine($"Количество квартир в подъезде: {building.ApartmentsPerEntrance()}");
            Console.WriteLine($"Высота этажа: {building.FloorHeight()}");
        }
    }
}