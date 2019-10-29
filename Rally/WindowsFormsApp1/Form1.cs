using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;
        public event EventHandler<AgregarNaveganteEventArgs> OnAgregarNavegante;

        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarParticipanteButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarPiloto != null && this.RolComboBox.Text == "Piloto")
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                OnAgregarPiloto(this, pilotoArgs);
            }
            if (OnAgregarNavegante != null && this.RolComboBox.Text == "Navegante")
            {
                AgregarNaveganteEventArgs naveganteArgs = new AgregarNaveganteEventArgs();
                naveganteArgs.nombre = this.NameTextBox.Text;
                OnAgregarNavegante(this, naveganteArgs);
            }

        }
        public void ActualizarListadoPilotos(Persona pilotoNuevo)
        {
            PilotNameComboBox.Items.Add(pilotoNuevo);
        }
        public void ActualizarListadoNavegantes(Persona naveganteNuevo)
        {
            NavigatorNameComboBox.Items.Add(naveganteNuevo);
        }

    }
}
