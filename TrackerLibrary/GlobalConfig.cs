using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DatabaseConnection;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();
        public static void InnializerConnection(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO create SQL Conncetion
                SQLConnector sql = new SQLConnector();
                Connection.Add(sql);

            }
            if (textFiles)
            {
                //TODO Create text connection
                TextConnector text = new TextConnector();
                Connection.Add(text);
            }
        }

        //Get conn string
        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;  
        }

    }
}
