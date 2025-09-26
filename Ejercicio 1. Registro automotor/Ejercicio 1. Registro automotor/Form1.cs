using Ejercicio_1._Registro_automotor.Models;
using Microsoft.Win32;

namespace Ejercicio_1._Registro_automotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular depVehicular = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tbxDNI.Text);
                string nombre = tbxNombre.Text;
                string patente = tbxPatente.Text;

                Persona newPersona = new Persona(dni, nombre);
                RegistroVehiculo newVehiculo = depVehicular.RegistrarVehiculo(newPersona, patente);
            }
            catch (FormatoPatenteNoValidaException ex) //error por patente
            {
                MessageBox.Show(ex.Message);
            }
            catch (RangoDniIncorrectoException ex) //error por dni
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //limpio
            tbxNombre.Clear();
            tbxDNI.Clear();
            tbxPatente.Clear();


        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {           
            FormDatos fDatos = new FormDatos();
            
            for (int i = 0; i < depVehicular.CantidadRegistros; i++)
            {
                
                fDatos.lsbImprimir.Items.Add(depVehicular.VerRegistro(i));
            }

            fDatos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
