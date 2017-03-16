using RappiChallenge.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace RappiChallenge.Persistence.CubePersistence.MySql
{
    public class MySqlDAL
    {
        private static string DB_AppSetting = "Database";

		public static PointTO MapItem(DataRow row)
		{
			PointTO item = null;
			item = new PointTO();

			if (row["X"].GetType() != typeof(DBNull))
			{
				item.X = Convert.ToInt32(row["X"]);
			}
			if (row["Y"].GetType() != typeof(DBNull))
			{
				item.Y = Convert.ToInt32(row["Y"]);
			}
			if (row["Z"].GetType() != typeof(DBNull))
			{
				item.Z = Convert.ToInt32(row["Z"]);
			}
			if (row["NodeValue"].GetType() != typeof(DBNull))
			{
				item.Value = Convert.ToInt32(row["NodeValue"]);
			}
			if (row["ID"].GetType() != typeof(DBNull))
			{
				item.ID = Convert.ToInt32(row["ID"]);
			}
			
			return item;
		}

		public static List<PointTO> GetAll()
        {
            List<PointTO> items = new List<PointTO>();

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings[DB_AppSetting]);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Core_GetAllCube", connection);
			adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable results = new DataTable();

            adapter.Fill(results);

            foreach (DataRow row in results.Rows)
            {
                PointTO item = MapItem(row);
                items.Add(item);
            }

            return items;
        }

        public static void Update(PointTO item)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings[DB_AppSetting]);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Core_UpdateCube", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			
			
						MySqlParameter paramX = new MySqlParameter("pX", item.X);
            paramX.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramX);
					MySqlParameter paramY = new MySqlParameter("pY", item.Y);
            paramY.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramY);
					MySqlParameter paramZ = new MySqlParameter("pZ", item.Z);
            paramZ.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramZ);
					MySqlParameter paramNodeValue = new MySqlParameter("pNodeValue", item.Value);
            paramNodeValue.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramNodeValue);
					MySqlParameter paramID = new MySqlParameter("pID", item.ID);
            paramID.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramID);
		
            DataTable results = new DataTable();
            adapter.Fill(results);
        }

        public static int Create(PointTO item)
        {
           MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings[DB_AppSetting]);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Core_CreateCube", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			
			
						MySqlParameter paramX = new MySqlParameter("pX", item.X);
            paramX.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramX);
					MySqlParameter paramY = new MySqlParameter("pY", item.Y);
            paramY.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramY);
					MySqlParameter paramZ = new MySqlParameter("pZ", item.Z);
            paramZ.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramZ);
					MySqlParameter paramNodeValue = new MySqlParameter("pNodeValue", item.Value);
            paramNodeValue.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramNodeValue);
					MySqlParameter paramID = new MySqlParameter("pID", item.ID);
            paramID.Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters.Add(paramID);
		
            DataTable results = new DataTable();
            adapter.Fill(results);

			if(results.Rows.Count > 0)
			{
				return Convert.ToInt32(results.Rows[0]["ID"]);
			}else{
				throw new Exception("Error creating Cube");
			}
        }

        public static void Delete()
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings[DB_AppSetting]);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Core_DeleteCube", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable results = new DataTable();
            adapter.Fill(results);
        }
    }
}
