using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        private SqlCommand command;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Januar2023;Integrated Security=True;");
            command = new SqlCommand("", connection);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        internal List<Profesor> VratiBrojPoZvanju()
        {
            command.CommandText = "select zvanje, count(*) as broj_profesora from Profesor group by zvanje;";
            List<Profesor> profesori = new List<Profesor>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Profesor profesor = new Profesor
                {
                    Zvanje = (ZvanjeProfesora)reader.GetInt32(0),
                    BrojAngazovanja = reader.GetInt32(1)
                };
                profesori.Add(profesor);
            }
            reader.Close();
            return profesori;
        }

        internal List<Profesor> VratiProfesoreSaBrojemPredmeta()
        {
            command.CommandText = "select pr.ime, pr.prezime, pr.zvanje, count(*) as Broj_predmeta from angazovanje a join predmet p on (a.predmetId = p.predmetId) join Profesor pr on (a.profesorId = pr.profesorId) group by pr.ime, pr.prezime, pr.zvanje";
            List<Profesor> profesori = new List<Profesor>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Profesor profesor = new Profesor
                {
                    Ime = reader.GetString(0),
                    Prezime = reader.GetString(1),
                    Zvanje = (ZvanjeProfesora)reader.GetInt32(2),
                    BrojAngazovanja = reader.GetInt32(3)
                };
                profesori.Add(profesor);
            }
            reader.Close();
            return profesori;
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        internal List<Predmet> VratiSvePredmete()
        {
            command.CommandText = "select * from predmet";
            List<Predmet> predmeti = new List<Predmet>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Predmet predmet = new Predmet
                {
                    PredmetId = reader.GetInt32(0),
                    SifraPredmeta = reader.GetString(1),
                    NazivPredmeta = reader.GetString(2),
                    KodPredmeta = reader.GetString(3),
                    BrojESPB = reader.GetInt32(4)
                };
                predmeti.Add(predmet);
            }
            reader.Close();
            return predmeti;
        }

        internal void UpdateAngazovanje(Angazovanje angazovanje)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update angazovanje set [datum] = (@datum) where predmetid = {angazovanje.Predmet.PredmetId} and profesorid = {angazovanje.Profesor.ProfesorId}";
            command.Parameters.AddWithValue("@datum", angazovanje.Datum);
            command.ExecuteNonQuery();
        }

        internal void ObrisiAngazovanje(Angazovanje angazovanje)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from angazovanje where predmetid = {angazovanje.Predmet.PredmetId} and profesorid = {angazovanje.Profesor.ProfesorId}";
            command.ExecuteNonQuery();
        }

        internal List<Angazovanje> VratiAngazovanja()
        {
            command.CommandText = "select * from Angazovanje a join predmet p on (a.predmetId = p.predmetId) join Profesor pr on (a.profesorId = pr.profesorId)";
            List<Angazovanje> angazovanja = new List<Angazovanje>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Angazovanje angazovanje = new Angazovanje
                {
                    Datum = reader.GetString(2),
                    Predmet = new Predmet
                    {
                        PredmetId = reader.GetInt32(0),
                        SifraPredmeta = reader.GetString(5),
                        NazivPredmeta = reader.GetString(6),
                        KodPredmeta = reader.GetString(7),
                        BrojESPB = reader.GetInt32(8)
                    },
                    Profesor = new Profesor
                    {
                        ProfesorId = reader.GetInt32(1),
                        Ime = reader.GetString(10),
                        Prezime = reader.GetString(11),
                        Zvanje = (ZvanjeProfesora)reader.GetInt32(12)
                    }
                };
                angazovanja.Add(angazovanje);
            }
            reader.Close();
            return angazovanja;
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        internal void DodajProfesora(Profesor profesor)
        {
            command.CommandText = "insert into Profesor values (@ime, @prezime, @zvanje, @email)";
            command.Parameters.AddWithValue("@ime", profesor.Ime);
            command.Parameters.AddWithValue("@prezime", profesor.Prezime);
            command.Parameters.AddWithValue("@zvanje", profesor.Zvanje);
            command.Parameters.AddWithValue("@email", profesor.EmailKorisnika);
            command.ExecuteNonQuery();
        }

        internal List<Profesor> VratiProfesore()
        {
            command.CommandText = "select * from profesor";
            List<Profesor> profesori = new List<Profesor>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Profesor profesor = new Profesor
                {
                    ProfesorId = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Zvanje = (ZvanjeProfesora)reader.GetInt32(3),
                    EmailKorisnika = reader.GetString(4)
                };
                profesori.Add(profesor);
            }
            reader.Close();
            return profesori;
        }

        internal void DodajAngazovanje(Angazovanje angazovanje)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "insert into angazovanje values (@predmetid, @profesorid, @datum, @emailkorisnika)";
            command.Parameters.AddWithValue("@predmetid", angazovanje.Predmet.PredmetId);
            command.Parameters.AddWithValue("@profesorid", angazovanje.Profesor.ProfesorId);
            command.Parameters.AddWithValue("@datum", angazovanje.Datum);
            command.Parameters.AddWithValue("@emailkorisnika", angazovanje.EmailKorisnika);
            command.ExecuteNonQuery();
        }

        internal List<Predmet> VratiPredmete(Profesor profesor)
        {
            command.CommandText = $"select * from angazovanje a join predmet p on (a.predmetId = p.predmetId) join Profesor pr on (a.profesorId = pr.profesorId) where a.profesorId = {profesor.ProfesorId}";
            List<Predmet> predmeti = new List<Predmet>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Predmet predmet = new Predmet
                {
                    SifraPredmeta = reader.GetString(5),
                    NazivPredmeta = reader.GetString(6),
                    KodPredmeta = reader.GetString(7),
                    BrojESPB = reader.GetInt32(8),
                };
                predmeti.Add(predmet);
            }
            reader.Close();
            return predmeti;
        }

        internal int VratiPredmetId()
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "select max(predmetid) from predmet";
            object maxId = command.ExecuteScalar();
            return (int)maxId;
        }

        internal void DodajPredmet(Predmet predmet)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = "insert into predmet values (@sifrapredmeta, @nazivpredmeta, @kodpredmeta, @brojespb)";
            command.Parameters.AddWithValue("@sifrapredmeta", predmet.SifraPredmeta);
            command.Parameters.AddWithValue("@nazivpredmeta", predmet.NazivPredmeta);
            command.Parameters.AddWithValue("@kodpredmeta", predmet.KodPredmeta);
            command.Parameters.AddWithValue("@brojespb", predmet.BrojESPB);
            command.ExecuteNonQuery();
        }
    }
}
