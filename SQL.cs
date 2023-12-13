using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using 应用1.Core.Models;

namespace 应用1;
internal class SQL
{
    private string connString;
    public SQL()
    {
        connString = "Data Source=localhost:1521;User Id=system;Password=qwertyui;";
    }

    public void Selectall(ObservableCollection<SampleOrder> Source)
    {

        OracleConnection conn = new OracleConnection();
        conn.ConnectionString = connString;
        conn.Open();
        // Execute a SQL SELECT
        OracleCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from student";
        OracleDataReader reader = cmd.ExecuteReader();

        // Print all student numbers
        while (reader.Read())
        {
            string[] k = new string[8];
            for (int i = 0; i < 8; ++i)
                k[i] = reader.GetString(i);
            Source.Add(new SampleOrder(k));
        }

        // Clean up
        reader.Dispose();
        cmd.Dispose();
        conn.Dispose();
        conn.Close();
    }
    public void Insert(string[] input)
    {
        OracleConnection conn = new OracleConnection();
        conn.ConnectionString = connString;
        conn.Open();

        //insert
        string[] item = new string[]{
                "studentId",
                "firstName",
                "lastName",
                "email",
                "phoneNo",
                "cga",
                "departmentId",
                "admissionYear" };
        string ins = "insert into Student values ( :studentId,:firstName,:lastName,:email,:phoneNo,:cga,:departmentId,:admissionYear)";
        OracleCommand cmdd = new OracleCommand(ins, conn);
        for (int i = 0; i < 8; i++)
            cmdd.Parameters.Add(new OracleParameter(item[i], input[i]));
        cmdd.ExecuteNonQuery();
        cmdd.Dispose();
        conn.Dispose();
        conn.Close();
    }
}
