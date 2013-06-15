using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace HymnPPT
{
    class ConMdb
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        private string MDBConnectString;
        private DataSet dataSet;
        private ArrayList HymnList;

        public ConMdb(String Input)
        {
            MDBConnectString = "Provider = Microsoft.JET.OLEDB.4.0;Data Source=Hymn.mdb";
            con = new OleDbConnection(MDBConnectString);
            con.Open();

            cmd = new OleDbCommand();

            //nyjin: hymns테이블에서 contents에 input이 포함된 seq, title, contents를 찾으세요
            cmd.CommandText = String.Format("select seq, title, contents from hymn where contents like '%"+Input+"%' "); 

            //cmd.ExecuteScalar();

            adapter = new OleDbDataAdapter(cmd.CommandText, con);

            dataSet = new DataSet();

            adapter.Fill(dataSet);

            HymnList = new ArrayList();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Hymns Hymn = new Hymns();
                Hymn._Seq = row.ItemArray[0].ToString();
                Hymn._Title = (row.ItemArray[1]).ToString();
                Hymn._Lyric = (row.ItemArray[2]).ToString();

                HymnList.Add(Hymn);
                Console.WriteLine(Hymn._Seq);
            }

            con.Close();
        }

        public ArrayList getHymns()
        {
            return HymnList;
        }
    }
}
