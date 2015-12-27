using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbRechnungBuchungDal : IRechnungBuchungDal
    {

        public DbDal Db { get; private set; }

        public DbRechnungBuchungDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.RechnungBuchung rechbuch)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into [Rechnung-Buchung](buchungszeilenid, rechnungsid, rechnungstyp) values (@buchungszeilenid, @rechnungsid, @rechnungstyp); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", rechbuch.BuchungszeilenID));
                cmd.Parameters.Add(new SqlParameter("@rechnungsid", rechbuch.RechnungsID));
                cmd.Parameters.Add(new SqlParameter("@rechnungstyp", rechbuch.Rechnungstyp));
                rechbuch.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.RechnungBuchung rechbuch)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update [Rechnung-Buchung] set buchungszeilenid = @buchungszeilenid, rechnungsid = @rechnungsid, rechnungstyp = @rechnungstyp where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", rechbuch.ID));
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", rechbuch.BuchungszeilenID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", rechbuch.RechnungsID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", rechbuch.Rechnungstyp));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void DeleteAR(Domain.Ausgangsrechnung ar, Domain.Buchungszeile bz)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from [Rechnung-Buchung] where BuchungszeilenID = @buchungszeilenid and rechnungsid = @rechnungsid and rechnungstyp = @rechnungstyp;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", bz.ID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", ar.ID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", "Ausgang"));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting rechnung-buchung with RechnungsID = " + ar.ID + " and BuchungsID = " + bz.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void DeleteER(Domain.Eingangsrechnung er, Domain.Buchungszeile bz)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from [Rechnung-Buchung] where BuchungszeilenID = @buchungszeilenid and rechnungsid = @rechnungsid and rechnungstyp = @rechnungstyp;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@buchungszeilenid", bz.ID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungsid", er.ID));
                    cmd.Parameters.Add(new SqlParameter("@rechnungstyp", "Eingang"));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting rechnung-buchung with RechnungsID = " + er.ID + " and BuchungsID = " + bz.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.RechnungBuchung> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.RechnungBuchung> list = new List<Domain.RechnungBuchung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, buchungszeilenid, rechnungsid, rechnungstyp from [Rechnung-Buchung]";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseRechnungBuchung(reader));
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

        public Domain.RechnungBuchung GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.RechnungBuchung> list = new List<Domain.RechnungBuchung>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, buchungszeilenid, rechnungsid, rechnungstyp from [Rechnung-Buchung] where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseRechnungBuchung(reader));
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

        protected Domain.RechnungBuchung ParseRechnungBuchung(SqlDataReader reader)
        {
            var rechbuch = new Domain.RechnungBuchung();

            rechbuch.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            rechbuch.BuchungszeilenID = reader.GetInt64(reader.GetOrdinal("BuchungszeilenID"));
            rechbuch.RechnungsID = reader.GetInt64(reader.GetOrdinal("RechnungsID"));
            rechbuch.Rechnungstyp = reader.GetString(reader.GetOrdinal("Rechnungstyp"));

            return rechbuch;
        }

    }
}
