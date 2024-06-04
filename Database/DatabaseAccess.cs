using MySql.Data.MySqlClient;
using System.Data;

public class DataBaseAccess
{
    private readonly string _connectionString;

    public DataBaseAccess(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }
    }

    public object ExecuteScalar(string query, params MySqlParameter[] parameters)
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }
    }

    public MySqlDataReader ExecuteReader(string query, params MySqlParameter[] parameters)
    {
        var connection = new MySqlConnection(_connectionString);
        connection.Open();
        var command = new MySqlCommand(query, connection);
        command.Parameters.AddRange(parameters);
        return command.ExecuteReader(CommandBehavior.CloseConnection);
    }

}
