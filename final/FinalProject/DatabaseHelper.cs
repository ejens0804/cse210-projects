using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using MySqlConnector;

public class DatabaseHelper
{
    // Attributes/Member Variables
    private readonly string _connectionString;


    // Constructor
    public DatabaseHelper()
    {
        _connectionString = DatabaseConfig.ConnectionString;
    }


    // Methods
    // public void ExecuteQuery()
    // {

    // }

    // public void ExecuteNonQuery()
    // {

    // }

    // public void ExecuteScalar()
    // {

    // }

    public int SaveCustomer(Customer customer)
    {

        string query = @"INSERT INTO Customers
                        (FirstName, LastName, Email, Phone, Address, DateCreated, IsActive)
                        VALUES (@firstName, @lastName, @email, @phone, @address, @dateCreated, @isActive);
                        SELECT LAST_INSERT_ID();";
        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", customer.GetFirstName());
                    command.Parameters.AddWithValue("@lastName", customer.GetLastName());
                    command.Parameters.AddWithValue("@email", customer.GetEmail() ?? ""); // ?? are for if the input is null
                    command.Parameters.AddWithValue("@phone", customer.GetPhoneNumber() ?? ""); // ?? are for if the input is null
                    command.Parameters.AddWithValue("@address", customer.GetAddress() ?? ""); // ?? are for if the input is null
                    command.Parameters.AddWithValue("@dateCreated", customer.GetDateCreated());
                    command.Parameters.AddWithValue("@isActive", true);

                    int customerID = Convert.ToInt32(command.ExecuteScalar());
                    return customerID;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving customer: {ex.Message}");
            return -1;
        }
    }

    public Customer LoadCustomerByID(int customerID)
    {
        string query = "SELECT * FROM Customers WHERE CustomerID = @customerId AND IsActive = TRUE";

        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                _customerID = reader.GetInt32("CustomerID"),
                                _firstName = reader.GetString("FirstName"),
                                _lastName = reader.GetString("LastName"),
                                _email = reader.GetString("Email"),
                                _phoneNumber = reader.GetString("Phone"),
                                _address = reader.GetString("Address"),
                                _dateCreated = reader.GetDateTime("DateCreated")
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading customer: {ex.Message}");
        }

        return null;
    }

    public List<Customer> SearchCustomersByName(string searchTerm)
    {
        List<Customer> customers = new List<Customer>();
        string query = @"SELECT * FROM Customers
                        WHERE (FirstName LIKE @search OR LastName LIKE @search)
                        AND IsActive = TRUE";
        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                _customerID = reader.GetInt32("CustomerID"),
                                _firstName = reader.GetString("FirstName"),
                                _lastName = reader.GetString("LastName"),
                                _email = reader.GetString("Email"),
                                _phoneNumber = reader.GetString("Phone"),
                                _address = reader.GetString("Address"),
                                _dateCreated = reader.GetDateTime("DateCreated")
                            });
                        }
                    }
                }
            }
        }
    catch (Exception ex)
        {
            Console.WriteLine($"Error searching customers: {ex.Message}");
        }

        return customers;
    }

    public void UpdateCustomer()
    {

    }

    public int SaveAccount(BaseAccount account)
    {
        string query = @"INSERT INTO Accounts
                        (CustomerID, AccountNumber, AccountType, Balance, InterestRate,
                        MinimumBalance, DateOpened, AccountStatus, OverdraftLimit,
                        HasOverdraftProtection, MonthlyFee)
                        VALUES (@customerId, @accountNumber, @accountType, @balance, @interestRate,
                                @minimumBalance, @dateOpened, @status, @overdraftLimit, @hasOverdraft, 
                                @monthlyFee);
                        SELECT LAST_INSERT_ID();";
        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                
                    command.Parameters.AddWithValue("@customerId", account.CustomerID);
                    command.Parameters.AddWithValue("@accountNumber", account.AccountNumber);
                    command.Parameters.AddWithValue("@accountType", account.GetType().Name);
                    command.Parameters.AddWithValue("@balance", account.Balance);
                    command.Parameters.AddWithValue("@interestRate", account.InterestRate);
                    command.Parameters.AddWithValue("@minimumBalance", account.MinimumBalance);
                    command.Parameters.AddWithValue("@dateOpened", account.DateOpened);
                    command.Parameters.AddWithValue("@status", account._accountStatus.ToString());

                    if (BaseAccount is CheckingAccount checking)
                    
                        command.Parameters.AddWithValue("@overdraftLimit", checking.OverdraftLimit);
                        cmd.Parameters.AddWithValue("@hasOverdraft", checking.HasOverdraftProtection);
                        cmd.Parameters.AddWithValue("@monthlyFee", checking.MonthlyFee);
                        
                    else
                    {
                        cmd.Parameters.AddWithValue("@overdraftLimit", 0);
                        cmd.Parameters.AddWithValue("@hasOverdraft", false);
                        cmd.Parameters.AddWithValue("@monthlyFee", 0);
                    }
                    int accountId = Convert.ToInt32(cmd.ExecuteScalar());
                    return accountId;
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving account: {ex.Message}");
                return -1;
            }
        }
                    }
                }
            }
        }
    }

    public void LoadAccountByID()
    {

    }

    public void LoadAllAccountsForCustomer()
    {

    }

    public void SaveTransaction()
    {

    }

    public void LoadTransactionsForAccount()
    {

    }

    public void LoadTransactionsByDateRange()
    {

    }

    public void UpdateAccountBalance()
    {

    }

    public void BeginTransaction()
    {

    }

    public void CommitTransaction()
    {

    }

    public void RollbackTransaction()
    {

    }
}