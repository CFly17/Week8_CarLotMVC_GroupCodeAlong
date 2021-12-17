using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week8_CarLot.Models
{
    public class CarownerDAL
    {
        public Carowner GetCarowner(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from carowners where id=" + id;
                connect.Open();
                Carowner c = connect.Query<Carowner>(sql).First();
                connect.Close();
                return c;
            }
        }

        public List<Carowner> GetCarowners()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from carowners;";
                connect.Open();
                List<Carowner> carowners = connect.Query<Carowner>(sql).ToList();
                connect.Close();
                return carowners;
            }
        }
        
        public void CreateCarowner(Carowner c)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into carOwners values (0, '{c.FirstName}', '{c.LastName}')";
                connect.Open();
                connect.Query<Carowner>(sql);
                connect.Close();
            }
        }
        public void DeleteCarowner(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "delete from carOwners where id=" + id;
                connect.Open();
                connect.Query<Carowner>(sql);
                connect.Close();
            }
        }
        public void UpdateCar(Carowner c)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "update carowners " +
                    $"set firstName= '{c.FirstName}', lastName='{c.LastName}'" +
                    $" where id={c.Id} ";
                connect.Open();
                connect.Query<Carowner>(sql);
                connect.Close();
            }
        }

    }
}
