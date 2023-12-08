using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_report_test_
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            bool bCheckTable = false;

            if (ds.Tables.Contains(comboBox_check.Text))
            {
                bCheckTable = true;
            }

            DataTable dt = null;

            if (!bCheckTable)
            {
                dt = new DataTable(comboBox_check.Text);

                DataColumn colTitle = new DataColumn("Title", typeof(string));
                DataColumn colComment = new DataColumn("Comment", typeof(string));
                DataColumn colCheck = new DataColumn("Check", typeof(string));
                DataColumn colDate = new DataColumn("Date", typeof(string));

                dt.Columns.Add(colDate);
                dt.Columns.Add(colTitle);
                dt.Columns.Add(colComment);
                dt.Columns.Add(colCheck);
            }

            else
                dt = ds.Tables[comboBox_check.Text];

            DataRow row = dt.NewRow();

            row["Title"] = titlebox.Text;

            row["Comment"] = commentbox.Text;

            row["Date"] = datebox.Text;


            if (check1.Checked)
            {
                row["Check"] = "중요";
            }
            else if (check2.Checked)
            {
                row["Check"] = "보통";
            }

            if (bCheckTable)
            {
                ds.Tables[comboBox_check.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }

            comboBox1_SelectedIndexChanged(this, null);

            titlebox.Text = "";
            commentbox.Text = "";
            datebox.Text = "";
            comboBox_check.Text = "";
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            int iSelectRow = dataGridView1.SelectedRows[0].Index;
            ds.Tables[comboBox1.Text].Rows.RemoveAt(iSelectRow);
            comboBox1_SelectedIndexChanged(this, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox1.Text];

            foreach (DataGridViewRow oRow in dataGridView1.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            datebox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
