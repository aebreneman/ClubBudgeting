﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubBudgeting.Forms
{
   public partial class ClubList : Form
   {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private static string[] clubNames;

      public ClubList()
      {
         InitializeComponent();

         loadClubNames();
      }

      private void loadClubNames()
      {
         clubNames = sql.CLUB_LIST;

         foreach (string cName in clubNames)
         {
            listBox1_clubList.Items.Add(cName);
         }
      }

      private void but1_clubInfo_Click(object sender, EventArgs e)
      {

      }

   }
}