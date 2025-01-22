using AdoNetCorePractica2Departamentos.Models;
using AdoNetCorePractica2Departamentos.Repositories;

namespace AdoNetCorePractica2Departamentos
{

    public partial class Form1 : Form
    {

        RepositoryDepartamentosEmpleados repo;

        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentosAsync();
        }

        private async Task LoadDepartamentosAsync()
        {
            List<Departamento> departamentos = await repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Nombre);
            }
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbDepartamentos.SelectedIndex != -1)
            {
                string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
                List<Empleado> empleados = await this.repo.GetEmpleadosXDepartamentoAsync(nombreDepartamento);
                this.lstEmpleados.Items.Clear();
                foreach(Empleado emp in empleados)
                {
                    this.lstEmpleados.Items.Add(
                        emp.Apellido + " - " + emp.Oficio);
                }
                Departamento departamento = await repo.GetDepartamentoXNombre(nombreDepartamento);
                //this.txtIdDepartamento = departamento.IdDepartamento.ToString()



            }
        }
    }
}
