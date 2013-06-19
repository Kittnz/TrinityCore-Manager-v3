﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager
{
    public partial class AddAccountBan : DevComponents.DotNetBar.Office2007Form
    {
        public AddAccountBan()
        {
            InitializeComponent();
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            //TCManager.Instance.AuthDatabase.AccountBan(
        }

        private void AddAccountBan_Load(object sender, EventArgs e)
        {

            var bannedAccts = TCManager.Instance.AuthDatabase.GetAccounts();

            foreach (var acct in bannedAccts)
            {
                accListComboBox.Items.Add(acct.Id);
            }

        }
    }
}
