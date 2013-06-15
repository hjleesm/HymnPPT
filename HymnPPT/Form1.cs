using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace HymnPPT
{
    public partial class Form1 : Form
    {
        private ArrayList Result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Bt_Click(object sender, EventArgs e)
        {
            Result_lb.Items.Clear();
            //hjlee: 2013-06-15, MDB(DataBase)에서 입력된 검색어가 포함된 찬양 목록을 받아옴.
            ConMdb CM = new ConMdb(Input_tB.Text);

            Result = CM.getHymns();

            for (int i = 0; i < Result.Count; i++)
            {
                Hymns Hymn = (Hymns)Result[i];

                Result_lb.Items.Add(Hymn._Seq + "장 " + Hymn._Title);
            }
        }

        private void Open_Bt_Click(object sender, EventArgs e)
        {
            //hjlee: 2013-06-15, PPS 파일이 저장된 폴더명을 구하기 위한 부분.
            string hymn_no = Result_lb.SelectedItem.ToString().Split('장', ' ')[0];
            string mid_no = ((int.Parse(hymn_no) / 100) * 100).ToString();
            if (mid_no.Equals("0"))
                mid_no = "000";
            mid_no += @"\";
            for (int i = hymn_no.Length; i < 3; i++)
                mid_no += "0";
            string dir = @"D:\church computer\새 찬송가\hymn\"+mid_no + hymn_no + ".pps";

            //hjlee: 2013-06-15, 해당 경로의 PPS 파일 실행.
            Process.Start(dir);
        }

        private void Input_tB_KeyDown(object sender, KeyEventArgs e)
        {
            //hjlee: 2013-06-15, 입력 텍스트 박스에서 엔터 입력시 검색 버튼 실행.
            if (e.KeyCode == Keys.Enter)
                Search_Bt.PerformClick();
        }

        private void Result_lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //hjlee: 2013-06-15, 리스트박스에서 아이템 더블 클릭시 해당 PPT 실행.
            Open_Bt.PerformClick();
        }

        private void Result_lb_KeyDown(object sender, KeyEventArgs e)
        {
            //hjlee: 2013-06-15, 리스트박스에서 엔터 입력시 해당 PPT 실행.
            if (e.KeyCode == Keys.Enter)
                Open_Bt.PerformClick();
        }

        private void Result_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hymns Hymn = (Hymns)Result[Result_lb.SelectedIndex];
            Preview_tB.Text = Hymn._Lyric;
            Preview_tB.Refresh();
        }
    }
}
