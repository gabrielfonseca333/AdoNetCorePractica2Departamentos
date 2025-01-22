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

        private async Task LoadEmpleadosAsync()
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            List<Empleado> empleados = await this.repo.GetEmpleadosXDepartamentoAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(
                    emp.Apellido);
            }
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDepartamentos.SelectedIndex != -1)
            {
                
                await this.LoadEmpleadosAsync();

                string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
                Departamento departamento = await repo.GetDepartamentoXNombre(nombreDepartamento);
                this.txtIdDepartamento.Text = departamento.IdDepartamento.ToString();
                this.txtNombreDepartamento.Text = departamento.Nombre;
                this.txtLocalidad.Text = departamento.Localidad;



            }
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();
                Empleado empleado = await repo.GetEmpleadoXApellido(apellido);
                this.txtApellido.Text = empleado.Apellido;
                this.txtOficio.Text = empleado.Oficio;
                this.txtSalario.Text = empleado.Salario.ToString();
            }
        }

        private async void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            int numeroDept = int.Parse(this.txtIdDepartamento.Text);
            string nombreDept = this.txtNombreDepartamento.Text;
            string localidad = this.txtLocalidad.Text;

            await this.repo.InsertarDepartamentoAsync(numeroDept, nombreDept, localidad);
            await this.LoadDepartamentosAsync();
            MessageBox.Show("Se ha añadido correctamente el departamento: " + nombreDept);

        }

        private async void btnUpdateEmpleado_Click(object sender, EventArgs e)
        {
            string oldApellido = this.lstEmpleados.SelectedItem.ToString();
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            string newApellido = this.txtApellido.Text;
            await this.repo.UpdateEmpleadoAsync(newApellido, oficio, salario, oldApellido);
            await this.LoadEmpleadosAsync();
            MessageBox.Show("Se ha moficiado el empleado correctamente! ");

        }
    }
}
