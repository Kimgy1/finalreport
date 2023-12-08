﻿using System;
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
                
                dt.Columns.Add(colTitle);
                dt.Columns.Add(colComment);
                dt.Columns.Add(colCheck);
            }

            else
                dt = ds.Tables[comboBox_check.Text];

            DataRow row = dt.NewRow();

            row["Title"] = titlebox.Text;

            row["Comment"] = commentbox.Text;


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
        }
    }
}
