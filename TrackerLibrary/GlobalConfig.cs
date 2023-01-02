using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connection { get; private set; }
        public static void InnializerConnection(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO create SQL Conncetion

            } else if(textFiles)
            {
                //TODO Create text connection
            }
        }

    }
}
