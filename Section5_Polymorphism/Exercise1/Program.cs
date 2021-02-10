using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {  
            // SqlConnection s = new SqlConnection("Testng Connection");
            // s.Open();
            // s.Close();

            OracleConnection o = new OracleConnection("Testing Connection");
            // o.Open();
            // o.Close();

            DbCommand command = new DbCommand(o, "Testing");
            command.Execute();
        }
    }
}
