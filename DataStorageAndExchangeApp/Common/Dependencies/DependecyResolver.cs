using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using SQLDAL;
using BLLInterfaces;
using BLL;

namespace Dependencies
{
    public class DependecyResolver
    {
        #region Singleton
        private static DependecyResolver _istance;

        private DependecyResolver() { }

        public static DependecyResolver Instance
        {
            get
            {
                if (_istance == null)
                    _istance = new DependecyResolver();

                return _istance;
            }
        }
        #endregion Singleton

        private IDataExchangerDao DataExchangerDAO => new DataExchangerSqlDao();

        public IDataExchangerLogic DataExchangerLogic => new DataExchengerLogic(DataExchangerDAO);
    }
}
