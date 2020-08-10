using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        SqlConnection objConn = new SqlConnection();
        string strSqlConn = "Data Source=DESKTOP-7ULJI2H\\BAZAZASTITAINF;Initial Catalog=ZI;Integrated Security=True";

        string strQuery_AllAttachments = "select id, fileName, fileSize from tblAttachments where userid='"+userid+"'";
        string strQuery_GetAttachmentById = "select * from tblAttachments where id = @attachId";
        string strQuery_AllAttachments_AllFields = "select * from tblAttachments";

        public byte[][] downloadfile(string strId)
        {
            objConn.ConnectionString = strSqlConn;
            objConn.Open();
            SqlCommand sqlCmd = new SqlCommand(strQuery_GetAttachmentById, objConn);
            sqlCmd.Parameters.AddWithValue("@attachId", strId);
            SqlDataAdapter objAdapter = new SqlDataAdapter(sqlCmd);
            DataTable objTable = new DataTable();
            DataRow objRow;
            objAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder sqlCmdBuilder = new SqlCommandBuilder(objAdapter);
            objAdapter.Fill(objTable);
            objRow = objTable.Rows[0];
            byte[] attachment = (byte[])objRow["attachment"];
            string hash = (string)objRow["hashcode"];
            byte[] hashcode = Encoding.UTF8.GetBytes(hash);
            byte[][] data = new byte[2][];
            data[0] = attachment;
            data[1] = hashcode;
            return data;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        private static int userid;
        public bool login(string username, string password)
        {
            objConn.ConnectionString = strSqlConn;
            objConn.Open();
            SqlCommand command = new SqlCommand("Select id From korisnik where username = '" + username + "' and password = '" + password + "'", objConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    userid = (Int32)reader["id"];
                }
            }

            if (userid != 0)
            {
                objConn.Close();
                return true;
            }
            else
            {
                objConn.Close();
                return false;
            }
        }

        public bool savefile(string[] fileName, int fileSize, byte[] objData,string hashcode)
        {
            objConn.ConnectionString = strSqlConn; //set connection params
            objConn.Open();
            SqlDataAdapter objAdapter = new SqlDataAdapter(strQuery_AllAttachments_AllFields, objConn);
            objAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder objCmdBuilder = new SqlCommandBuilder(objAdapter);
            DataTable objTable = new DataTable();
            DataRow objRow;
            objAdapter.Fill(objTable);
            objRow = objTable.NewRow();
            objRow["fileName"] = fileName[fileName.Length - 1]; //clip the full path - we just want last part!
            objRow["fileSize"] = fileSize; // KB instead of bytes
            objRow["attachment"] = objData;  //our file
            objRow["hashcode"] = hashcode;
            objRow["userid"] = userid;
            objTable.Rows.Add(objRow); //add our new record
            objAdapter.Update(objTable);
            return true;
        }

        public DataTable updatedatagridview()
        {
            objConn.ConnectionString = strSqlConn; //set connection params
            objConn.Open();
            DataTable tbl1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConn;  // use connection object
            cmd1.CommandText = strQuery_AllAttachments; // set query to use
            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;  //grab schema
            adapter1.SelectCommand = cmd1; //
            adapter1.Fill(tbl1);
            return tbl1;
        }
    }
}
