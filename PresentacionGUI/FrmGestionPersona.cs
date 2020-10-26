using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PresentacionGUI
{
    public partial class FrmGestionPersona : Form
    {
        public FrmGestionPersona()
        {
            InitializeComponent();
            TxtPulsacion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = TxtIdentificacion.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Edad = Convert.ToInt32(TxtEdad.Text);
            persona.Sexo = CmbSexo.Text;
            persona.CalcularPulsacion();
            TxtPulsacion.Text = persona.Pulsacion.ToString();
            PersonaService service = new PersonaService();
            string mensaje=service.Guardar(persona);
            MessageBox.Show(mensaje);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
