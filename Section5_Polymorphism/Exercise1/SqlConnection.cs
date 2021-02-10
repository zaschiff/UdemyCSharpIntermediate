using System;

namespace Exercise1 {
    public class SqlConnection : DbConnection {
        public SqlConnection(string connectionString) : base(connectionString) {}

        public override void Open() {
            Console.WriteLine("The SQL Connection is open.");
        }

        public override void Close() {
            Console.WriteLine("The SQL Connection is closed.");
        }
    }
}