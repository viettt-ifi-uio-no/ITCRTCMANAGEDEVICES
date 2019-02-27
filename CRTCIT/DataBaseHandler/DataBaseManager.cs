using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTCIT.DataBaseHandler
{
    class DataBaseManager
    {
        private int mOpenCounter;
        private static DataBaseManager instance;
        private static SqlConnection mDatabase;
        private static System.Object lockThis = new System.Object();
        public const string CONNSTR = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\Desktop\\CRTCIT\\ITCRTCMANAGEDEVICES\\CRTCIT\\itcrtc.mdf;Integrated Security = True";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\itcrtc.mdf;Integrated Security=True";

        

        public static void initializeInstance()
        {
            lock (lockThis)
            {
                if (instance == null)
                {
                    instance = new DataBaseManager();
                }
            }
        }

        public static DataBaseManager getInstance()
        {
            lock (lockThis)
            {
                if (instance == null)
                {
                    throw new System.InvalidOperationException("DB is not initialized, call initializeInstance(..) to initialize instance.");
                }
            }
            return instance;
        }

        public SqlConnection openDatabase()
        {
            lock (lockThis)
            {
                mOpenCounter++;
                //If it is the first time
                if (mOpenCounter == 1)
                {
                    mDatabase = new SqlConnection(CONNSTR);
                    mDatabase.Open();
                }
            }
            //else just return the opened instance
            return mDatabase;
        }

        public void closeDatabase()
        {
            //We do not want to close the DB while the other use it
            lock (lockThis)
            {
                mOpenCounter--;
                if (mOpenCounter == 0)
                {
                    //REAL CLOSE
                    mDatabase.Close();
                    mDatabase = null;
                }
            }
        }

    }
}
