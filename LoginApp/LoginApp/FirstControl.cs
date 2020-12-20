using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace LoginApp
{
    public partial class FirstControl : UserControl
    {
        public FirstControl()
        {
            InitializeComponent();
            usernameLabel.Text = Form1.LoggedInUser.GetUserName();
            nameLabel.Text = Form1.LoggedInUser.GetName();
            surnameLabel.Text = Form1.LoggedInUser.GetSurname();
            int v = Form1.LoggedInUser.GetAge();
            string age = Convert.ToString(v);
            ageLabel.Text = age;
            passwordLabel.Text = Form1.LoggedInUser.GetPassword();
            if(Form1.LoggedInUser.GetImage() != null)
            {
                image1.ImageLocation = Form1.LoggedInUser.GetImage();
            }
            //image1 = Form1.LoggedInUser.GetImage();

            
        }

        private void FirstControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                    Form1.LoggedInUser.SetImage(imageLocation);
                    
                    //Kaip dabar issaugot i userLista
                }
                MessageBox.Show("Image changed succesfully!");
            }
            catch(Exception)
            {
                MessageBox.Show("Please pick an image");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.LoggedInUser.ChangePassword(textBox1.Text, textBox2.Text);
                passwordLabel.Text = Form1.LoggedInUser.GetPassword();
                MessageBox.Show("Password succesfully changed!");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
