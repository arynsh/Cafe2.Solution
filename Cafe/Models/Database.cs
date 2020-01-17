using System;
using MySql.Data.MySqlClient;
using Cafe;

namespace Cafe.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
    //   MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;database=cafe;uid=root;pwd=epicodus;");
      return conn;
    }
  }
}