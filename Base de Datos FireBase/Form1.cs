using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Base_de_Datos_FireBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "pQmNc1JwlCUFaAEmOURAH9SyDHBfC7wwNykRXLL8",
            BasePath = "https://fir-dbcsharp-default-rtdb.firebaseio.com/"
        };


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
