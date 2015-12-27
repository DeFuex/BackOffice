using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbKategorieDal : IKategorieDal
    {

        public DbDal Db { get; private set; }

        public DbKategorieDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Kategorie kategorie)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Kategorie(kategorie) values (@kategorie); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@kategorie", kategorie.KategorieTyp));
                kategorie.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Kategorie kategorie)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Kategorie set kategorie = @kategorie where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kategorie.ID));
                    cmd.Parameters.Add(new SqlParameter("@kategorie", kategorie.KategorieTyp));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Kategorie kategorie)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Kategorie where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kategorie.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting kategorie with ID = " + kategorie.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Kategorie> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Kategorie> list = new List<Domain.Kategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, kategorie from Kategorie";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKategorie(reader));
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

        public List<Domain.Kategorie> GetAllByBuchung(long inputid)
        {

            Db.UseConnection();
            try
            {
                List<Domain.Kategorie> list = new List<Domain.Kategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select b.id, b.kategorie from [Buchung-Kategorie] as a, Kategorie as b where a.buchungszeilenid = @buchungszeilenid and b.id = a.kategorieid";
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", inputid));

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKategorie(reader));
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

        public Domain.Kategorie GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kategorie> list = new List<Domain.Kategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, kategorie from Kategorie where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseKategorie(reader));
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

        public List<Domain.Kategorie> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kategorie> list = new List<Domain.Kategorie>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    // cmd.CommandText = "select id, kategorie from Angebot where replace(lower(convert(nvarchar(max), summe)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), dauer)) LIKE @suchtext or replace(lower(convert(nvarchar(max), chance)), '.', ',') LIKE @suchtext or lower(dbo.dateToString(datum)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKategorie(reader));
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

        protected Domain.Kategorie ParseKategorie(SqlDataReader reader)
        {
            var kat = new Domain.Kategorie();

            kat.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            kat.KategorieTyp = reader.GetString(reader.GetOrdinal("Kategorie"));

            return kat;
        }

    }
}
