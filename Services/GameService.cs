using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_de_Jeu.Services
{
    using System;
    using System.Data;
    using MySql.Data.MySqlClient;

    public class GameService
    {
        public DataTable GetAllGames()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM games ORDER BY DateAdded DESC";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public bool AddGame(string name, string description, int minPlayers, int maxPlayers, int numberOfCards)
        {
            string query = @"INSERT INTO games (Name, Description, MinPlayers, MaxPlayers, NumberOfCards, DateAdded)
                         VALUES (@name, @description, @minPlayers, @maxPlayers, @numberOfCards, @dateAdded)";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@minPlayers", minPlayers);
                    command.Parameters.AddWithValue("@maxPlayers", maxPlayers);
                    command.Parameters.AddWithValue("@numberOfCards", numberOfCards);
                    command.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateGame(int id, string name, string description, int minPlayers, int maxPlayers, int numberOfCards)
        {
            string query = @"UPDATE games SET Name = @name, Description = @description, 
                         MinPlayers = @minPlayers, MaxPlayers = @maxPlayers, NumberOfCards = @numberOfCards
                         WHERE Id = @id";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@minPlayers", minPlayers);
                    command.Parameters.AddWithValue("@maxPlayers", maxPlayers);
                    command.Parameters.AddWithValue("@numberOfCards", numberOfCards);
                    command.Parameters.AddWithValue("@id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteGame(int id)
        {
            string query = "DELETE FROM games WHERE Id = @id";
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }

}
