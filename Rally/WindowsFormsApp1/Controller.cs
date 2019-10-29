using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    class Controller
    {
        List<Persona> Pilotos;
        List<Persona> Navegantes;
        Form1 vistaPersonas;

        public Controller(Form1 vistaPersonas)
        {
            Pilotos = new List<Persona>();
            this.vistaPersonas = vistaPersonas;
            this.vistaPersonas.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;

            Navegantes = new List<Persona>();
            this.vistaPersonas = vistaPersonas;
            this.vistaPersonas.OnAgregarNavegante += VistaNavegantes_OnAgregarNavegante;
        }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, Rol.Piloto);
            Pilotos.Add(piloto);
            vistaPersonas.ActualizarListadoPilotos(piloto);
        }

        private void VistaNavegantes_OnAgregarNavegante(object sender, AgregarNaveganteEventArgs e)
        {
            Persona navegante = new Persona(e.nombre, Rol.Navegante);
            Navegantes.Add(navegante);
            vistaPersonas.ActualizarListadoNavegantes(navegante);
        }


    }
}
