using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UserInterfaceV2
{
    class DataHandler
    {
        public string Q = "Data Source=.;Initial Catalog=FlightSimulation;Integrated Security=True";
        public string P = "User.txt";
        
        public void PlayerWrite(List<Player> UserWriter)
        {
            if (File.Exists(P))
            {
                FileStream stream = new FileStream(P, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                foreach (Player user in UserWriter)
                {
                    writer.WriteLine(user.StartTime + "," + user.UserName + "," + user.EndTime);
                }

                writer.Close();
                stream.Close();
            }
            else
            {
                FileStream stream = new FileStream(P, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                foreach (Player user in UserWriter)
                {
                    writer.WriteLine(user.StartTime + "," + user.UserName + "," + user.EndTime);
                }

                writer.Close();
                stream.Close();
            }
        }

        
        public string PicTB64(Image pic, System.Drawing.Imaging.ImageFormat picFormat)
        {
            using (MemoryStream memorystream = new MemoryStream())
            {
                //this saves the image in the specified stream, in the specified format
                pic.Save(memorystream, picFormat);
                byte[] picBytes = memorystream.ToArray();
                string b64s = Convert.ToBase64String(picBytes);
                return b64s;
            }
        }

       
        public Image B64TPic(string b64s)
        {
            byte[] picBytes = Convert.FromBase64String(b64s);
            MemoryStream memorystream = new MemoryStream(picBytes, 0, picBytes.Length);
            memorystream.Write(picBytes, 0, picBytes.Length);
            //This uses an image from the specified data stream
            Image image = Image.FromStream(memorystream, true);
            return image;
        }

        public List<Player> UserRead() //this reads the user table in the db
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            List<Player> play = new List<Player>();
            try
            {
                conn = new SqlConnection(Q);
                conn.Open();
                string select = "SELECT * FROM Users";
                cmd = new SqlCommand(select, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    play.Add(new Player(reader[1].ToString(), reader[2].ToString()));
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return play;
        }


        public List<EnemyBaseObj> ObjReader() //this reads the enemy base objects table in db
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            string R;
            List<EnemyBaseObj> obj = new List<EnemyBaseObj>();
            try
            {
                conn = new SqlConnection(Q);
                conn.Open();
                R = "SELECT * FROM Objects";
                cmd = new SqlCommand(R, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] bytes = (byte[])reader[3];
                    obj.Add(new EnemyBaseObj((int)reader[0], reader[1].ToString(), (int)reader[2], ImageConverter(bytes)));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return obj;

        }

        public Image ImageConverter(byte[] arr)
        {
            MemoryStream memorystream = new MemoryStream(arr);
            Image rImg = Image.FromStream(memorystream);
            return rImg;
        }

        public BomberPlane BomberReader(int invNeeded)// this reads to the bomb table in db
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            BomberPlane bomber = null;
            string Selection = null;
            string R;
            if (invNeeded == 1)
            {
                Selection = "WHERE BomberID = 1";
            }
            else if (invNeeded <= 3)
            {
                Selection = "WHERE BomberID = 2";
            }
            else
            {
                Selection = "WHERE BomberID = 3";
            }
            
            try
            {
                conn = new SqlConnection(Q);
                conn.Open();
                R = "SELECT * FROM Bomber "+Selection;
                cmd = new SqlCommand(R, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] bytes = (byte[])reader[4];
                    bomber = new BomberPlane(reader[1].ToString().Trim(),(int)reader[2], (int)reader[3],ImageConverter(bytes));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return bomber;
            
        }

        public List<PlaneScouts> PlaneScoutReader() // this reads to the plane table in the dbo
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;
            string R;
            List<PlaneScouts> planeScoutList = new List<PlaneScouts>();
            try
            {
                conn = new SqlConnection(Q);
                conn.Open();
                R = "SELECT * FROM Plane";
                cmd = new SqlCommand(R, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] bytes = (byte[])reader[1];
                    planeScoutList.Add(new PlaneScouts(ImageConverter(bytes), reader[2].ToString().Trim(), (int)reader[3]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return planeScoutList;
        }

        public void ReportWriter(int damage, DateTime strikeTime, string enemiesHit, int fuelUsed, string inventoryBefore, string inventoryUsed, int flightDuration, int averageSpeed, int distanceTraveled)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            string R;
            try
            {
                conn = new SqlConnection(Q);
                conn.Open();
                R = "Insert INTO Report(DamagePercentage,StrikeTime,BuildingsStruck,FuelUsage,InventoryBefore,InventoryUsed,FlightDuration,AverageSpeed,DistanceTraveled) VALUES (@damage,@time,@buildings,@fuelUsed,@invBefore,@invUsed,@flightDuration,@speed,@distance)";
                cmd = new SqlCommand(R, conn);
                cmd.Parameters.AddWithValue("@damage", damage);
                cmd.Parameters.AddWithValue("@time", strikeTime);
                cmd.Parameters.AddWithValue("@buildings", enemiesHit);
                cmd.Parameters.AddWithValue("@fuelUsed", fuelUsed);
                cmd.Parameters.AddWithValue("@invBefore", inventoryBefore);
                cmd.Parameters.AddWithValue("@invUsed", inventoryUsed);
                cmd.Parameters.AddWithValue("@flightDuration", flightDuration);
                cmd.Parameters.AddWithValue("@speed", averageSpeed);
                cmd.Parameters.AddWithValue("@distance", distanceTraveled);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
