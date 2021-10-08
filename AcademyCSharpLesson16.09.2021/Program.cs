using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCSharpLesson16._09._2021
{
    class AccountTansactions
    {
        static void Main()
        {
            var conString = @"Data Source = .\Dev; initial Catalog = TransactionAccount; Integrated Security = true";

            var working = true;
            while (working)
            {
                Console.WriteLine("1. Exit\n2. Create Account\n3. Show Accounts\n4. Transfer From One Account To Another Account\nChoice:");
                Int32.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false;
                        break;
                    case 2:
                        CreateAccount(conString);
                        break;
                    case 3:
                        ShowAccounts(conString);
                        break;
                    case 4:
                        Console.Write("From Account: ");
                        var fromAcc = Console.ReadLine();

                        Console.Write("To Account: ");
                        var toAcc = Console.ReadLine();

                        Decimal.TryParse(Console.ReadLine(), out var amount);
                        TransferFromToAcc(fromAcc, toAcc, amount, conString);

                        CheckBalanceFromAcc(fromAcc, conString);
                        CheckBalanceToAcc(toAcc, conString);
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }
        }

        private static void CheckBalanceFromAcc(string fromAcc, string conString)
        {
            var sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = "select sum(t.Amount) from Transactions t left join Account a on t.Account_Id = a.Id where a.Account = @fromAcc";
            command.Parameters.AddWithValue("@fromAcc", fromAcc);
            var reader = command.ExecuteReader();
            decimal fromAccBalance = 0m;

            while (reader.Read())
            {
                fromAccBalance = !string.IsNullOrEmpty(reader.GetValue(0)?.ToString()) ? reader.GetDecimal(0) : 0;
            }

            reader.Close();
            command.Parameters.Clear();

            if (fromAccBalance == 0m)
            {
                command.Parameters.Clear();

                var fromAccId = GetAccointId(fromAcc, conString);

                if (fromAccId == 0)
                {
                    throw new Exception("Account '\'toAcc'\' not found");
                }

                command.CommandText = $"Update Account set Is_Active = 0 where Id = @fromAccId";
                command.Parameters.AddWithValue("@fromAccId", fromAccId);

                var reader2 = command.ExecuteNonQuery();

                if (reader2 > 0)
                {
                    Console.WriteLine($"{fromAcc} balance is 0, please top up your balance");
                }
            }

            reader.Close();
            command.Parameters.Clear();

            sqlConnection.Close();
            //return fromAccBalance;
        }
        private static void CheckBalanceToAcc(string toAcc, string conString)
        {
            var sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            var command = sqlConnection.CreateCommand();
            command.CommandText = "select sum(t.Amount) from Transactions t left join Account a on t.Account_Id = a.Id where a.Account = @toAcc";
            command.Parameters.AddWithValue("@toAcc", toAcc);
            var reader = command.ExecuteReader();
            decimal fromAccBalance = 0m;

            while (reader.Read())
            {
                fromAccBalance = !string.IsNullOrEmpty(reader.GetValue(0)?.ToString()) ? reader.GetDecimal(0) : 0;
            }

            reader.Close();
            command.Parameters.Clear();

            if (fromAccBalance > 0m)
            {
                command.Parameters.Clear();

                var toAccId = GetAccointId(toAcc, conString);

                if (toAccId == 0)
                {
                    throw new Exception("Account '\'toAcc'\' not found");
                }

                command.CommandText = $"Update Account set Is_Active = 1 where Id = @toAccId";
                command.Parameters.AddWithValue("@toAccId", toAccId);

                var reader2 = command.ExecuteNonQuery();

                if (reader2 > 0)
                {

                }
            }

            reader.Close();
            command.Parameters.Clear();

            sqlConnection.Close();
            //return fromAccBalance;
        }

        private static void TransferFromToAcc(string fromAcc, string toAcc, decimal amount, string conString)
        {
            if (string.IsNullOrEmpty(fromAcc) || string.IsNullOrEmpty(toAcc) || amount == 0)
            {
                Console.WriteLine("SomeThing went wrong!!!");
                return;
            }

            var connection = new SqlConnection(conString);
            connection.Open();

            SqlTransaction sqlTransaction = connection.BeginTransaction();

            var command = connection.CreateCommand();

            command.Transaction = sqlTransaction;

            try
            {
                command.CommandText = "select sum(t.Amount) from Transactions t left join Account a on t.Account_Id = a.Id where a.Account = @fromAcc";
                command.Parameters.AddWithValue("@fromAcc", fromAcc);
                var reader = command.ExecuteReader();
                var fromBalanceAcc = 0m;

                while (reader.Read())
                {
                    fromBalanceAcc = !string.IsNullOrEmpty(reader.GetValue(0)?.ToString()) ? reader.GetDecimal(0) : 0;
                }

                reader.Close();
                command.Parameters.Clear();

                if (fromBalanceAcc <= 0 || (fromBalanceAcc - amount) < 0)
                {
                    throw new Exception("From account balance not enough amount");
                }

                var fromAccId = GetAccointId(fromAcc, conString);

                if (fromAccId == 0)
                {
                    throw new Exception("Account '\'fromAcc'\' not found");
                }

                command.CommandText = "Insert into Transactions(Account_Id, Amount, Created_At) Values(@accountId, @amount, @createdAt)";
                command.Parameters.AddWithValue("@accountId", fromAccId);
                command.Parameters.AddWithValue("@amount", amount * -1);
                command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                var result1 = command.ExecuteNonQuery();

                var toAccId = GetAccointId(toAcc, conString);

                if (toAccId == 0)
                {
                    throw new Exception("Account '\'toAcc'\' not found");
                }

                command.Parameters.Clear();

                command.CommandText = "Insert into Transactions(Account_Id, Amount, Created_At) Values(@accountId, @amount, @createdAt)";
                command.Parameters.AddWithValue("@accountId", toAccId);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                var result2 = command.ExecuteNonQuery();

                if (result1 == 0 || result2 == 0)
                {
                    throw new Exception("Something went wrong!!!");
                }

                sqlTransaction.Commit();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                sqlTransaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }

        private static int GetAccointId(string number, string conString)
        {
            var accNumber = 0;
            var sqlConnection = new SqlConnection(conString);
            var query = "Select Id from Account where Account = @account";

            var command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue(@"account", number);

            sqlConnection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                accNumber = reader.GetInt32(0);
            }

            sqlConnection.Close();
            reader.Close();
             
            return accNumber;
        }

        private static void CreateAccount(string conString)
        {
            Console.Write("NickName:");

            var account = new Account
            {
                Acount = Console.ReadLine(),
                IsActive = 1,
                CreatedAt = DateTime.Now,
            };

            SqlConnection sqlConnection = new SqlConnection(conString);
            var query = "Insert Into Account(Account, Is_Active, Created_At) Values(@account, @isActive, @createdAt)";

            var command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@account", account.Acount);
            command.Parameters.AddWithValue("@isActive", account.IsActive);
            command.Parameters.AddWithValue("@createdAt", account.CreatedAt);

            sqlConnection.Open();

            var result1 = command.ExecuteNonQuery();

            if (result1 > 0)
            {
                Console.WriteLine("Added Successfully");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            sqlConnection.Close();
        }

        private static void ShowAccounts(string conString)
        {
            Account[] accounts = new Account[0];

            SqlConnection sqlConnection = new SqlConnection(conString);
            var query = "Select Id, Account, Is_Active, Created_At, Updated_At from Account";

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;

            sqlConnection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Account account = new Account { };

                account.Id = int.Parse(reader["Id"].ToString());
                account.Acount = reader["Account"].ToString();
                account.IsActive = int.Parse(reader["Is_Active"].ToString());

                account.CreatedAt = !string.IsNullOrEmpty(reader["Created_At"]?.ToString()) ? DateTime.Parse(reader["Created_At"].ToString()) : null;
                account.UpdatedAt = !string.IsNullOrEmpty(reader["Updated_At"]?.ToString()) ? DateTime.Parse(reader["Updated_At"].ToString()) : null;

                AddClient(ref accounts, account);
            }
            sqlConnection.Close();

            foreach (var account in accounts)
            {
                Console.WriteLine($"ID:{account.Id}, Account:{account.Acount}, Is_Active:{account.IsActive}, " +
                    $"Created_At:{account.CreatedAt}, Updated_At:{account.UpdatedAt}");
            }
        }

        private static void AddClient(ref Account[] accounts, Account account)
        {
            if (accounts == null)
            {
                return;
            }

            Array.Resize(ref accounts, accounts.Length + 1);

            accounts[accounts.Length - 1] = account;
        }

    }
    class Account
    {
        public int Id { get; set; }
        public string Acount { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    class Transactions
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
