using Entities.Abstracts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.AdoNet.Helpers
{
    public class DbHelper
    {
        public static List<T> CreateReadCommand<T>(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BootCode; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False");
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            return DataReaderMapToList<T>(reader);

        }
        public static List<T> DataReaderMapToList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            T objectToMap = default(T);
            while (reader.Read())
            {
                objectToMap = Activator.CreateInstance<T>();
                foreach (PropertyInfo propertyInfo in objectToMap.GetType().GetProperties())
                {
                    if (!Equals(propertyInfo.Name,DBNull.Value))
                    {
                        propertyInfo.SetValue(objectToMap, reader[propertyInfo.Name], null);
                    }
                }
                list.Add(objectToMap);
            }
            return list;
        }

        public static int CreateWriteConnection<T>(string query,T entity) where T :class, IEntity,new()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BootCode; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False");
            SqlCommand command = new SqlCommand(query,sqlConnection);
            sqlConnection.Open();
            foreach (PropertyInfo propertyInfo in entity.GetType().GetProperties())
            {
                string parameterName = $"@{propertyInfo.Name}";
                if (!query.Contains(parameterName)) continue;
                command.Parameters.AddWithValue(parameterName, propertyInfo.GetValue(entity));
            }
            int affectedRowCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            return affectedRowCount;
        }

    }
}
