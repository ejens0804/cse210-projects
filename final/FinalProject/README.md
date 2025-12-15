# Bank Management System

A complete banking application built with C# and MySQL that allows you to manage customer accounts, perform transactions, and track financial activity.

## What This Program Does

- **Create and manage customer accounts** - Store customer information securely
- **Multiple account types** - Savings, Checking, and Business accounts with unique features
- **Banking transactions** - Deposits, withdrawals, and transfers between accounts
- **Transaction history** - View complete records of all account activity
- **Account statements** - Generate detailed statements for any date range
- **Interest calculation** - Automatic interest on eligible accounts
- **Fee management** - Overdraft protection and account maintenance fees

## Requirements

To run this program, you need:

1. **Windows Operating System**
2. **MySQL Workbench** - Download from: https://dev.mysql.com/downloads/workbench/
3. **Visual Studio 2022 or Visual Studio Code** (Community Edition is free) - Download from: https://visualstudio.microsoft.com/ or https://code.visualstudio.com/download

## Quick Start Guide

### Step 1: Install MySQL Workbench

1. Download **MySQL Installer** from https://dev.mysql.com/downloads/installer/
2. Run the installer and choose "Custom" installation
3. Select:
   - MySQL Server (latest version)
   - MySQL Workbench
4. During setup, create a **root password** - **Remember this password!**
5. Complete the installation

### Step 2: Create the Database

1. Open **MySQL Workbench**
2. Click on your local connection (usually "Local instance MySQL80")
3. Enter your root password
4. In the project folder, find the file `database_setup.sql`
5. In MySQL Workbench, go to **File → Open SQL Script**
6. Select `database_setup.sql` and click **Open**
7. Click the lightning bolt icon ⚡ to run the script
8. You should see "BankManagementSystem" appear in the SCHEMAS panel on the left

### Step 3: Configure the Connection

1. Open the project in **Visual Studio**
2. Find and open `DatabaseConfig.cs`
3. Update line 10 with YOUR password:
   ```csharp
   private const string Password = "YOUR_PASSWORD_HERE";
   ```
4. Save the file

### Step 4: Run the Program

1. Press **F5** or click the green "Start" button in Visual Studio
(In Visual Studio code, verify that the .NET Framework is installed and navigate to the project directory, and type dotnet run in the terminal to execute the program)
2. The program will test the database connection
3. If successful, you'll see the main menu!

## Using the Program

### First Time Setup

1. **Create a Customer Account**
   - Choose option 1 from the login screen
   - Enter your personal information
   - Remember your Customer ID!

2. **Open a Bank Account**
   - Login with your Customer ID
   - Choose "Open New Account"
   - Select account type and make initial deposit

### Available Account Types

**Savings Account**
- 2.5% annual interest rate
- $100 minimum balance
- Limited to 6 withdrawals per month
- Best for: Long-term savings

**Checking Account**
- Overdraft protection available
- $10 monthly maintenance fee (waived with $1000+ balance)
- $25 minimum balance
- Best for: Daily transactions

**Business Account**
- 1.5% annual interest rate
- 100 free transactions per month
- $0.50 fee per transaction after limit
- $500 minimum balance
- Best for: Business operations

### Main Features

**Make Deposits/Withdrawals**
- Select your account
- Enter the amount
- Transaction is recorded immediately

**Transfer Money**
- Move money between your accounts instantly
- Full transaction history maintained

**View Transaction History**
- See all deposits, withdrawals, and transfers
- Transactions shown with dates and descriptions

**Generate Statements**
- Choose date range
- View detailed summary of all activity
- Shows opening/closing balance and totals

**Manage Your Profile**
- Update email, phone, and address anytime
- Information saved to database

## Troubleshooting

### "Cannot connect to database"

**Check these:**
1. Is MySQL running?
   - Open Windows Services (search "services" in Start menu)
   - Look for "MySQL80" - should say "Running"
   - If not, right-click and select "Start"

2. Is the password correct?
   - Open `DatabaseConfig.cs`
   - Make sure the password matches your MySQL root password

3. Does the database exist?
   - Open MySQL Workbench
   - Look for "BankManagementSystem" under SCHEMAS
   - If missing, run `database_setup.sql` again

### Program won't start

1. Make sure you have **.NET 8.0 SDK** installed
2. Right-click project → "Restore NuGet Packages"
3. Build the solution (Ctrl+Shift+B)

### "MySqlConnector not found" error

1. Right-click the project in Visual Studio
2. Select "Manage NuGet Packages"
3. Search for "MySqlConnector"
4. Click Install

## Security Note

This is an educational project. In a production environment:
- Passwords should be encrypted
- User authentication should be more robust
- Database credentials should not be in source code
- Add proper transaction logging and audit trails

## Database Design

The system uses three main tables:

**Customers** - Stores customer personal information
**Accounts** - Stores all bank accounts (Savings, Checking, Business)
**Transactions** - Records every financial transaction

All data persists in MySQL, so your information is saved between program runs.

## Features Demonstrated

This project showcases Object-Oriented Programming principles:

1. **Encapsulation** - Private data with controlled access
2. **Inheritance** - Different account types share common functionality
3. **Polymorphism** - Same operations work differently for different account types
4. **Abstraction** - Interfaces and abstract classes define contracts

## Support

If you encounter issues:

1. Verify MySQL Server is running (Services → MySQL80)
2. Test connection in MySQL Workbench first
3. Check that `DatabaseConfig.cs` has correct password
4. Ensure database and tables were created (check MySQL Workbench SCHEMAS)
5. Check Visual Studio output window for specific error messages

## Credits

This Bank Management System was created as an educational project to demonstrate:
- C# programming
- Object-Oriented Programming principles
- MySQL database integration
- User interface design
- Transaction management

---

**Important**: This is a learning project. Do not use with real financial data or deploy in production environments without proper security enhancements.