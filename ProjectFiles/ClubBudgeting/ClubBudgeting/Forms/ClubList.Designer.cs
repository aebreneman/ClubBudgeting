﻿namespace ClubBudgeting.Forms
{
   partial class ClubList
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lab1_selectClub = new System.Windows.Forms.Label();
         this.listBox1_clubList = new System.Windows.Forms.ListBox();
         this.but1_clubInfo = new System.Windows.Forms.Button();
         this.but_exit = new System.Windows.Forms.Button();
         this.but_addClub = new System.Windows.Forms.Button();
         this.but_refresh = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lab1_selectClub
         // 
         this.lab1_selectClub.AutoSize = true;
         this.lab1_selectClub.Location = new System.Drawing.Point(40, 37);
         this.lab1_selectClub.Name = "lab1_selectClub";
         this.lab1_selectClub.Size = new System.Drawing.Size(375, 25);
         this.lab1_selectClub.TabIndex = 0;
         this.lab1_selectClub.Text = "Select a club to view their information:";
         // 
         // listBox1_clubList
         // 
         this.listBox1_clubList.FormattingEnabled = true;
         this.listBox1_clubList.ItemHeight = 25;
         this.listBox1_clubList.Location = new System.Drawing.Point(45, 109);
         this.listBox1_clubList.Name = "listBox1_clubList";
         this.listBox1_clubList.Size = new System.Drawing.Size(370, 329);
         this.listBox1_clubList.TabIndex = 1;
         // 
         // but1_clubInfo
         // 
         this.but1_clubInfo.Location = new System.Drawing.Point(457, 241);
         this.but1_clubInfo.Name = "but1_clubInfo";
         this.but1_clubInfo.Size = new System.Drawing.Size(197, 75);
         this.but1_clubInfo.TabIndex = 2;
         this.but1_clubInfo.Text = "View club information";
         this.but1_clubInfo.UseVisualStyleBackColor = true;
         this.but1_clubInfo.Click += new System.EventHandler(this.but1_clubInfo_Click);
         // 
         // but_exit
         // 
         this.but_exit.Location = new System.Drawing.Point(45, 557);
         this.but_exit.Name = "but_exit";
         this.but_exit.Size = new System.Drawing.Size(197, 55);
         this.but_exit.TabIndex = 3;
         this.but_exit.Text = "Exit";
         this.but_exit.UseVisualStyleBackColor = true;
         this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
         // 
         // but_addClub
         // 
         this.but_addClub.Location = new System.Drawing.Point(457, 479);
         this.but_addClub.Name = "but_addClub";
         this.but_addClub.Size = new System.Drawing.Size(197, 55);
         this.but_addClub.TabIndex = 4;
         this.but_addClub.Text = "Add club";
         this.but_addClub.UseVisualStyleBackColor = true;
         this.but_addClub.Click += new System.EventHandler(this.but_addClub_Click);
         // 
         // but_refresh
         // 
         this.but_refresh.Location = new System.Drawing.Point(457, 557);
         this.but_refresh.Name = "but_refresh";
         this.but_refresh.Size = new System.Drawing.Size(197, 55);
         this.but_refresh.TabIndex = 5;
         this.but_refresh.Text = "Refresh club list";
         this.but_refresh.UseVisualStyleBackColor = true;
         this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
         // 
         // ClubList
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(690, 638);
         this.Controls.Add(this.but_refresh);
         this.Controls.Add(this.but_addClub);
         this.Controls.Add(this.but_exit);
         this.Controls.Add(this.but1_clubInfo);
         this.Controls.Add(this.listBox1_clubList);
         this.Controls.Add(this.lab1_selectClub);
         this.Name = "ClubList";
         this.Text = "Club List";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_selectClub;
      private System.Windows.Forms.ListBox listBox1_clubList;
      private System.Windows.Forms.Button but1_clubInfo;
      private System.Windows.Forms.Button but_exit;
      private System.Windows.Forms.Button but_addClub;
      private System.Windows.Forms.Button but_refresh;
   }
}