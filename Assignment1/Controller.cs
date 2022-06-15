using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Assignment1
{
    public class Controller
    {
        public void ReadData()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> productList = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product((string)sqlDataReader[1], (string)sqlDataReader[2], (decimal)sqlDataReader[3]);
                productList.Add(product);
            }

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i].ToString());
            }


            connection.Close();
        }

        public void CreateData()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "INSERT INTO product VALUES(@proName,@proDesc,@price)";

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Please Enter Product's Name: ");
            sqlCommand.Parameters.AddWithValue("@proName", Console.ReadLine());
            Console.WriteLine("Please Enter Product's Description: ");
            sqlCommand.Parameters.AddWithValue("@proDesc", Console.ReadLine());
            Console.WriteLine("Please Enter Product's Price: ");
            sqlCommand.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Insert thanh cong");
        }

        public void EditData()
        {
            int choice;
            Console.WriteLine("Where do you want to edit? ");
            Console.WriteLine("1. Product's Name");
            Console.WriteLine("2. Product's Description");
            Console.WriteLine("3. Product's Price");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EditName();
                    break;
                case 2:
                    EditDesc();
                    break;
                case 3:
                    EditPrice();
                    break;
                case 4:
                    ReadData();
                    break;
            }

        }
        public void EditName()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();


            string query = "UPDATE product SET proName = @Name  WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's ID to change it's name: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your new Product's name: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }
        public void EditDesc()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "UPDATE product SET proDesc = @Desc  WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's ID to change it's description: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your new Product's description: ");
            sqlCommand.Parameters.AddWithValue("@Desc", Console.ReadLine());

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }
        public void EditPrice()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();


            string query = "UPDATE product SET price = @price  WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's name to change it's price: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());
            Console.WriteLine("Please enter your new Product's price");
            sqlCommand.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }

        public void DeleteData()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "DELETE product WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter the product's name to delete it: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Delete thanh cong");
        }

        public void SearchByID()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter your Product's ID you want to search: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + "||| Product Description: " + sqlDataReader[2] + " |||Product Price: " + sqlDataReader[3]);
            }

            connection.Close();
        }

        public void SearchByName()
        {
            ConnectionDb connectionDB = new ConnectionDb();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter your Product's name you want to search: ");
            sqlCommand.Parameters.AddWithValue("@Name", (Console.ReadLine()));

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + "||| Product Description: " + sqlDataReader[2] + " |||Product Price: " + sqlDataReader[3]);
            }

            connection.Close();
        }


    }
}
    
        
    

