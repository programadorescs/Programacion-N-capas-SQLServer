using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
  public partial class fAmigo : Form
  {
    public fAmigo()
    {
      InitializeComponent();
    }

    private Entidades.Amigo regActual;

    private void ActivarPanel(bool estado)
    {
      pDato.Enabled = estado;
      pCatalogo.Enabled = !estado;
      if (estado) txtNombre.Focus();
      else txtBuscar.Focus();
    }

    private void Leer(string dato)
    {
      try
      {
        dgvLista.DataSource = Negocio.cnAmigo.Listar(dato);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void LeerDistrito()
    {
      try
      {
        cbDistrito.ValueMember = "coddistrito";
        cbDistrito.DisplayMember = "nomdistrito";
        cbDistrito.DataSource = Negocio.cnDistrito.Listar("");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void PresentarDatos()
    {
      cbDistrito.Text = regActual.nombredistrito;
      txtNombre.Text = regActual.nombre;
      txtDni.Text = regActual.dni;
      mtbFecNac.Text = regActual.fecnac.ToShortDateString();
      cbSexo.SelectedItem = regActual.sexo;
      txtDireccion.Text = regActual.direccion;
      txtTelefono.Text = regActual.telefono;
    }

    private void fAmigo_Load(object sender, EventArgs e)
    {
      dgvLista.AutoGenerateColumns = false;
      cbSexo.SelectedIndex = 0;
      LeerDistrito();
      Leer("");
    }

    private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        Leer(txtBuscar.Text.Trim());
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      regActual = null;
      txtNombre.Clear();
      ActivarPanel(true);
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (dgvLista.CurrentRow != null)
      {
        regActual = (Entidades.Amigo)dgvLista.CurrentRow.DataBoundItem;
        PresentarDatos();
        ActivarPanel(true);
      }
      else
        MessageBox.Show("Debe seleccionar un registro...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (dgvLista.CurrentRow != null)
      {
        Negocio.cnAmigo.Eliminar((Entidades.Amigo)dgvLista.CurrentRow.DataBoundItem);
        Leer("");
      }
      else
        MessageBox.Show("Debe seleccionar un registro...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      var oEntidad = new Entidades.Amigo();
      if (regActual != null)
        oEntidad.codamigo = regActual.codamigo;

      oEntidad.edistrito = (Entidades.Distrito)cbDistrito.SelectedItem;
      oEntidad.nombre = txtNombre.Text.Trim();
      oEntidad.dni = txtDni.Text.Trim();
      oEntidad.fecnac = Convert.ToDateTime(mtbFecNac.Text);
      oEntidad.sexo = cbSexo.Text;
      oEntidad.direccion = txtDireccion.Text.Trim();
      oEntidad.telefono = txtTelefono.Text.Trim();

      try
      {
        Negocio.cnAmigo.Grabar(oEntidad);
        ActivarPanel(false);
        Leer("");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      finally { oEntidad = null; }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      ActivarPanel(false);
    }
  }
}
