using System;

using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bank Management System ===\n");

            // Step 1: Test database connection
            Console.WriteLine("Testing database connection...");
            if (!DatabaseConfig.TestConnection())
            {
                Console.WriteLine("\nERROR: Cannot connect to database.");
                Console.WriteLine("Please make sure:"); 
                Console.WriteLine("1. You've installed MySqlConnector NuGet package");
                Console.WriteLine("2. You've run the SQL setup script in phpMyAdmin");
                Console.WriteLine("3. Your database credentials are correct");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n✓ Database connection successful! Press Enter to continue...");
            Console.ReadLine();

            // Step 2: Create database helper instance
            DatabaseRepositoryAndHelper db = new DatabaseRepositoryAndHelper();

            // Step 3: Create a test customer
            Console.WriteLine("\n--- Creating Test Customer ---");
            Customer testCustomer = new Customer();
            testCustomer.FirstName = "Alice";
            testCustomer.LastName = "Johnson";
            testCustomer.Email = "alice.johnson@email.com";
            testCustomer.PhoneNumber = "555-0123";
            testCustomer.Address = "456 Oak Street, Rexburg, ID";

            int customerId = db.SaveCustomer(testCustomer);
            if (customerId > 0)
            {
                testCustomer.CustomerID = customerId;
                Console.WriteLine($"✓ Customer created successfully!");
                testCustomer.DisplayCustomerDetails();
            }
            else
            {
                Console.WriteLine("✗ Failed to create customer");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 4: Create a checking account
            Console.WriteLine("\n--- Creating Checking Account ---");
            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.CustomerID = customerId;
            checkingAccount.AccountNumber = GenerateAccountNumber();
            checkingAccount.Balance = 500.00m;
            checkingAccount.OverdraftLimit = 100.00m;
            checkingAccount.HasOverdraftProtection = true;

            int accountId = db.SaveAccount(checkingAccount);
            if (accountId > 0)
            {
                checkingAccount.AccountID = accountId;
                Console.WriteLine($"✓ Checking account created successfully!");
                checkingAccount.DisplayAccountInfo();
            }
            else
            {
                Console.WriteLine("✗ Failed to create account");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 5: Make a deposit
            Console.WriteLine("\n--- Making Deposit ---");
            decimal depositAmount = 250.00m;
            try
            {
                checkingAccount.Deposit(depositAmount);

                Transaction depositTransaction = new Transaction();
                depositTransaction.AccountID = accountId;
                depositTransaction.Type = TransactionType.Deposit;
                depositTransaction.Amount = depositAmount;
                depositTransaction.Description = "ATM Deposit";
                depositTransaction.BalanceAfter = checkingAccount.Balance;

                int transId = db.SaveTransaction(depositTransaction);
                db.UpdateAccountBalance(accountId, checkingAccount.Balance);

                Console.WriteLine($"✓ Deposited ${depositAmount:N2}");
                Console.WriteLine($"  New Balance: ${checkingAccount.Balance:N2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Deposit failed: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 6: Make a withdrawal
            Console.WriteLine("\n--- Making Withdrawal ---");
            decimal withdrawAmount = 100.00m;
            try
            {
                if (checkingAccount.Withdraw(withdrawAmount))
                {
                    Transaction withdrawTransaction = new Transaction();
                    withdrawTransaction.AccountID = accountId;
                    withdrawTransaction.Type = TransactionType.Withdrawal;
                    withdrawTransaction.Amount = withdrawAmount;
                    withdrawTransaction.Description = "ATM Withdrawal";
                    withdrawTransaction.BalanceAfter = checkingAccount.Balance;

                    db.SaveTransaction(withdrawTransaction);
                    db.UpdateAccountBalance(accountId, checkingAccount.Balance);

                    Console.WriteLine($"✓ Withdrew ${withdrawAmount:N2}");
                    Console.WriteLine($"  New Balance: ${checkingAccount.Balance:N2}");
                }
                else
                {
                    Console.WriteLine("✗ Insufficient funds for withdrawal");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Withdrawal failed: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 7: View transaction history
            Console.WriteLine("\n--- Transaction History ---");
            var transactions = db.LoadTransactionsForAccount(accountId);
            Console.WriteLine($"Found {transactions.Count} transaction(s):\n");
            foreach (var trans in transactions)
            {
                trans.DisplayTransactionDetails();
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 8: Load customer from database
            Console.WriteLine("\n--- Loading Customer from Database ---");
            Customer loadedCustomer = db.LoadCustomerByID(customerId);
            if (loadedCustomer != null)
            {
                Console.WriteLine("✓ Successfully loaded customer:");
                loadedCustomer.DisplayCustomerDetails();
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

            // Step 9: Load account from database
            Console.WriteLine("\n--- Loading Account from Database ---");
            BaseAccount loadedAccount = db.LoadAccountByID(accountId);
            if (loadedAccount != null)
            {
                Console.WriteLine("✓ Successfully loaded account:");
                loadedAccount.DisplayAccountInfo();
            }

            Console.WriteLine("\n=== Test Complete! ===");
            Console.WriteLine("\nMy database integration is working correctly!");
            Console.ReadLine();
        }

        static string GenerateAccountNumber()
        {
            Random random = new Random();
            return $"{random.Next(1000, 9999)}{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
        }
    }
}