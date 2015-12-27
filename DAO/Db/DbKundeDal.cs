using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbKundeDal : IKundeDal
    {
        public DbDal Db { get; private set; }

        public DbKundeDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Kunde kunde)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Kunde(vorname, nachname, [E-Mail], adresse, plz, ort, telefon, bemerkungen) values (@vorname, @nachname, @email, @adresse, @plz, @ort, @telefon, @bemerkungen); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@vorname", kunde.Vorname));
                cmd.Parameters.Add(new SqlParameter("@nachname", kunde.Nachname));
                cmd.Parameters.Add(new SqlParameter("@email", kunde.Email));
                cmd.Parameters.Add(new SqlParameter("@adresse", kunde.Adresse));
                cmd.Parameters.Add(new SqlParameter("@plz", kunde.Plz));
                cmd.Parameters.Add(new SqlParameter("@ort", kunde.Ort));
                cmd.Parameters.Add(new SqlParameter("@telefon", kunde.Telefon));
                cmd.Parameters.Add(new SqlParameter("@bemerkungen", kunde.Bemerkungen));
                kunde.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Kunde kunde)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Kontakt set vorname = @vorname, nachname = @nachname, [E-Mail] = @email, adresse = @adresse, plz = @plz, ort = @ort, telefon = @telefon, bemerkungen = @bemerkungen where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kunde.ID));
                    cmd.Parameters.Add(new SqlParameter("@vorname", kunde.Vorname));
                    cmd.Parameters.Add(new SqlParameter("@nachname", kunde.Nachname));
                    cmd.Parameters.Add(new SqlParameter("@email", kunde.Email));
                    cmd.Parameters.Add(new SqlParameter("@adresse", kunde.Adresse));
                    cmd.Parameters.Add(new SqlParameter("@plz", kunde.Plz));
                    cmd.Parameters.Add(new SqlParameter("@ort", kunde.Ort));
                    cmd.Parameters.Add(new SqlParameter("@telefon", kunde.Telefon));
                    cmd.Parameters.Add(new SqlParameter("@bemerkungen", kunde.Bemerkungen));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Kunde kunde)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Kunde where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kunde.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting kunde with ID = " + kunde.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Kunde> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Kunde> list = new List<Domain.Kunde>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, vorname, nachname, [E-Mail], adresse, plz, ort, telefon, bemerkungen from Kunde";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKunde(reader));
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

        public Domain.Kunde GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kunde> list = new List<Domain.Kunde>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, vorname, nachname, [E-Mail], adresse, plz, ort, telefon, bemerkungen from Kunde where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseKunde(reader));
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

        public List<Domain.Kunde> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kunde> list = new List<Domain.Kunde>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, vorname, nachname, adresse, ort, plz, telefon, [E-Mail], Bemerkungen from Kunde where lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), vorname)) LIKE @suchtext or lower(convert(nvarchar(max), nachname)) LIKE @suchtext or lower(convert(nvarchar(max), adresse)) LIKE @suchtext or lower(convert(nvarchar(max), ort)) LIKE @suchtext or lower(convert(nvarchar(max), plz)) LIKE @suchtext or lower(convert(nvarchar(max), telefon)) LIKE @suchtext or lower(convert(nvarchar(max), [E-Mail])) LIKE @suchtext or lower(convert(nvarchar(max), Bemerkungen)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKunde(reader));
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

        protected Domain.Kunde ParseKunde(SqlDataReader reader)
        {
            var kun = new Domain.Kunde();

            kun.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            kun.Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
            kun.Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
            kun.Email = reader.GetString(reader.GetOrdinal("E-Mail"));
            kun.Adresse = reader.GetString(reader.GetOrdinal("Adresse"));
            kun.Plz = reader.GetInt32(reader.GetOrdinal("PLZ"));
            kun.Ort = reader.GetString(reader.GetOrdinal("Ort"));
            kun.Telefon = reader.GetString(reader.GetOrdinal("Telefon"));
            kun.Bemerkungen = reader.GetString(reader.GetOrdinal("Bemerkungen"));

            return kun;
        }

    }
}
