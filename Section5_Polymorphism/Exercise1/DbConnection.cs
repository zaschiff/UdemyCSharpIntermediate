using System;

namespace Exercise1 {

    public abstract class DbConnection {
        private string _connectionString;
        //private TimeSpan timeout;
        public DbConnection(string connectionString) {
            if (String.IsNullOrEmpty(connectionString))
                throw new ArgumentException("Connection string can not be empty or null.");
            else {
                Console.WriteLine("Database is connected.");
                _connectionString = connectionString;
            }
        }

        public abstract void Open();
        public abstract void Close();
    }

}