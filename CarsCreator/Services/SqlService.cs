using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CarsCreator.Services
{
    public class SqlService
    {
        string strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database1.mdf" + ";Integrated Security = True";
        SqlConnection con;
        public SqlService(){
            con = new SqlConnection(strConnection);
        }

        public int GetCarIDbyModel(string m)
        {
            con.Open();
            String cmndStr = "Select id from Cars where fName = \'" + m + "\'";
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                int id = -1;
                if (reader.Read())
                {
                    id = (int)reader.GetValue(0);
                }
                con.Close();
                return id;
            }
            
        }

        public List<string> GetEngiveValueByID(int id)
        {
            con.Open();
            List<string> rez = new List<string>();

            string cmndStr = "Select engineValue from CarsGeneration where carsID = " + id;
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rez.Add(reader.GetValue(0)+"");
                }
            }
            con.Close();
            return rez;
        }

        public int GetPriceOfDiskbyIndex(int ind)
        {
            con.Open();
            int price = 0;
            string cmndStr = "Select price from DiskPrice where idDisk = " + ind;
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (int)reader.GetValue(0);
                }
                
            }
            con.Close();
            return price;
        }

        public int GetPricebyIDandEngine(int id, int eng)
        {
            int price = 0;
            con.Open();
            string cmndStr = "Select price from CarsGeneration where carsID = " + id + "and engineValue = " + eng;
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = (int)reader.GetValue(0);
                }
            }
            con.Close();
            return price;

        }

        public List<string> GetNames()
        {
            List<string> rez = new List<string>();
            con.Open();
            SqlCommand cmnd = new SqlCommand("Select fname from Cars", con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rez.Add(reader.GetValue(0)+"");
                }
            }
            con.Close();

            return rez;
        }
    }
}
