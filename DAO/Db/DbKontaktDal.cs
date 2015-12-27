using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbKontaktDal : IKontaktDal
    {

        public DbDal Db { get; private set; }

        public DbKontaktDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Kontakt kontakt)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Kontakt(vorname, nachname, [E-Mail], firmenname, adresse, plz, ort, telefon, bemerkungen) values (@vorname, @nachname, @email, @firmenname, @adresse, @plz, @ort, @telefon, @bemerkungen); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@vorname", kontakt.Vorname));
                cmd.Parameters.Add(new SqlParameter("@nachname", kontakt.Nachname));
                cmd.Parameters.Add(new SqlParameter("@email", kontakt.Email));
                cmd.Parameters.Add(new SqlParameter("@firmenname", kontakt.Firmenname));
                cmd.Parameters.Add(new SqlParameter("@adresse", kontakt.Adresse));
                cmd.Parameters.Add(new SqlParameter("@plz", kontakt.Plz));
                cmd.Parameters.Add(new SqlParameter("@ort", kontakt.Ort));
                cmd.Parameters.Add(new SqlParameter("@telefon", kontakt.Telefon));
                cmd.Parameters.Add(new SqlParameter("@bemerkungen", kontakt.Bemerkungen));
                kontakt.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Kontakt kontakt)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Kontakt set vorname = @vorname, nachname = @nachname, [E-Mail] = @email, firmenname = @firmenname, adresse = @adresse, plz = @plz, ort = @ort, telefon = @telefon, bemerkungen = @bemerkungen where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kontakt.ID));
                    cmd.Parameters.Add(new SqlParameter("@vorname", kontakt.Vorname));
                    cmd.Parameters.Add(new SqlParameter("@nachname", kontakt.Nachname));
                    cmd.Parameters.Add(new SqlParameter("@email", kontakt.Email));
                    cmd.Parameters.Add(new SqlParameter("@firmenname", kontakt.Firmenname));
                    cmd.Parameters.Add(new SqlParameter("@adresse", kontakt.Adresse));
                    cmd.Parameters.Add(new SqlParameter("@plz", kontakt.Plz));
                    cmd.Parameters.Add(new SqlParameter("@ort", kontakt.Ort));
                    cmd.Parameters.Add(new SqlParameter("@telefon", kontakt.Telefon));
                    cmd.Parameters.Add(new SqlParameter("@bemerkungen", kontakt.Bemerkungen));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Kontakt kontakt)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Kontakt where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", kontakt.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting kontakt with ID = " + kontakt.ID);
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Kontakt> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Kontakt> list = new List<Domain.Kontakt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, vorname, nachname, [E-Mail], firmenname, adresse, plz, ort, telefon, bemerkungen from Kontakt";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKontakt(reader));
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

        public Domain.Kontakt GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kontakt> list = new List<Domain.Kontakt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, vorname, nachname, [E-Mail], firmenname, adresse, plz, ort, telefon, bemerkungen from Kontakt where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseKontakt(reader));
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

        public List<Domain.Kontakt> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Kontakt> list = new List<Domain.Kontakt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, vorname, nachname, [E-Mail], firmenname, adresse, plz, ort, telefon, bemerkungen from Kontakt where lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), vorname)) LIKE @suchtext or lower(convert(nvarchar(max), nachname)) LIKE @suchtext or lower(convert(nvarchar(max), [E-Mail])) LIKE @suchtext or lower(convert(nvarchar(max), firmenname)) LIKE @suchtext or lower(convert(nvarchar(max), adresse)) LIKE @suchtext or lower(convert(nvarchar(max), plz)) LIKE @suchtext or lower(convert(nvarchar(max), ort)) LIKE @suchtext or lower(convert(nvarchar(max), telefon)) LIKE @suchtext or lower(convert(nvarchar(max), bemerkungen)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseKontakt(reader));
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

        protected Domain.Kontakt ParseKontakt(SqlDataReader reader)
        {
            var kon = new Domain.Kontakt();

            kon.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            kon.Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
            kon.Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
            kon.Email = reader.GetString(reader.GetOrdinal("E-Mail"));
            kon.Firmenname = reader.GetString(reader.GetOrdinal("Firmenname"));
            kon.Adresse = reader.GetString(reader.GetOrdinal("Adresse"));
            kon.Plz = reader.GetInt32(reader.GetOrdinal("PLZ"));
            kon.Ort = reader.GetString(reader.GetOrdinal("Ort"));
            kon.Telefon = reader.GetString(reader.GetOrdinal("Telefon"));
            kon.Bemerkungen = reader.GetString(reader.GetOrdinal("Bemerkungen"));

            return kon;
        }

    }
}
