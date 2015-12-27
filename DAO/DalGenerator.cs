using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Fake;
using System.Configuration;
using DAL.Db;

namespace DAL
{
    public static class DalGenerator
    {
        public static IDal Create()
        {
            string daoConfiguration = ConfigurationManager.AppSettings["Dao"] ?? string.Empty; // ?? = bedeutet wenn das was davor steht NULL ist wird das rechte genommen.

            if (daoConfiguration.ToLower().Equals("Database".ToLower()))
                return new DbDal();
            else
                return new FakeDal();
        }
    }
}
