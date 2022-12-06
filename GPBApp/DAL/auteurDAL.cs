using GPBApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GPBApp.DAL
{
    public class auteurDAL
    {
        public auteurDAL() { }

        public int CreateAuteur(autuerEntity autuerEntity)
        {
            string query = "INSERT INTO auteur (id_auteur ,id_member ) VALUES ("+autuerEntity.id_auteur+","+autuerEntity.id_membre+")";


            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            conn.cmd.ExecuteNonQuery();
            conn.BDconn.Close();

            return 1;
        }

        public autuerEntity GetAutuer(int id)
        {
            string query = "SELECT * FROM auteur WHERE id = " + id;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            var reader = conn.cmd.ExecuteReader();
            autuerEntity autuerEntity = new autuerEntity();

            while(reader.Read())
            {
                autuerEntity.id_auteur = int.Parse(reader.GetValue(0).ToString());
                autuerEntity.id_membre = int.Parse(reader.GetValue(1).ToString());
            }
            conn.BDconn.Close();
            return autuerEntity;
        }

        public int GetLength()
        {
            string query = "SELECT count(*) FROM auteur";
            int length = 0;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            var reader = conn.cmd.ExecuteReader();

            while(reader.Read())
            {
                length = reader.GetInt32(0);
            }
            return length;
        }
    }
}
