using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
  class Program
  {
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r$#@;TrustServerCertificate=True";

    static void Main(string[] args)
    {
      var connection = new SqlConnection(CONNECTION_STRING);
      connection.Open();
      ReadWithRoles(connection);
      // ReadUsers(connection);
      // ReadRoles(connection);
      // ReadTags(connection);
      connection.Close();
    }

    public static void ReadUsers(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }
    
    public static void ReadRoles(SqlConnection connection)
    {
      var repository = new Repository<Role>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }
    
    public static void ReadTags(SqlConnection connection)
    {
      var repository = new Repository<Tag>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }
    
    public static void DeleteUser(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      repository.Delete(1);

      Console.WriteLine("Registro excluido com sucesso!");
    }
    
    private static void ReadWithRoles(SqlConnection connection)
    {
      var repository = new UserRepository(connection);
      var users = repository.ReadWithRole();

      foreach (var user in users)
      {
        Console.WriteLine(user.Email);
        foreach (var role in user.Roles) 
          Console.WriteLine($" - {role.Slug}");
      }
    }
  }
}