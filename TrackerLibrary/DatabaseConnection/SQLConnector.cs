using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DatabaseConnection
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Save new prize to db
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Includes prize info</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
