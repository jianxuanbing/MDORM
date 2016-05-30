﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Tools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnJiami_Click(object sender, EventArgs e)
        {
            if (txtMingWen.Text.Length <= 0)
            {
                MessageBox.Show("请输入要加密的字符串", "提示");
                txtMingWen.Focus();
                return;
            }
            else
            {
                string tempMingWen = txtMingWen.Text.Trim();
                string tempResult = DESEncrypt.Encrypt(tempMingWen);
                txtResult.Text = tempResult;
                Clipboard.SetDataObject(tempResult);
                MessageBox.Show("字符串加密成功并复制到系统剪切板", "提示");
            }
        }
    }
}