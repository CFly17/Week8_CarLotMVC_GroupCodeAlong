using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;

namespace Week8_CarLot.Models
{
    public class CarDAL
    {
        public Car GetCar(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from cars where id=" +id;
                connect.Open();
                Car c = connect.Query<Car>(sql).First();
                connect.Close();
                return c;
            }
        }

        public List<Car> GetCars()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from cars;";
                connect.Open();
                List<Car> cars = connect.Query<Car>(sql).ToList();
                connect.Close();
                return cars;
            }
        }

        public void CreateCar(Car c)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into cars values (0, '{c.Make}', '{c.Model}', {c.Year}, {c.IsNew});";
                connect.Open();
                connect.Query<Car>(sql);
                connect.Close();
            }
        }

        public void UpdateCar(Car c)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update cars set make = '{c.Make}', model = '{c.Model}', `year` = {c.Year}, isNew = {c.IsNew} where id=" +c.Id;
                connect.Open();
                connect.Query<Car>(sql);
                connect.Close();
            }
        }

        public void DeleteCar(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"delete from cars where id=" + id;
                connect.Open();
                connect.Query<Car>(sql);
                connect.Close();
            }
        }

    }
}
