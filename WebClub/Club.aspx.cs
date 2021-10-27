using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades.Admin;
using Entidades.Models;

namespace WebClub
{
    public partial class vistaClub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarJugadores();
                llenarDropdownList();
            }
        }

        private void mostrarJugadores()
        {
            gridJugador.DataSource = AdmJugador.Listar();
            gridJugador.DataBind();
        }

        private void borrarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
        }

        private void llenarDropdownList()
        {
            DataTable dt = AdmJugador.ListarPuestos();
            ddlPuesto.DataSource = dt;
            ddlPuesto.DataTextField = dt.Columns["Puesto"].ToString();

            ddlPuesto.DataBind();


            ddlBuscarPorPuesto.DataSource = dt;
            ddlBuscarPorPuesto.DataTextField = dt.Columns["Puesto"].ToString();
            DataRow fila = dt.NewRow();
            fila["Puesto"] = "[Todos]";
            dt.Rows.InsertAt(fila, 0);

            ddlBuscarPorPuesto.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarJugador();
        }

        private void guardarJugador()
        {
            Jugador jugador = new Jugador(txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNacimiento.Text), ddlPuesto.SelectedValue);


            int filasModificadas = AdmJugador.Insertar(jugador);

            if (filasModificadas > 0)
            {
                mostrarJugadores();
                borrarCampos();
            }
        }

        protected void ddlBuscarPorPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puesto = ddlBuscarPorPuesto.SelectedValue;

            if (puesto == "[Todos]")
            {
                mostrarJugadores();
            }
            else
            {
                gridJugador.DataSource = AdmJugador.Listar(puesto);
                gridJugador.DataBind();
            }
        }

        private void modificarJugador()
        {
            Jugador jugadorModificado = new Jugador(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNacimiento.Text), ddlPuesto.SelectedValue);

            int filasAfectadas = AdmJugador.Modificar(jugadorModificado);

            if (filasAfectadas > 0)
            {
                mostrarJugadores();
                borrarCampos();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            modificarJugador();
        }

        private void eliminarJugador()
        {
            int jugadorEliminar = int.Parse(txtId.Text);

            int filasAfectadas = AdmJugador.Eliminar(jugadorEliminar);

            if (filasAfectadas > 0)
            {
                mostrarJugadores();
                borrarCampos();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarJugador();
        }
    }
}