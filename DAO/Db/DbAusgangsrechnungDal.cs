using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbAusgangsrechnungDal : IAusgangsrechnungDal
    {

        public DbDal Db { get; private set; }

        public DbAusgangsrechnungDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Ausgangsrechnung ausgangsrechnung)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Ausgangsrechnung(summe, datum, beschreibung, gedruckt, offen, projektid, kundenid) values (@summe, @datum, @beschreibung, @gedruckt, @offen, @projektid, @kundenid); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@summe", (double)ausgangsrechnung.Summe));
                cmd.Parameters.Add(new SqlParameter("@datum", ausgangsrechnung.Datum));
                cmd.Parameters.Add(new SqlParameter("@beschreibung", ausgangsrechnung.Beschreibung));
                cmd.Parameters.Add(new SqlParameter("@gedruckt", ausgangsrechnung.Gedruckt)); //bin mir nicht sicher ob ich das typecasten muss oder nicht oder obs schlimm ist wenn ichs mache
                cmd.Parameters.Add(new SqlParameter("@offen", ausgangsrechnung.Offen)); //hier auch nicht
                cmd.Parameters.Add(new SqlParameter("@projektid", ausgangsrechnung.ProjektID));
                cmd.Parameters.Add(new SqlParameter("@kundenid", ausgangsrechnung.KundenID));
                ausgangsrechnung.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Ausgangsrechnung ausgangsrechnung)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Ausgangsrechnung set summe = @summe, datum = @datum, beschreibung = @beschreibung, gedruckt = @gedruckt, offen = @offen, projektid = @projektid, kundenid = @kundenid where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", ausgangsrechnung.ID));
                    cmd.Parameters.Add(new SqlParameter("@summe", (double)ausgangsrechnung.Summe));
                    cmd.Parameters.Add(new SqlParameter("@datum", ausgangsrechnung.Datum));
                    cmd.Parameters.Add(new SqlParameter("@beschreibung", ausgangsrechnung.Beschreibung));
                    cmd.Parameters.Add(new SqlParameter("@gedruckt", ausgangsrechnung.Gedruckt)); //bin mir nicht sicher ob ich das typecasten muss oder nicht oder obs schlimm ist wenn ichs mache
                    cmd.Parameters.Add(new SqlParameter("@offen", ausgangsrechnung.Offen)); //hier auch nicht
                    cmd.Parameters.Add(new SqlParameter("@projektid", ausgangsrechnung.ProjektID));
                    cmd.Parameters.Add(new SqlParameter("@kundenid", ausgangsrechnung.KundenID));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Ausgangsrechnung ausgangsrechnung)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Ausgangsrechnung where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", ausgangsrechnung.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting ausgangsrechnung with ID = " + ausgangsrechnung.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Ausgangsrechnung> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Ausgangsrechnung> list = new List<Domain.Ausgangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, summe, datum, beschreibung, gedruckt, offen, projektid, kundenid from Ausgangsrechnung";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseAusgangsrechnung(reader));
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

        public List<Domain.Ausgangsrechnung> GetAllByBuchung(long inputid)
        {

            Db.UseConnection();
            try
            {
                List<Domain.Ausgangsrechnung> list = new List<Domain.Ausgangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select b.id, b.summe, b.datum, b.beschreibung, b.gedruckt, b.offen, b.projektid, b.kundenid from [Rechnung-Buchung] as a, Ausgangsrechnung as b where a.rechnungstyp = @rechnungstyp and a.rechnungsid = @rechnungsid";
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", inputid));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", "Ausgang"));
                    
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseAusgangsrechnung(reader));
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

        public Domain.Ausgangsrechnung GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Ausgangsrechnung> list = new List<Domain.Ausgangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, summe, datum, beschreibung, gedruckt, offen, projektid, kundenid from Ausgangsrechnung where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseAusgangsrechnung(reader));
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

        public List<Domain.Ausgangsrechnung> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Ausgangsrechnung> list = new List<Domain.Ausgangsrechnung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, summe, datum, beschreibung, gedruckt, offen, projektid, kundenid from Ausgangsrechnung where replace(lower(convert(nvarchar(max), summe)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), beschreibung)) LIKE @suchtext or lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), projektid)) LIKE @suchtext or lower(convert(nvarchar(max), kundenid)) LIKE @suchtext or lower(dbo.Function1(datum)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseAusgangsrechnung(reader));
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

        protected Domain.Ausgangsrechnung ParseAusgangsrechnung(SqlDataReader reader)
        {
            var ausg = new Domain.Ausgangsrechnung();

            ausg.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            ausg.Summe = (float)reader.GetDouble(reader.GetOrdinal("Summe"));
            ausg.Datum = reader.GetDateTime(reader.GetOrdinal("Datum"));
            ausg.Beschreibung = reader.GetString(reader.GetOrdinal("Beschreibung"));
            ausg.Gedruckt = reader.GetBoolean(reader.GetOrdinal("Gedruckt"));
            ausg.Offen = reader.GetBoolean(reader.GetOrdinal("Offen"));
            ausg.ProjektID = reader.GetInt64(reader.GetOrdinal("ProjektID"));
            ausg.KundenID = reader.GetInt64(reader.GetOrdinal("KundenID"));

            return ausg;
        }

    }
}
