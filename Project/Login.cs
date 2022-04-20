using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.Mail;

namespace CuedClick
{
    public partial class Login : Form
    {

        static Random _random = new Random();
        static string User_Id;

        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlDataAdapter da = null;
        DataSet ds = null;
        static DataSet dsUser = null;

        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (saveValidation() != true)
            {
                da = new SqlDataAdapter("select * from User_Master where Username=@Username and Status=1", conn);
                da.SelectCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
                ds = new DataSet();
                da.Fill(ds);
                int UserId = Convert.ToInt32(ds.Tables[0].Rows[0]["User_Id"]);

                SqlDataAdapter adp = new SqlDataAdapter("select Password, EmailId  from User_Master where User_Id=" + UserId + " ", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UserInfo.Password = dt.Rows[0]["Password"].ToString();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    UserInfo.User_Id = Convert.ToInt32(ds.Tables[0].Rows[0]["User_Id"]);
                    UserInfo.email_id = ds.Tables[0].Rows[0]["EmailId"].ToString(); 
                    groupBox1.Enabled = false;                 
                    User_Id = ds.Tables[0].Rows[0]["User_Id"].ToString();                  
                    //-------------Example change it after Working--------------------

                    Home H = new Home();
                    H.Show();
                   // H.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
        }



        private bool saveValidation()
        {
            if (txtUsername.Text == "")
            {
                return true;
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void lblNewRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        public static Color[] RandomizeStrings(Color[] arr)
        {
            List<KeyValuePair<int, Color>> list = new List<KeyValuePair<int, Color>>();
            // Add all strings from array
            // Add new random int each time
            foreach (Color s in arr)
            {
                list.Add(new KeyValuePair<int, Color>(_random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array
            Color[] result = new Color[arr.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, Color> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }

        private void txtColor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColor4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static string[] RandomizeStrings2(string[] arr)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            // Add all strings from array
            // Add new random int each time
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array
            string[] result = new string[arr.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (
                SqlCommand cmd = new SqlCommand("select  emailid,password from user_master where username =@name", conn)
                )
            {
                cmd.Parameters.AddWithValue("@name", txtUsername.Text);
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    
                    {
                        string pass = dt.Rows[0]["password"].ToString();
                        string email_id = dt.Rows[0]["emailid"].ToString();
                        SmtpClient SmtpServer = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        SmtpServer.Credentials = new System.Net.NetworkCredential("rajputy243@gmail.com", "Notepad@123");
                        SmtpServer.Port = 587;
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Host = "smtp.gmail.com";
                        mail = new MailMessage();
                        mail.From = new MailAddress("rajputy243@gmail.com");

                        mail.To.Add(email_id);
                        mail.Subject = "Your Password";
                        mail.Body = "Password  Is :- " + pass ;
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Has Been Sent To Your EmailId");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name!!");
                    }
                }
            }
        }

    }
}
