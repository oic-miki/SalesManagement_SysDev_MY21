﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_出庫管理 : Form
    {
        public F_出庫管理()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流();
            f_buturyuu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            F_出庫詳細管理 f_syousai = new F_出庫詳細管理();
            f_syousai.Show();
        }
    }
}
