using System;

namespace Exercise1 {
    public class DbCommand {
        private DbConnection _db;
        private string _command;

        public DbCommand(DbConnection dbType, string instruction) {
            if (dbType == null) {
                throw new ArgumentNullException("Database conneciton can notn be null.");
            }

            if (String.IsNullOrEmpty(instruction)) {
                throw new ArgumentException("Command can not be null or empty.");
            }

            _db = dbType;
            _command = instruction;

        }

        public void Execute() {
            _db.Open();
            Console.WriteLine("Command: " + _command);
            _db.Close();
        }
    }
}