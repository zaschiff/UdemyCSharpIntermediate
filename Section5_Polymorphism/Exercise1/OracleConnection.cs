using System;

namespace Exercise1 {
    public class OracleConnection : DbConnection {
        public OracleConnection(string connectionString) : base(connectionString) {}

        public override void Open() {
            Console.WriteLine("The Oracle Connection is open.");
        }

        public override void Close() {
            Console.WriteLine("The Oracle Connection is closed.");
        }
    }
}