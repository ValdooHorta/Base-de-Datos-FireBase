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
        IFirebaseClient client;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }catch
            {
                MessageBox.Show("Existe un problema en la conexión de la internet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante std = new Estudiante
            {
                Nombre = txtNombre.Text,
                Cuenta= txtCuenta.Text,
                Semestre = txtSemestre.Text,
                Grupo = txtGrupo.Text
            };
            var setter = client.Set("ListaEstudiantes/"+txtCuenta.Text, std);
            MessageBox.Show("Datos insertados correctamente");
        }
    }
}
