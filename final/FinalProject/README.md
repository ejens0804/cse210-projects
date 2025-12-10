# Bank Management System

A C# console application demonstrating Object-Oriented Programming principles with a MySQL database backend for managing customers, accounts, and transactions.

## Features

- Customer management (create, update, view)
- Multiple account types (Savings, Checking, Business)
- Transaction processing (deposits, withdrawals, transfers)
- Transaction history and statements
- Interest calculation
- Fee management
- Overdraft protection

## Prerequisites

Before running this project, you need to have the following installed:

1. **Visual Studio 2022** (or Visual Studio Code with C# extension)
2. **MySQL Server** (version 8.0 or later recommended)
3. **MySQL Workbench** (for database management)
4. **.NET 8.0 SDK**

## Installation & Setup

### Step 1: Install MySQL Server and MySQL Workbench

1. Download and install **MySQL Community Server** from: https://dev.mysql.com/downloads/mysql/
   - During installation, remember your **root password** (you'll need this!)
   - Default port is **3306**

2. Download and install **MySQL Workbench** from: https://dev.mysql.com/downloads/workbench/

### Step 2: Create the Database

1. Open **MySQL Workbench**

2. Click on your local MySQL connection (usually listed as "Local instance MySQL80" or similar)

3. Enter your root password when prompted

4. Once connected, click on the **SQL Editor** icon or go to **Query → New Query Tab**

5. Copy and paste the following SQL script:

```sql
-- Create the database
CREATE DATABASE IF NOT EXISTS BankManagementSystem;
USE BankManagementSystem;

-- Create Customers table
CREATE TABLE IF NOT EXISTS Customers (
    CustomerID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(200),
    DateCreated DATETIME NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE
);

-- Create Accounts table
CREATE TABLE IF NOT EXISTS Accounts (
    AccountID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT NOT NULL,
    AccountNumber VARCHAR(20) UNIQUE NOT NULL,
    AccountType VARCHAR(20) NOT NULL,
    Balance DECIMAL(15,2) DEFAULT 0.00,
    InterestRate DECIMAL(5,2) DEFAULT 0.00,
    MinimumBalance DECIMAL(15,2) DEFAULT 0.00,
    DateOpened DATETIME NOT NULL,
    AccountStatus VARCHAR(20) DEFAULT 'Active',
    OverdraftLimit DECIMAL(15,2) DEFAULT 0.00,
    HasOverdraftProtection BOOLEAN DEFAULT FALSE,
    MonthlyFee DECIMAL(10,2) DEFAULT 0.00,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Create Transactions table
CREATE TABLE IF NOT EXISTS Transactions (
    TransactionID INT PRIMARY KEY AUTO_INCREMENT,
    AccountID INT NOT NULL,
    TransactionType VARCHAR(20) NOT NULL,
    Amount DECIMAL(15,2) NOT NULL,
    TransactionDate DATETIME NOT NULL,
    Description VARCHAR(200),
    BalanceAfter DECIMAL(15,2) NOT NULL,
    RelatedTransactionID INT NULL,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);

-- Create indexes for better performance
CREATE INDEX idx_customer_name ON Customers(LastName, FirstName);
CREATE INDEX idx_account_number ON Accounts(AccountNumber);
CREATE INDEX idx_transaction_date ON Transactions(TransactionDate);
CREATE INDEX idx_account_transactions ON Transactions(AccountID, TransactionDate);
```



6. Click the **lightning bolt icon** (⚡) or press **Ctrl+Shift+Enter** to execute the script

7. You should see "Action Output" showing successful creation of the database and tables

8. Verify the database was created:
   - In the left sidebar under "SCHEMAS", click the refresh icon
   - You should see **BankManagementSystem** listed
   - Expand it to see your three tables: Customers, Accounts, and Transactions

### Step 3: Configure the Project

1. Open the project in Visual Studio

2. Open the file `DatabaseConfig.cs`

3. Update the connection settings to match your MySQL installation:

```csharp
private const string Host = "localhost";        // Your MySQL server address
private const string Database = "BankManagementSystem";  // Database name
private const string User = "root";             // Your MySQL username
private const string Password = "YOUR_PASSWORD"; // Your MySQL password
private const string Port = "3306";             // MySQL port (usually 3306)
```

**Important:** Replace `"YOUR_PASSWORD"` with the actual root password you set during MySQL installation.

### Step 4: Install Required NuGet Package

The project requires the `MySqlConnector` package to communicate with MySQL.

**Option A: Using Visual Studio**
1. Right-click on the project in Solution Explorer
2. Select **Manage NuGet Packages**
3. Click the **Browse** tab
4. Search for `MySqlConnector`
5. Click **Install** on the MySqlConnector package
6. Accept any license agreements

**Option B: Using Package Manager Console**
1. Go to **Tools → NuGet Package Manager → Package Manager Console**
2. Type: `Install-Package MySqlConnector`
3. Press Enter

**Option C: Already configured in .csproj**
- The package reference should already be in `FinalProject.csproj`
- Just right-click the project and select **Restore NuGet Packages**

### Step 5: Build and Run

1. Build the solution: **Build → Build Solution** (or press **Ctrl+Shift+B**)

2. If there are no errors, run the program: **Debug → Start Debugging** (or press **F5**)

3. The program will:
   - Test the database connection
   - Create a sample customer
   - Create a sample checking account
   - Perform sample transactions
   - Display transaction history

## Troubleshooting

### "Cannot connect to database" Error

**Check these things:**

1. **Is MySQL Server running?**
   - Windows: Open Services (services.msc) and look for "MySQL80" or similar
   - If stopped, right-click and select "Start"
   - Or open MySQL Workbench and check if you can connect

2. **Is the password correct?**
   - Make sure the password in `DatabaseConfig.cs` matches your MySQL root password
   - Try connecting through MySQL Workbench first to verify your credentials

3. **Is the database created?**
   - Open MySQL Workbench
   - Check if `BankManagementSystem` database exists under SCHEMAS
   - If not, run the SQL script from Step 2 again

4. **Is the port correct?**
   - Default MySQL port is 3306
   - Check your MySQL Workbench connection settings to confirm

5. **Firewall blocking?**
   - On Windows, MySQL might be blocked by firewall
   - Add an exception for MySQL in Windows Firewall settings

### "Table doesn't exist" Error

- The database was created but tables weren't
- Re-run the SQL script from Step 2 in MySQL Workbench

### Build Errors

**"MySqlConnector not found"**
- Install the MySqlConnector NuGet package (see Step 4)

**"Type or namespace name could not be found"**
- Make sure all your class files have `namespace FinalProject` wrapper
- Check that you have all required files in the project

### Connection String Issues

If you changed your MySQL username or port, update `DatabaseConfig.cs`:

```csharp
// Example for custom setup:
private const string Host = "localhost";
private const string Database = "BankManagementSystem";
private const string User = "myusername";      // Your custom username
private const string Password = "mypassword";   // Your custom password
private const string Port = "3307";            // Custom port if changed
```

## Project Structure

```
FinalProject/
├── Program.cs                        # Entry point, test code
├── DatabaseConfig.cs                 # Database connection settings
├── DatabaseRepositoryAndHelper.cs    # Database operations
├── Enums.cs                         # Enum definitions
│
├── Customer.cs                      # Customer entity
├── BaseAccount.cs                   # Abstract account base class
├── CheckingAccount.cs               # Checking account implementation
├── SavingsAccount.cs                # Savings account implementation
├── BusinessAccount.cs               # Business account implementation
│
├── Transaction.cs                   # Transaction entity
├── Transfer.cs                      # Transfer operations
├── Statement.cs                     # Account statement generation
│
├── BankAndAccountManager.cs         # Main business logic coordinator
├── FeeManager.cs                    # Fee calculation and management
├── ValidationHelper.cs              # Input validation utilities
│
├── InterestCalculator.cs            # Interest calculator interface
├── SimpleInterestCalculator.cs      # Simple interest implementation
└── CompoundInterestCalculator.cs    # Compound interest implementation
```

## OOP Principles Demonstrated

This project demonstrates all four main Object-Oriented Programming principles:

1. **Encapsulation**: Private member variables with public properties
2. **Inheritance**: Account types inherit from BaseAccount
3. **Polymorphism**: Different account types override methods like `Withdraw()` and `CalculateInterest()`
4. **Abstraction**: Abstract BaseAccount class and InterestCalculator interface

## Database Schema

### Customers Table
- Stores customer personal information
- Links to multiple accounts via CustomerID

### Accounts Table
- Stores account details for all account types
- Foreign key to Customers table
- Tracks balance, status, and account-specific settings

### Transactions Table
- Records all financial transactions
- Foreign key to Accounts table
- Supports linking related transactions (transfers)

## Usage Examples

After running the program, you can view the data in MySQL Workbench:

```sql
-- View all customers
SELECT * FROM Customers;

-- View all accounts
SELECT * FROM Accounts;

-- View all transactions for an account
SELECT * FROM Transactions WHERE AccountID = 1 ORDER BY TransactionDate DESC;

-- View customer with their accounts
SELECT c.*, a.AccountNumber, a.AccountType, a.Balance
FROM Customers c
LEFT JOIN Accounts a ON c.CustomerID = a.CustomerID
WHERE c.CustomerID = 1;
```

## Support

If you continue to have issues:
1. Verify MySQL Server is running
2. Test connection in MySQL Workbench first
3. Check that your `DatabaseConfig.cs` credentials match your MySQL setup
4. Ensure the database and tables were created successfully

## License

This is an educational project created for demonstrating C# and OOP concepts with MySQL database integration.