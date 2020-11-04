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
using System.Diagnostics;

namespace PresentacionGUI
{
    public partial class FrmGestionPersona : Form
    {
        PersonaService service;
        public FrmGestionPersona()
        {
            InitializeComponent();
            service = new PersonaService();
            TxtPulsacion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Persona persona = MapearTextoPersona();
            string mensaje = service.Guardar(persona);
            MessageBox.Show(mensaje);
        }

        private Persona MapearTextoPersona()
        {
            Persona persona = new Persona();
            persona.Identificacion = TxtIdentificacion.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Edad = Convert.ToInt32(TxtEdad.Text);
            persona.Sexo = MapearComboSexo(CmbSexo.Text);
            persona.CalcularPulsacion();
            TxtPulsacion.Text = persona.Pulsacion.ToString();
            return persona;
        }

        private string MapearComboSexo(string sexo)
        {
            if (sexo.Equals("Femenino"))
            {
                return "F";
            }
            else
            {
                return "M";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
