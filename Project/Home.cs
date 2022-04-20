using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuedClick
{
    public partial class Home : Form
    {
        public static List<StoreColorPair> objColorPair = new List<StoreColorPair>();
        public string UserColor = "";
        public static int CheckIndex = 0;

        public static int countshuff = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ovalShape1_Paint(object sender, PaintEventArgs e)
        {

            //First Arch
            Pen Red = new Pen(Color.Indigo, 10);
            e.Graphics.DrawArc(Red, 30, -2, 390, 380, 240, 75);

            //second Arch
            Pen Black = new Pen(Color.Red, 10);
            e.Graphics.DrawArc(Black, 30, 6, 400, 380, -48, 56);

            //third Arch
            Pen Blue = new Pen(Color.Blue, 10);
            e.Graphics.DrawArc(Blue, 30, 14, 400, 380, 5, 59);

            //Forth Arch
            Pen Yellow = new Pen(Color.Green, 10);
            e.Graphics.DrawArc(Yellow, 30, 20, 380, 382, 60, 70);

            //Fifth Arch
            Pen blackPen = new Pen(Color.Orange, 10);
            e.Graphics.DrawArc(blackPen, 16, 12, 380, 380, 125, 61);

            //sixth Arch
            Pen Pink = new Pen(Color.Violet, 10);
            e.Graphics.DrawArc(Pink, 16, 10, 350, 360, 180, 70);

        }

        private void SetString()
        {
            char[] theArray;
            RandomString(out theArray);

            label1.Text = theArray[0].ToString();
            label2.Text = theArray[1].ToString();
            label3.Text = theArray[2].ToString();
            label4.Text = theArray[3].ToString();
            label5.Text = theArray[4].ToString();
            label6.Text = theArray[5].ToString();
            label7.Text = theArray[6].ToString();
            label8.Text = theArray[7].ToString();
            label9.Text = theArray[8].ToString();
            label10.Text = theArray[9].ToString();
            label11.Text = theArray[10].ToString();
            label12.Text = theArray[11].ToString();
            label13.Text = theArray[12].ToString();
            label14.Text = theArray[13].ToString();
            label15.Text = theArray[14].ToString();
            label16.Text = theArray[15].ToString();
            label17.Text = theArray[16].ToString();
            label18.Text = theArray[17].ToString();
            label19.Text = theArray[18].ToString();
            label20.Text = theArray[19].ToString();
            label21.Text = theArray[20].ToString();
            label22.Text = theArray[21].ToString();
            label23.Text = theArray[22].ToString();
            label24.Text = theArray[23].ToString();
            label25.Text = theArray[24].ToString();
            label26.Text = theArray[25].ToString();
            label27.Text = theArray[26].ToString();
            label28.Text = theArray[27].ToString();
            label29.Text = theArray[28].ToString();
            label30.Text = theArray[29].ToString();
            label31.Text = theArray[30].ToString();
            label32.Text = theArray[31].ToString();
            label33.Text = theArray[32].ToString();
            label34.Text = theArray[33].ToString();
            label35.Text = theArray[34].ToString();
            label36.Text = theArray[35].ToString();

            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[0].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[1].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[2].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[3].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[4].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Indigo", lstval = theArray[5].ToString() });

            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[6].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[7].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[8].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[9].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[10].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Red", lstval = theArray[11].ToString() });

            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[12].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[13].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[14].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[15].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[16].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Blue", lstval = theArray[17].ToString() });

            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[18].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[19].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[20].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[21].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[22].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Green", lstval = theArray[23].ToString() });

            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[24].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[25].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[26].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[27].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[28].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Orange", lstval = theArray[29].ToString() });

            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[30].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[31].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[32].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[33].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[34].ToString() });
            objColorPair.Add(new StoreColorPair { lstColor = "Violet", lstval = theArray[35].ToString() });

        }

        private void Home_Load(object sender, EventArgs e)
        {
            objColorPair.Clear();
            SetString();

            SqlCommand cmdGetColor = new SqlCommand("select Colorname from ColorMaster where cid in (select CId from User_Master where User_Id=@User_id)", Login.conn);
            cmdGetColor.Parameters.AddWithValue("@User_id", UserInfo.User_Id);
            Login.conn.Open();
            var Color = cmdGetColor.ExecuteScalar();
            Login.conn.Close();
            UserColor = Color.ToString();
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            objColorPair.Clear();
            SetString();
        }

        public void RandomString(out char[] arr)
        {
            string Word = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] arr1 = Word.ToCharArray();
            var rnd = new Random();
            var result = arr1.OrderBy(item => rnd.Next());
            arr = result.ToArray();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            countshuff++;

            if (countshuff <= 8)
            {
                char[] Password = UserInfo.Password.ToCharArray();

                List<string> arrIndigo = new List<string>();
                if (UserColor.Equals("Indigo"))
                {
                    arrIndigo.Add(label1.Text);
                    arrIndigo.Add(label2.Text);
                    arrIndigo.Add(label3.Text);
                    arrIndigo.Add(label4.Text);
                    arrIndigo.Add(label5.Text);
                    arrIndigo.Add(label6.Text);
                    if (arrIndigo.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }

                List<string> arrRed = new List<string>();
                if (UserColor.Equals("Red"))
                {
                    arrRed.Add(label7.Text);
                    arrRed.Add(label8.Text);
                    arrRed.Add(label9.Text);
                    arrRed.Add(label10.Text);
                    arrRed.Add(label11.Text);
                    arrRed.Add(label12.Text);
                    if (arrRed.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                        MessageBox.Show("Match Character with Password.");
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }

                List<string> arrBlue = new List<string>();
                if (UserColor.Equals("Blue"))
                {
                    arrBlue.Add(label13.Text);
                    arrBlue.Add(label14.Text);
                    arrBlue.Add(label15.Text);
                    arrBlue.Add(label16.Text);
                    arrBlue.Add(label17.Text);
                    arrBlue.Add(label18.Text);
                    if (arrBlue.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                        MessageBox.Show("Match Character with Password.");
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }

                List<string> arrGreen = new List<string>();
                if (UserColor.Equals("Green"))
                {
                    arrGreen.Add(label19.Text);
                    arrGreen.Add(label20.Text);
                    arrGreen.Add(label21.Text);
                    arrGreen.Add(label22.Text);
                    arrGreen.Add(label23.Text);
                    arrGreen.Add(label24.Text);
                    if (arrGreen.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                        MessageBox.Show("Match Character with Password.");
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }

                List<string> arrOrange = new List<string>();
                if (UserColor.Equals("Orange"))
                {
                    arrOrange.Add(label25.Text);
                    arrOrange.Add(label26.Text);
                    arrOrange.Add(label27.Text);
                    arrOrange.Add(label28.Text);
                    arrOrange.Add(label29.Text);
                    arrOrange.Add(label30.Text);
                    if (arrOrange.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                        MessageBox.Show("Match Character with Password.");
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }

                List<string> arrViolet = new List<string>();
                if (UserColor.Equals("Violet"))
                {
                    arrViolet.Add(label31.Text);
                    arrViolet.Add(label32.Text);
                    arrViolet.Add(label33.Text);
                    arrViolet.Add(label34.Text);
                    arrViolet.Add(label35.Text);
                    arrViolet.Add(label36.Text);

                    if (arrViolet.Contains(Password[CheckIndex].ToString()))
                    {
                        CheckIndex++;
                        MessageBox.Show("Match Character with Password.");
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Matching");
                        return;
                    }
                }


                if (CheckIndex > UserInfo.Password.Length - 1)
                {
                    btnnext.Enabled = false;
                    MessageBox.Show("Login Success : Finish Matching");
                    this.Hide();
                    HomeForm HF = new HomeForm();
                    HF.Show();
                }
            }
            else
            {
                MessageBox.Show("WRONG Password. Chances out of Range.");
                SmtpClient SmtpServer = new SmtpClient();
                MailMessage mail = new MailMessage();
                SmtpServer.Credentials = new System.Net.NetworkCredential("rajputy243@gmail.com", "Notepad@123");
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.Host = "smtp.gmail.com";
                mail = new MailMessage();
                mail.From = new MailAddress("rajputy243@gmail.com");

                mail.To.Add(UserInfo.email_id);
                mail.Subject = "Invalid Login Access!!";
                mail.Body = "Invalid Login Access!!";
                SmtpServer.Send(mail);
                this.Hide();
            }

        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public class StoreColorPair
    {
        public string lstColor { get; set; }
        public string lstval { get; set; }
    }

}
