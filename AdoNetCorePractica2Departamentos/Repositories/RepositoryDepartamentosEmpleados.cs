using AdoNetCorePractica2Departamentos.Helpers;
using AdoNetCorePractica2Departamentos.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region PROCEDIMIENTOS ALMACENADOS

/*
 * 
 CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
AS
BEGIN
	SELECT * FROM DEPT;
END



CREATE PROCEDURE SP_EMPLEADO_DEPARTAMENTO
@nombredepartamento varchar(50)
AS
BEGIN
	SELECT EMP.*
    FROM EMP
    INNER JOIN DEPT
    ON EMP.DEPT_NO = DEPT.DEPT_NO
    WHERE DEPT.DNOMBRE = @nombredepartamento;
END



CREATE PROCEDURE SP_INSERT_DEPT
(@numero int, @nombre varchar(50), @localidad varchar(50))
as
begin
	insert into DEPT values (@numero, @nombre, @localidad)
end

 */

#endregion

namespace AdoNetCorePractica2Departamentos.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {

        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                int idDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.Nombre = nombre;
                dept.IdDepartamento = idDepartamento;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<Departamento> GetDepartamentoXNombre(string nombredepartamento)
        {
            string sql = "SELECT * FROM DEPT WHERE DNOMBRE = @nombredepartamento";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@nombredepartamento", nombredepartamento);

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            Departamento departamento = new Departamento();

            if (await this.reader.ReadAsync())
            {
                int idDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();

                departamento = new Departamento
                {
                    IdDepartamento = idDepartamento,
                    Nombre = nombre,
                    Localidad = localidad
                };
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return departamento;
        }


        public async Task<List<Empleado>> GetEmpleadosXDepartamentoAsync(string nombredepartamento)
        {
            string sql = "SP_EMPLEADO_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@nombredepartamento", nombredepartamento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader= await this.com.ExecuteReaderAsync();
            List<Empleado> empleados = new List<Empleado>();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());

                Empleado emp = new Empleado();
                emp.Apellido = apellido;
                emp.Oficio = oficio;
                emp.Salario = salario;
                empleados.Add(emp);

            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<Empleado> GetEmpleadoXApellido(string apellidoEmp)
        {
            string sql = "SELECT * FROM EMP WHERE APELLIDO = @apellido";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@apellido", apellidoEmp);

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            Empleado empleado = new Empleado();

            if (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());

                empleado = new Empleado
                {
                    Apellido = apellido,
                    Oficio = oficio,
                    Salario = salario
                };
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return empleado;
        }

        public async Task InsertarDepartamentoAsync(int numero, string nombre, string localidad)
        {
            string sql = "SP_INSERT_DEPT";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateEmpleadoAsync(string newApellido, string oficio, int salario, string oldApellido)
        {
            string sql = "SP_UPDATE_EMP";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@newApellido", newApellido);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);
            this.com.Parameters.AddWithValue("@oldApellido", oldApellido);

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }



    }
}
