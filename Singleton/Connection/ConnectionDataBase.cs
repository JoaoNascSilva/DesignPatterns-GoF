namespace Singleton.Connection
{
    public class ConnectionDataBase
    {
        private static ConnectionDataBase _instance = null;

        protected ConnectionDataBase() { }

        public static ConnectionDataBase Instance()
        {
            if (_instance == null) 
                _instance = new ConnectionDataBase();

            return _instance;
        }
    }
}