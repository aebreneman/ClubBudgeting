﻿namespace ClubBudgeting
{
   partial class Form1
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
         this.lab1_login = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtbx1_userName = new System.Windows.Forms.TextBox();
         this.txtbx2_password = new System.Windows.Forms.TextBox();
         this.but1_login = new System.Windows.Forms.Button();
         this.but2_createAccount = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lab1_login
         // 
         this.lab1_login.AutoSize = true;
         this.lab1_login.Location = new System.Drawing.Point(146, 93);
         this.lab1_login.Name = "lab1_login";
         this.lab1_login.Size = new System.Drawing.Size(63, 13);
         this.lab1_login.TabIndex = 0;
         this.lab1_login.Text = "User Name:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(153, 126);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Password:";
         // 
         // txtbx1_userName
         // 
         this.txtbx1_userName.Location = new System.Drawing.Point(215, 90);
         this.txtbx1_userName.Name = "txtbx1_userName";
         this.txtbx1_userName.Size = new System.Drawing.Size(143, 20);
         this.txtbx1_userName.TabIndex = 2;
         // 
         // txtbx2_password
         // 
         this.txtbx2_password.Location = new System.Drawing.Point(215, 123);
         this.txtbx2_password.Name = "txtbx2_password";
         this.txtbx2_password.PasswordChar = '●';
         this.txtbx2_password.Size = new System.Drawing.Size(143, 20);
         this.txtbx2_password.TabIndex = 3;
         // 
         // but1_login
         // 
         this.but1_login.Location = new System.Drawing.Point(255, 149);
         this.but1_login.Name = "but1_login";
         this.but1_login.Size = new System.Drawing.Size(103, 23);
         this.but1_login.TabIndex = 4;
         this.but1_login.Text = "Login";
         this.but1_login.UseVisualStyleBackColor = true;
         this.but1_login.Click += new System.EventHandler(this.but1_login_Click);
         // 
         // but2_createAccount
         // 
         this.but2_createAccount.Location = new System.Drawing.Point(255, 178);
         this.but2_createAccount.Name = "but2_createAccount";
         this.but2_createAccount.Size = new System.Drawing.Size(103, 23);
         this.but2_createAccount.TabIndex = 5;
         this.but2_createAccount.Text = "Create Account";
         this.but2_createAccount.UseVisualStyleBackColor = true;
         this.but2_createAccount.Click += new System.EventHandler(this.but2_createAccount_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(550, 261);
         this.Controls.Add(this.but2_createAccount);
         this.Controls.Add(this.but1_login);
         this.Controls.Add(this.txtbx2_password);
         this.Controls.Add(this.txtbx1_userName);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lab1_login);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_login;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtbx1_userName;
      private System.Windows.Forms.TextBox txtbx2_password;
      private System.Windows.Forms.Button but1_login;
      private System.Windows.Forms.Button but2_createAccount;
   }
}

