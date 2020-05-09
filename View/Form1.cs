using Lab2DavidAlvarado.Controller;
using Lab2DavidAlvarado.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2DavidAlvarado
{
    public partial class Form1 : Form
    {
        private string temp_info;
        public Form1()
        {
            InitializeComponent();
        }
        GuiDataController dc = new GuiDataController();
        DataController sql = new DataController();

        //TextBox solo números
        private void txb_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //TextBox solo letras
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        //Mostrar Contraseña
        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txb_Pass.PasswordChar = chk_showPass.Checked ? '\0' : '*';
        }

        //función botón Registrar
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string name = txb_Name.Text;
            string lastName = txb_LastName.Text;
            string age = txb_Age.Text;
            string id = txb_id.Text;
            string email = txb_Email.Text;
            string pass = txb_Pass.Text;
            string confPass = txb_PassConf.Text;
            temp_info = "Se Agregó: \n" +
                "Nombre: " + name + "\n" +
                "Apellido: " + lastName + "\n" +
                "Edad: " + age + "\n" +
                "Cedula: " + id + "\n" +
                "Email: " + email + "\n";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (!dc.CheckTextBox(name, lastName, age, id, email, pass, confPass))
                MessageBox.Show("Faltan Datos", "Registro incompleto", buttons,MessageBoxIcon.Warning);
            else
            {
                if (pass.Equals(confPass))
                {
                    if (dc.CheckEmailAddress(txb_Email.Text))
                    {
                        //Guarda en la base de datos
                        if(sql.InsertIntoDB(name, lastName, age, id, email, pass))
                        {
                            ClearForm();
                           // MessageBox.Show("Se guardó con éxito");
                            Confirm confirm = new Confirm(temp_info);
                            confirm.Show();
                        }
                        else
                        {
                            MessageBox.Show("NO Se guardó con éxito");
                        }
                }
                    else
                        MessageBox.Show("NO existe el correo");
                }
                else
                {
                    MessageBox.Show("Contraseña no coincide");
                }
                
            }
            
        }//btn_SignIN_click

        private void ClearForm()
        {
            
            txb_Name.Clear();
            txb_LastName.Clear();
            txb_Age.Clear();
            txb_id.Clear();
            txb_Email.Clear();
            txb_Pass.Clear();
            txb_PassConf.Clear();
        }
    }
}
