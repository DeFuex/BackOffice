using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbBuchungszeileDal : IBuchungszeileDal
    {

        public DbDal Db { get; private set; }

        public DbBuchungszeileDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Buchungszeile buchungszeile)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Buchungszeile(bankkonto, rechnungssumme, ust) values (@bankkonto, @rechnungssumme, @ust); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@bankkonto", buchungszeile.Bankkonto));
                cmd.Parameters.Add(new SqlParameter("@rechnungssumme", (double)buchungszeile.Rechnungssumme));
                cmd.Parameters.Add(new SqlParameter("@ust", (double)buchungszeile.Ust));
                buchungszeile.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Buchungszeile buchungszeile)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Buchungszeile set bankkonto = @bankkonto, rechnungssumme = @rechnungssumme, ust = @ust where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", buchungszeile.ID));
                    cmd.Parameters.Add(new SqlParameter("@bankkonto", buchungszeile.Bankkonto));
                    cmd.Parameters.Add(new SqlParameter("@rechnungssumme", (double)buchungszeile.Rechnungssumme));
                    cmd.Parameters.Add(new SqlParameter("@ust", (double)buchungszeile.Ust));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Buchungszeile buchungszeile)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Buchungszeile where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", buchungszeile.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting buchungszeile with ID = " + buchungszeile.ID);
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Buchungszeile> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Buchungszeile> list = new List<Domain.Buchungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, bankkonto, rechnungssumme, ust from Buchungszeile";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseBuchungszeile(reader));
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

        public List<Domain.Buchungszeile> GetAllByRechnung(long inputid, String type)
        {

            Db.UseConnection();
            try
            {
                List<Domain.Buchungszeile> list = new List<Domain.Buchungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select b.id, b.bankkonto, b.rechnungssumme, b.ust from [Rechnung-Buchung] as a, Buchungszeile as b where a.rechnungstyp = @rechnungstyp and a.rechnungsid = @rechnungsid and a.buchungszeilenid = b.id";
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", inputid));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", type));
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseBuchungszeile(reader));
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

        public Domain.Buchungszeile GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Buchungszeile> list = new List<Domain.Buchungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, bankkonto, rechnungssumme, ust from Buchungszeile where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseBuchungszeile(reader));
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

        public List<Domain.Buchungszeile> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Buchungszeile> list = new List<Domain.Buchungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, bankkonto, rechnungssumme, ust from Buchungszeile where replace(lower(convert(nvarchar(max), rechnungssumme)), '.', ',') LIKE @suchtext or replace(lower(convert(nvarchar(max), ust)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), bankkonto)) LIKE @suchtext or lower(convert(nvarchar(max), id)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseBuchungszeile(reader));
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

        protected Domain.Buchungszeile ParseBuchungszeile(SqlDataReader reader)
        {
            var buch = new Domain.Buchungszeile();

            buch.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            buch.Bankkonto = reader.GetString(reader.GetOrdinal("Bankkonto"));
            buch.Rechnungssumme = reader.GetDouble(reader.GetOrdinal("Rechnungssumme"));
            buch.Ust = reader.GetDouble(reader.GetOrdinal("USt"));

            return buch;
        }

    }
}
