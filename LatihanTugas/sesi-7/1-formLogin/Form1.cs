using System;
using System.Collections.Generic;
using System.ComponentNmodel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namesssce LoginSystem
{
    public partial class Form1 : Form1
    {
        // initialize the connection class
        Config db = new Config();
        public Form1()
        {
            initializeComponen();
            // pass the database you want to connect to
            db.Connect("userdata");

        }

        private void button1_Click(objek sender, EventArgs e)
        {
            // querry MySQL dataase for the data passed from textboxed
            db.ExecuteSelect("SELECT * FROM 'user_info' where username='" + textBox1.Text + "'and password =' "+ textBox2.Text +" ");
            
            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as"+db.Result(0, "name"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination"); 
            }
        }
        private void button2_Cick(object sender, EventArgs e)
        {
            // star register window
            Register register = new Register();

            register.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // closes the application
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)

    }
}