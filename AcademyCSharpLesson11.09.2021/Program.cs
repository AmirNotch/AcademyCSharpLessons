using System;
using System.Data.SqlClient;

namespace AcademyCSharpLesson11._09._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите какую функцию вы хотите выполнить: " +
                "\nДобавить Смартфон: 1 " +
                "\nУдалить Смартфон: 2 " +
                "\nВыбрать все Смартфон: 3 " +
                "\nВыбрать один Смартфон по Id: 4 " +
                "\nОбновить Смартфон: 5");

            var choice = Int32.Parse(Console.ReadLine());

            var conString = @"Data source = .\Dev; Initial catalog = ProductDB; Integrated Security = True";

            SqlConnection sqlConnection = new SqlConnection(conString);

            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection is opened!!!");
            }

            switch (choice)
            {
                case 1:
                    Console.Write("ProductName: ");
                    var productName = Console.ReadLine();
                    Console.Write("Manufacturer: ");
                    var manufacturer = Console.ReadLine();
                    Console.Write("ProductCount: ");
                    var productCount = Int32.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    var price = double.Parse(Console.ReadLine());

                    InsertProduct(sqlConnection, new Product
                    {
                        ProductName = productName,
                        Manufacturer = manufacturer,
                        ProductCount = productCount,
                        Price = price
                    });

                    SelectProducts(sqlConnection);
                    break;
                case 2:
                    SelectProducts(sqlConnection);
                    Console.WriteLine();

                    Console.Write("Выберите Id чтобы удалить смартфон:");
                    var iD = Int32.Parse(Console.ReadLine());
                    DeleteProducts(sqlConnection, productId: iD);

                    SelectProducts(sqlConnection);
                    break;
                case 3:
                    SelectProducts(sqlConnection);
                    break;
                case 4:
                    SelectProducts(sqlConnection);
                    Console.WriteLine();
                    Console.Write("Выберите только один Смартфон по Id:");
                    var productId = Int32.Parse(Console.ReadLine());
                    SelectProductsByID(sqlConnection, productId);
                    break;
                case 5:
                    SelectProducts(sqlConnection);

                    Console.Write("Выберите ID смартфона:");
                    var ID = int.Parse(Console.ReadLine());

                    Console.Write("ProductName: ");
                    var productName1 = Console.ReadLine();
                    Console.Write("Manufacturer: ");
                    var manufacturer1 = Console.ReadLine();
                    Console.Write("ProductCount: ");
                    var productCount1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    var price1 = double.Parse(Console.ReadLine());

                    UpdateProducts(sqlConnection, productId: ID, new Product
                    {
                        ProductName = productName1,
                        Manufacturer = manufacturer1,
                        ProductCount = productCount1,
                        Price = price1
                    });

                    SelectProducts(sqlConnection);
                    break;
                default:
                    break;
            }

            sqlConnection.Close();

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("Connection is clossed!!!");
            }
        }

        static void UpdateProducts(SqlConnection sqlConnection, int productId, Product product)
        {
            var sqlQuery = $"" +
                $"UPDATE Products " +
                $"SET " +
                $"ProductName = '{product.ProductName}', " +
                $"Manufacturer = '{product.Manufacturer}', " +
                $"ProductCount = {product.ProductCount}, " +
                $"Price = {product.Price} " +
                $"WHERE ID = {productId};";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = sqlQuery;

            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Product updated successfully!!!");
            }
            else
            {
                Console.WriteLine($"Product with this ID: {productId} not found!!!");
            }

        }

        static void InsertProduct(SqlConnection sqlConnection, Product product)
        {
            var sqlQuery = $"Insert into " +
                $"Products(ProductName, Manufacturer, ProductCount, Price) " +
                $"Values('{product.ProductName}', '{product.Manufacturer}', {product.ProductCount}, {product.Price})";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = sqlQuery;

            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Product added successfully!!!");
            }
        }

        static void DeleteProducts(SqlConnection sqlConnection, int productId)
        {
            var sqlQuery = $"Delete Products Where ID = {productId}";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = sqlQuery;

            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Product delete successfully!!!");
            }
            else
            {
                Console.WriteLine($"Product with this id: {productId} not found!!!");
            }
        }

        static void SelectProductsByID(SqlConnection sqlConnection, int productID)
        {
            var sqlQuery = "" +
                "SELECT " +
                "Products.Id, " +
                "Products.ProductName, " +
                "Products.Manufacturer, " +
                "Products.ProductCount, " +
                "Products.Price " +
                "FROM Products " +
                $"Where Id = {productID}";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = sqlQuery;

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                Console.WriteLine($"Id: {sqlReader.GetValue(0)}, \t" +
                    $" ProductName: {sqlReader.GetValue(1)}, \t" +
                    $" Manufacturer: {sqlReader.GetValue(2)}, \t" +
                    $" ProductCount: {sqlReader.GetValue(3)}, \t" +
                    $" Price: {sqlReader.GetValue(4)}");
            }
            sqlReader.Close();
        }
        static void SelectProducts(SqlConnection sqlConnection)
        {
            var sqlQuery = "" +
                "SELECT " +
                "Products.Id, " +
                "Products.ProductName, " +
                "Products.Manufacturer, " +
                "Products.ProductCount, " +
                "Products.Price, " +
                "Orders.CreatedAt " +
                "FROM Products " +
                "Left Join Orders ON " +
                "Products.ID = Orders.ProductId";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = sqlQuery;

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                Console.WriteLine($"Id: {sqlReader.GetValue(0)}, \t" +
                    $" ProductName: {sqlReader.GetValue(1)}, \t" +
                    $" Manufacturer: {sqlReader.GetValue(2)}, \t" +
                    $" ProductCount: {sqlReader.GetValue(3)}, \t" +
                    $" Price: {sqlReader.GetValue(4)}, \t" +
                    $" CreatedAt: {sqlReader.GetValue(5)}");
            }

            sqlReader.Close();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public String ProductName { get; set; }
        public String Manufacturer { get; set; }
        public int ProductCount { get; set; }
        public double Price { get; set; }
    }
}
