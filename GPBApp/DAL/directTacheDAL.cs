using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GPBApp.entity;
using System.Data.SqlClient;

namespace GPBApp.DAL
{
    public class directTacheDAL
    {
        public directTacheDAL() 
        { 
        
        }

        public int CreateDirectTache(directTacheEntity directTacheEntity)
        {
            string query = "INSERT INTO directtache(id_directtache, nom_direct, descrition_direct, date_direct, duree_direct, id_projet) VALUES (" + directTacheEntity.id_direct_tache + "','" + directTacheEntity.nom_direct+"','" +directTacheEntity.description_direct+ "','" +directTacheEntity.date_direct+ "','" +directTacheEntity.duree_direct+ "','" +directTacheEntity.id_projet+"')";
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            conn.cmd.ExecuteNonQuery();
            conn.BDconn.Close();
            return 1;
        }

        public int DeleteDirectTache(int id)
        {
            string query = "DELETE FROM directtache where id_directtache = "+id;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            conn.cmd.ExecuteNonQuery();
            conn.BDconn.Close();

            return 1;
        }

        public int UpdateDirectTache(directTacheEntity directTacheEntity)
        {
            string query = "UPDATE directtache set nom_direct = '" + directTacheEntity.nom_direct + "', descrition_direct = '" + directTacheEntity.description_direct + "',date_direct= '"  + directTacheEntity.date_direct +"' , duree_direct = '"+directTacheEntity.duree_direct+"' , id_projet = " + directTacheEntity.id_projet;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            conn.cmd.ExecuteNonQuery();
            conn.BDconn.Close();
            return 1;
        }

        public directTacheEntity GetDirectTacheEntity(int id)
        {
            string query = "SELECT * FROM directtache WHERE id = " +id;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            var reader = conn.cmd.ExecuteReader();
            directTacheEntity directTacheEntity = new directTacheEntity();


            while (reader.Read())
            {
                directTacheEntity = new directTacheEntity(int.Parse(reader.GetValue(0).ToString()),reader.GetValue(1).ToString(), reader.GetValue(2).ToString(),DateTime.Today, reader.GetValue(4).ToString(), int.Parse(reader.GetValue(5).ToString()));
                break;
            }
            conn.BDconn.Close();
            return directTacheEntity;
        }

        public int GetLength()
        {
            string query = "SELECT count(*) FROM directtache";
            int length = 0;
            conn.BDconn.Open();
            conn.cmd = conn.BDconn.CreateCommand();
            conn.cmd.CommandText = query;
            var reader = conn.cmd.ExecuteReader();

            while(reader.Read())
            {
                length = reader.GetInt32(0);
                break;
            }
            conn.BDconn.Close();
            return length;
        }
    }
}
