using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Classses.Class1.wsr_ = new DataBaseFolder.wsr_user_10Entities();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserInS = Classses.Class1.wsr_.user;
            //skdjfglhsdfkljg


        }
    }
}
