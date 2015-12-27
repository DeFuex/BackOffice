using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Domain.Utils;

namespace DAL.Db
{
    public class DbProjektDal : IProjektDal
    {
        public DbDal Db { get; private set; }

        public DbProjektDal(DbDal db)
        {
            Db = db;
        }




        public void Add(Domain.Projekt projekt)
        {
            Db.UseConnection();
            try
            {
                var cmd = Db.DbConnection.CreateCommand();
                cmd.CommandText = "insert into Projekt(name, gesamtzeit) values (@name, @gesamtzeit); select @@IDENTITY;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                cmd.Parameters.Add(new SqlParameter("@name", projekt.Name));
                cmd.Parameters.Add(new SqlParameter("@gesamtzeit", (double)projekt.Gesamtzeit));
                projekt.ID = Convert.ToInt64(cmd.ExecuteScalar());
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Update(Domain.Projekt projekt)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "update Projekt set name = @name, gesamtzeit = @gesamtzeit where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", projekt.ID));
                    cmd.Parameters.Add(new SqlParameter("@name", projekt.Name));
                    cmd.Parameters.Add(new SqlParameter("@gesamtzeit", (double)projekt.Gesamtzeit));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public void Delete(Domain.Projekt projekt)
        {
            Db.UseConnection();
            try
            {
                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "delete from Projekt where ID = @ID;"; //mit identity kiregt man die id des zuletzt eingefügten wertes in der angesprochenen tabelle
                    cmd.Parameters.Add(new SqlParameter("@ID", projekt.ID));
                    if (cmd.ExecuteNonQuery() != 1) throw new InvalidOperationException("no rows affected while deleting projekt with ID = " + projekt.ID);

                }
            }
            finally
            {
                Db.UnuseConnection();
            }
        }

        public List<Domain.Projekt> GetAll()
        {

            Db.UseConnection();
            try
            {
                List<Domain.Projekt> list = new List<Domain.Projekt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, name, gesamtzeit from Projekt";
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseProjekt(reader));
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

        public Domain.Projekt GetByID(long id)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Projekt> list = new List<Domain.Projekt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    cmd.CommandText = "select id, name, gesamtzeit from Projekt where id = @id;";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var reader = cmd.ExecuteReader())    //execute reader führt den sql befehl aus und stellt einen reader zur verfügung mit dem man die ergebnistabellen durchlaufen kann.
                    {
                        while (reader.Read())
                        {
                            list.Add(ParseProjekt(reader));
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

        public List<Domain.Projekt> Find(string suchtext)
        {
            Db.UseConnection();
            try
            {
                List<Domain.Projekt> list = new List<Domain.Projekt>();

                using (var cmd = Db.DbConnection.CreateCommand())
                {
                    // convert(nvarchar(max), myvar): converts "myvar" to "nvarchar(max)"
                    // lower(myvar): converts "myvar" to lowercase-letters. i.e.: lower('Test') = 'test'
                    // LIKE uses % as whitespace (it can represent any sequence of characters). i.e.: ('Flo is cool' LIKE '%is%') is TRUE
                    // @text is replaced by the value of the @text-parameter of the command

                    cmd.CommandText = "select id, name, gesamtzeit from Projekt where lower(convert(nvarchar(max), id)) LIKE @suchtext or lower(convert(nvarchar(max), name)) LIKE @suchtext or replace(lower(convert(nvarchar(max), gesamtzeit)), '.', ',') LIKE @suchtext";
                    var param = cmd.CreateParameter();
                    param.ParameterName = "@suchtext";
                    param.Value = "%" + suchtext + "%";
                    cmd.Parameters.Add(param);

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            list.Add(ParseProjekt(reader));
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

        protected Domain.Projekt ParseProjekt(SqlDataReader reader)
        {
            var pro = new Domain.Projekt();

            pro.ID = reader.GetInt64(reader.GetOrdinal("ID"));
            pro.Name = reader.GetString(reader.GetOrdinal("Name"));
            pro.Gesamtzeit = (float)reader.GetDouble(reader.GetOrdinal("Gesamtzeit"));

            return pro;
        }

    }
}
