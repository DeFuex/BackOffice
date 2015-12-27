using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbRechnungszeileDal : IRechnungszeileDal
    {

        public DbDal Db { get; private set; }

        public DbRechnungszeileDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Rechnungszeile rechnungszeile)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Rechnungszeile(angebotid, ausgangsrechnungsid, bezeichnung, betrag) values (@angebotid, @ausgangsrechnungsid, @bezeichnung, @betrag); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@angebotid", rechnungszeile.AngebotID));
                cmd.Parameters.Add(new SqlParameter("@ausgangsrechnungsid", rechnungszeile.AusgangsrechnungID));
                cmd.Parameters.Add(new SqlParameter("@bezeichnung", rechnungszeile.Bezeichnung));
                cmd.Parameters.Add(new SqlParameter("@Betrag", (double)rechnungszeile.Betrag));
                rechnungszeile.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Rechnungszeile rechnungszeile)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Rechnungszeile set angebotid = @angebotid, ausgangsrechnungsid = @ausgangsrechnungsid, bezeichnung = @bezeichnung, betrag = @betrag where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", rechnungszeile.ID));
                    cmd.Parameters.Add(new SqlParameter("@angebotid", rechnungszeile.AngebotID));
                    cmd.Parameters.Add(new SqlParameter("@ausgangsrechnungsid", rechnungszeile.AusgangsrechnungID));
                    cmd.Parameters.Add(new SqlParameter("@bezeichnung", rechnungszeile.Bezeichnung));
                    cmd.Parameters.Add(new SqlParameter("@Betrag", (double)rechnungszeile.Betrag));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Rechnungszeile rechnungszeile)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Rechnungszeile where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", rechnungszeile.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting rechnungszeile with ID = " + rechnungszeile.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Rechnungszeile> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Rechnungszeile> list = new List<Domain.Rechnungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, angebotid, ausgangsrechnungsid, bezeichnung, betrag from Rechnungszeile";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseRechnungszeile(reader));
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

        public Domain.Rechnungszeile GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Rechnungszeile> list = new List<Domain.Rechnungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, angebotid, ausgangsrechnungsid, bezeichnung, betrag from Rechnungszeile where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseRechnungszeile(reader));
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

        public List<Domain.Rechnungszeile> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Rechnungszeile> list = new List<Domain.Rechnungszeile>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, angebotid, ausgangsrechnungsid, bezeichnung, betrag from Rechnungszeile where replace(lower(convert(nvarchar(max), betrag)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), angebotid)) LIKE @suchtext or lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), bezeichnung)) LIKE @suchtext or lower(convert(nvarchar(max), ausgangsrechnungsid)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseRechnungszeile(reader));
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

        protected Domain.Rechnungszeile ParseRechnungszeile(SqlDataReader reader)
        {
            var rech = new Domain.Rechnungszeile();

            rech.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            rech.AngebotID = reader.GetInt64(reader.GetOrdinal("AngebotID"));
            rech.AusgangsrechnungID = reader.GetInt64(reader.GetOrdinal("AusgangsrechnungsID"));
            rech.Bezeichnung = reader.GetString(reader.GetOrdinal("Bezeichnung"));
            rech.Betrag = (float)reader.GetDouble(reader.GetOrdinal("Betrag"));

            return rech;
        }

    }
}
