using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = 
"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			Console.WriteLine(connection_string);

			ExecuteReaderQuery(connection_string, "SELECT movie_id, title, release_date, first_name,second_name FROM Movies, Directors WHERE director=director_id");

			string movieCount = ExecuteScalarQuery(connection_string, "SELECT COUNT(*) FROM Movies");
			Console.WriteLine(movieCount);

			int id_director = Convert.ToInt32(ExecuteScalarQuery(connection_string, "SELECT director_id FROM Directors WHERE first_name = 'Louis'"));

			Console.WriteLine
				(
					$"Фильм, который снял {ExecuteScalarQuery(connection_string, $"SELECT first_name + ' ' + second_name FROM Directors WHERE director_id = {id_director}")}\t" +
					$"Называется\t" +
					$"{ExecuteScalarQuery(connection_string, $"SELECT title FROM Movies WHERE director = {id_director}")}"
				);
		}
		static void ExecuteReaderQuery(string ConnectionString, string query)
		{ 
			SqlConnection Connection = new SqlConnection(ConnectionString);
			Connection.Open();

			SqlCommand Command = new SqlCommand(query, Connection);

			SqlDataReader reader = Command.ExecuteReader();
			for(int i = 0; i < reader.FieldCount; i++)
				Console.Write($"{reader.GetName(i)}\t");
			Console.WriteLine();

			while(reader.Read())
			{
				for(int i = 0; i < reader.FieldCount; i++)
					Console.Write($"{reader[i]}\t\t");
				Console.WriteLine();
			}
			reader.Close();
			Connection.Close();
			Command.Dispose();
		}
		static string ExecuteScalarQuery(string ConnectionString, string query)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnectionString);
			sqlConnection.Open();

			SqlCommand command = new SqlCommand(query, sqlConnection);
			//command.CommandText = query;

			string result = command.ExecuteScalar().ToString();
			command.Dispose();
			sqlConnection.Close();
			return result;
		}
	}
}
