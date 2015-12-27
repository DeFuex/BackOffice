using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbEingangsrechnungDal : IEingangsrechnungDal
    {

        public DbDal Db { get; private set; }

        public DbEingangsrechnungDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Eingangsrechnung eingangsrechnung)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Eingangsrechnung(summe, datum, beschreibung, offen, kontaktid) values (@summe, @datum, @beschreibung, @offen, @kontaktid); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@summe", (double)eingangsrechnung.Summe));
                cmd.Parameters.Add(new SqlParameter("@datum", eingangsrechnung.Datum));
                cmd.Parameters.Add(new SqlParameter("@beschreibung", eingangsrechnung.Beschreibung));
                cmd.Parameters.Add(new SqlParameter("@offen", eingangsrechnung.Offen));
                cmd.Parameters.Add(new SqlParameter("@kontaktid", eingangsrechnung.KontaktID));
                eingangsrechnung.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Eingangsrechnung eingangsrechnung)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Eingangsrechnung set summe = @summe, datum = @datum, beschreibung = @beschreibung, offen = @offen, kontaktid = @kontaktid where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", eingangsrechnung.ID));
                    cmd.Parameters.Add(new SqlParameter("@summe", (double)eingangsrechnung.Summe));
                    cmd.Parameters.Add(new SqlParameter("@datum", eingangsrechnung.Datum));
                    cmd.Parameters.Add(new SqlParameter("@beschreibung", eingangsrechnung.Beschreibung));
                    cmd.Parameters.Add(new SqlParameter("@offen", eingangsrechnung.Offen));
                    cmd.Parameters.Add(new SqlParameter("@kontaktid", eingangsrechnung.KontaktID));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Eingangsrechnung eingangsrechnung)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Eingangsrechnung where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", eingangsrechnung.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting eingangsrechnung with ID = " + eingangsrechnung.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Eingangsrechnung> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Eingangsrechnung> list = new List<Domain.Eingangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, summe, datum, beschreibung, offen, kontaktid from Eingangsrechnung";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseEingangsrechnung(reader));
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

        public List<Domain.Eingangsrechnung> GetAllByBuchung(long inputid)
        {

            Db.UseConnection();
            try
            {
                List<Domain.Eingangsrechnung> list = new List<Domain.Eingangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select b.id, b.summe, b.datum, b.beschreibung, b.offen, b.kontaktid, from [Rechnung-Buchung] as a, Eingangsrechnung as b where a.rechnungstyp = @rechnungstyp and a.rechnungsid = @rechnungsid";
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", inputid));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", "Eingang"));

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseEingangsrechnung(reader));
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

        public Domain.Eingangsrechnung GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Eingangsrechnung> list = new List<Domain.Eingangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, summe, datum, beschreibung, offen, kontaktid from Eingangsrechnung where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseEingangsrechnung(reader));
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

        public List<Domain.Eingangsrechnung> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Eingangsrechnung> list = new List<Domain.Eingangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, summe, datum, beschreibung, offen, kontaktid from Eingangsrechnung where replace(lower(convert(nvarchar(max), summe)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), beschreibung)) LIKE @suchtext or lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), kontaktid)) LIKE @suchtext or lower(dbo.Function1(datum)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseEingangsrechnung(reader));
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

        protected Domain.Eingangsrechnung ParseEingangsrechnung(SqlDataReader reader)
        {
            var er = new Domain.Eingangsrechnung();

            er.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            er.Summe = reader.GetDouble(reader.GetOrdinal("Summe"));
            er.Datum = reader.GetDateTime(reader.GetOrdinal("Datum"));
            er.Beschreibung = reader.GetString(reader.GetOrdinal("Beschreibung"));
            er.Offen = reader.GetBoolean(reader.GetOrdinal("Offen"));
            er.KontaktID = reader.GetInt64(reader.GetOrdinal("KontaktID"));

            return er;
        }

    }
}
