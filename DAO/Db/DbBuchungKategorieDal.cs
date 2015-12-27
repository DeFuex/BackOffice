using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbBuchungKategorieDal : IBuchungKategorieDal
    {

        public DbDal Db { get; private set; }

        public DbBuchungKategorieDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.BuchungKategorie buchkat)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into [Buchung-Kategorie](buchungszeilenid, kategorieid) values (@buchungszeilenid, @kategorieid); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", buchkat.BuchungszeilenID));
                cmd.Parameters.Add(new SqlParameter("@kategorieid", buchkat.KategorieID));
                buchkat.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.BuchungKategorie buchkat)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update [Buchung-Kategorie] set buchungszeilenid = @buchungszeilenid, kategorieid = @kategorieid where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", buchkat.ID));
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", buchkat.BuchungszeilenID));
                    cmd.Parameters.Add(new SqlParameter("@kategorieid", buchkat.KategorieID));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Buchungszeile bz, Domain.Kategorie kat)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from [Buchung-Kategorie] where BuchungszeilenID = @buchungszeilenid and kategorieid = @kategorieid"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", bz.ID));
                    cmd.Parameters.Add(new SqlParameter("@kategorieid", kat.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting buchung-kategorie with KategorieID = " + kat.ID + " and BuchungsID = " + bz.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.BuchungKategorie> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.BuchungKategorie> list = new List<Domain.BuchungKategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, buchungszeilenid, kategorieid from [Buchung-Kategorie]";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseBuchungKategorie(reader));
                        }
                    }

                    return list;
                }
            }
            finally
            {
                Db.UnuseConnection();
            }

        }

        public Domain.BuchungKategorie GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.BuchungKategorie> list = new List<Domain.BuchungKategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, buchungszeilenid, kategorieid from [Buchung-Kategorie] where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseBuchungKategorie(reader));
                        }
                    }

                    return list.Single(); //single liefert einem ein Element aus der Liste zurück...wenn in der Liste nicht genau ein Element vorhanden ist, wird eine Exception geworfen.
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        protected Domain.BuchungKategorie ParseBuchungKategorie(SqlDataReader reader)
        {
            var buchkat = new Domain.BuchungKategorie();

            buchkat.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            buchkat.BuchungszeilenID = reader.GetInt64(reader.GetOrdinal("BuchungszeilenID"));
            buchkat.KategorieID = reader.GetInt64(reader.GetOrdinal("KategorieID"));

            return buchkat;
        }

    }
}
