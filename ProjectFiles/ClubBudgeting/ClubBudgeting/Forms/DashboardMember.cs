﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubBudgeting.Forms;
using System.Collections;
using System.IO;

namespace ClubBudgeting.Forms
{
   public partial class DashboardMember : Form
   {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;
      private ArrayList trans = new ArrayList();
      private string selectedId = null;
      Parameters pList = new Parameters();

      public DashboardMember()
      {
         InitializeComponent();
      }


      //#####################################################################//
      /// <summary>
      /// loads all essential components
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void DashboardMember_Load(object sender, EventArgs e)
      {
         budgetInfo();

         listView_trans.FullRowSelect = true;
         ViewTransactions_Load(sender, e);
      }

      /// <summary>
      /// closes the application
      /// </summary>
      /// <param name="e"></param>
      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         Environment.Exit(0);
      }

      //#####################################################################//
      /// <summary>
      /// load account and budget information
      /// </summary>
      private void budgetInfo()
      {
         lab1_accountName.Text = "Club Name: "
          + us.CLUB_NAME;

         lab3_budget.Text = "Budget Total: $"
          + sql.getCurrClubBalance(new Parameters(us.CLUB_ID));

         lab4_debt.Text = "Debt Total: $" 
          + sql.getDebt(new Parameters(us.CLUB_ID));

      }

      //#####################################################################//
      /// <summary>
      /// opens the transaction window when the button is clicked
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_view_transactions_Click(object sender, EventArgs e)
      {
         try
         {// Instantiate a Form3 object.
            ViewTransactions newForm = new ViewTransactions(); 
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.Show(ParentForm);
         }
         catch
         {
            System.Diagnostics.Debug.WriteLine("Failed to view transactions");
         }
      }

      /// <summary>
      /// When the form is loaded, load the data from the club onto the list
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ViewTransactions_Load(object sender, EventArgs e)
      { loadList(sql.getTransactions(new Parameters(us.CLUB_ID))); }

      /// <summary>
      /// loads the transactions for the club Id into the viewList.
      /// </summary>
      /// <param name="trans"></param>
      private void loadList(ArrayList trans)
      {
         listView_trans.View = View.Details;

         listView_trans.Columns.Add("ID", 25, HorizontalAlignment.Center);
         listView_trans.Columns.Add("Purchase Date", 100);
         listView_trans.Columns.Add("Cost");
         listView_trans.Columns.Add("Description", 180);

         foreach (ArrayList dataP in trans)
         {
            string ID = dataP[0].ToString(),
            purDate = dataP[1].ToString().Substring(0, 9),
            cost = dataP[2].ToString(),
            desc = dataP[3].ToString();

            listView_trans.Items.Add(new ListViewItem(new[] {ID,
               purDate, cost, desc}));
         }
      } // end loadList

      private void button1_Click(object sender, EventArgs e)
      {
         OFD_budget_prop.Filter = "Excel Files | *.xlsx; *.xls; *.csv;";
         OFD_budget_prop.InitialDirectory = @"C:\Users";

         if (OFD_budget_prop.ShowDialog() == DialogResult.OK)
         {
            byte[] file = System.IO.File.ReadAllBytes
               (OFD_budget_prop.FileName);
            pList.addParams(us.CLUB_ID, file, 
               Path.GetExtension(OFD_budget_prop.FileName));
            sql.AddBudgetProp(pList);
         }
      }

      private void LV_trans_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listView_trans.SelectedItems.Count == 0)
            return;
         selectedId = listView_trans.SelectedItems[0].SubItems[0].Text;
      }

      private void but6_logout_Click(object sender, EventArgs e)
      {
         Environment.Exit(0);
      }

      private void uploadReceipt_Click(object sender, EventArgs e)
      {
         OFD_budget_prop.Filter = ".pdf Files | *.pdf; *.png; *.jpg;";
         OFD_budget_prop.InitialDirectory = @"C:\Users";

         if (selectedId != null) {
            if (OFD_budget_prop.ShowDialog() == DialogResult.OK) {
               byte[] file = System.IO.File.ReadAllBytes
                  (OFD_budget_prop.FileName);
               pList.addParams(selectedId, file,
                  Path.GetExtension(OFD_budget_prop.FileName));
               sql.addPDFReceipt(pList);
            }
         } 
         else {
            MessageBox.Show("Please select a transaction",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
