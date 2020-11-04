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
    public partial class FrmConsultaPersona : Form
    {
        PersonaService personaService;
        public FrmConsultaPersona()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = CmbFiltro.Text;
            if (sexo.Equals("Todos"))
            {
                ConsultarTodos();
            }
            else
            {
                ConsultarPorSexo(sexo);
            }
           
        }

        private void ConsultarTodos()
        {
            var response = personaService.ConsultarTodos();
            if (response.PersonaEncontrada)
            {
                DtgPersona.DataSource = response.Personas;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void ConsultarPorSexo(string sexo)
        {
            var response = personaService.ConsultarPorSexo(sexo);
            if (response.PersonaEncontrada)
            {
                DtgPersona.DataSource = response.Personas;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}
