using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDMAMIS
{
    public partial class FrmLogin : Form
    {
        private Button btnLoginCancel;
        private Button btnLogin;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Label label1;
        private Label label2;
        private Label lblHeader;
        private Label label4;
        private GroupBox groupBox1;

        public FrmLogin()
        {
            InitializeComponent();
        }

        Connection logincon = new Connection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Location = new System.Drawing.Point(286, 171);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(85, 27);
            this.btnLoginCancel.TabIndex = 3;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(372, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(185, 88);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(272, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(185, 114);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(272, 20);
            this.txtUserPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(81, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(374, 17);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "NWA MANAGEMENT INFORMATION SYSTEM v1.0";
            this.lblHeader.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Designed, Developed and Maintained by: ICT-FDMA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(496, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void login()
        {
            try
            {
                if (logincon.kon.State == ConnectionState.Closed)
                {
                    logincon.kon.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT USER_NAME,USER_PASSWORD FROM TBL_USERS WHERE USER_NAME='" + txtUserName.Text + "' and USER_PASSWORD='" + txtUserPassword.Text + "'", logincon.kon);
                SqlDataReader dr = cmd.ExecuteReader();
                string usertext = txtUserName.Text;
                string passtext = txtUserPassword.Text;

                while (dr.Read())
                {
                    if (this.CompareStrings(dr["USER_NAME"].ToString(), usertext) &&
                        this.CompareStrings(dr["USER_PASSWORD"].ToString(), passtext))
                    {
                        FrmMainWindow MW = new FrmMainWindow();
                        MW.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User! Try again with VALID username and password");
                    }
                }
                    dr.Close();
                    if (logincon.kon.State == ConnectionState.Open)
                    {
                        logincon.kon.Close();
                    }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //if (logincon.kon.State == ConnectionState.Open)
                //{
                //    logincon.kon.Close();
                //}
            }
      }
     }
    }

