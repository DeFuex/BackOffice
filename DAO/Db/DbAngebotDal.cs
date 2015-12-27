using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbAngebotDal : IAngebotDal
    {

       public DbDal Db { get; private set; }

        public DbAngebotDal(DbDal db)
        {
            Db = db;        
        }




        public void Add(Domain.Angebot angebot)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Angebot(datum, summe, dauer, chance, projektid, kundenid) values (@datum, @summe, @dauer, @chance, @projektid, @kundenid); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@datum", angebot.Datum));
                cmd.Parameters.Add(new SqlParameter("@summe", (double)angebot.Summe));
                cmd.Parameters.Add(new SqlParameter("@dauer", angebot.Dauer));
                cmd.Parameters.Add(new SqlParameter("@chance", (float)angebot.Chance));
                cmd.Parameters.Add(new SqlParameter("@projektid", angebot.ProjektID));
                cmd.Parameters.Add(new SqlParameter("@kundenid", angebot.KundenID));
                angebot.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            catch (Exception exc)
            {
                this.GetLogger().Error(exc);
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Angebot angebot)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Angebot set datum = @datum, summe = @summe, dauer = @dauer, chance = @chance, projektid = @projektid, kundenid = @kundenid where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", angebot.ID));
                    cmd.Parameters.Add(new SqlParameter("@datum", angebot.Datum));
                    cmd.Parameters.Add(new SqlParameter("@summe", (double)angebot.Summe));
                    cmd.Parameters.Add(new SqlParameter("@dauer", angebot.Dauer));
                    cmd.Parameters.Add(new SqlParameter("@chance", (float)angebot.Chance));
                    cmd.Parameters.Add(new SqlParameter("@projektid", angebot.ProjektID));
                    cmd.Parameters.Add(new SqlParameter("@kundenid", angebot.KundenID));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Angebot angebot)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Angebot where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", angebot.ID));
                    if(cmd.ExecuteNonQuery() != 1)throw new InvalidOperationException("no rows affected while deleting angebot with ID = " + angebot.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Angebot> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Angebot> list = new List<Domain.Angebot>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, datum, summe, dauer, chance, projektid, kundenid from Angebot";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseAngebot(reader));
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

        public Domain.Angebot GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Angebot> list = new List<Domain.Angebot>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, datum, summe, dauer, chance, projektid, kundenid from Angebot where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseAngebot(reader));
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

        public List<Domain.Angebot> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Angebot> list = new List<Domain.Angebot>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, datum, summe, dauer, chance, projektid, kundenid from Angebot where replace(lower(convert(nvarchar(max), summe)), '.', ',') LIKE @suchtext or lower(convert(nvarchar(max), dauer)) LIKE @suchtext or lower(convert(nvarchar(max), id)) LIKE @suchtext or replace(lower(convert(nvarchar(max), chance)), '.', ',') LIKE @suchtext or lower(dbo.Function1(datum)) LIKE @suchtext or lower(convert(nvarchar(max), projektid)) LIKE @suchtext or lower(convert(nvarchar(max), kundenid)) LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseAngebot(reader));
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

        protected Domain.Angebot ParseAngebot(SqlDataReader reader) 
        {
            var ang = new Domain.Angebot();

            ang.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            ang.Datum = reader.GetDateTime(reader.GetOrdinal("Datum"));
            ang.Summe = reader.GetDouble(reader.GetOrdinal("Summe"));
            ang.Dauer = reader.GetInt32(reader.GetOrdinal("Dauer"));
            ang.Chance = (float)reader.GetDouble(reader.GetOrdinal("Chance"));
            ang.ProjektID = reader.GetInt64(reader.GetOrdinal("ProjektID"));
            ang.KundenID = reader.GetInt64(reader.GetOrdinal("KundenID"));

            return ang;
        }

    }
}
