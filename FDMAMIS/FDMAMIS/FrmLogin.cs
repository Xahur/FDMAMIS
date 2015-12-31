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
        private Label lblUserName;
        private Label lblUserPassword;
        private Label lblHeader;
        private Label lblLoginFooter;
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLoginFooter = new System.Windows.Forms.Label();
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
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(80, 91);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(80, 117);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblUserPassword.TabIndex = 6;
            this.lblUserPassword.Text = "Password";
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
            this.lblHeader.Location = new System.Drawing.Point(40, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(420, 17);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "FATA TDPS MANAGEMENT INFORMATION SYSTEM v1.0";
            this.lblHeader.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLoginFooter
            // 
            this.lblLoginFooter.AutoSize = true;
            this.lblLoginFooter.Location = new System.Drawing.Point(131, 229);
            this.lblLoginFooter.Name = "lblLoginFooter";
            this.lblLoginFooter.Size = new System.Drawing.Size(256, 13);
            this.lblLoginFooter.TabIndex = 9;
            this.lblLoginFooter.Text = "Designed, Developed and Maintained by: ICT-FDMA";
            this.lblLoginFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginFooter.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(496, 246);
            this.Controls.Add(this.lblLoginFooter);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserName);
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
  
        private void login()
        {
            try
            {
                if (logincon.kon.State == ConnectionState.Closed)
                {
                    logincon.kon.Open();
                }
                    SqlCommand cmd = new SqlCommand("SELECT USER_NAME,USER_PASSWORD FROM TBL_USERS WHERE USER_NAME='" + txtUserName.Text + "' and USER_PASSWORD='" + txtUserPassword.Text + "'", logincon.kon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i==1)
                    {
                        this.Hide();
                        FrmMainWindow MW = new FrmMainWindow();
                        MW.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password, please retry!");
                    }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (logincon.kon.State == ConnectionState.Open)
                {
                    logincon.kon.Close();
                }
            }
      }
     }
    }

