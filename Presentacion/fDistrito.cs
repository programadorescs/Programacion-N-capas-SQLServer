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
  public partial class fDistrito : Form
  {
    public fDistrito()
    {
      InitializeComponent();
    }

    private Entidades.Distrito regActual;

    private void ActivarPanel(bool estado)
    {
      pDato.Enabled = estado;
      pCatalogo.Enabled = !estado;
      if (estado) txtDistrito.Focus();
      else txtBuscar.Focus();
    }

    private void Leer(string dato)
    {
      try
      {
        dgvLista.DataSource = Negocio.cnDistrito.Listar(dato);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void PresentarDatos()
    {
      txtDistrito.Text = regActual.nomdistrito;
    }

    private void fDistrito_Load(object sender, EventArgs e)
    {
      dgvLista.AutoGenerateColumns = false;
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
      txtDistrito.Clear();
      ActivarPanel(true);
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (dgvLista.CurrentRow != null)
      {
        regActual = (Entidades.Distrito)dgvLista.CurrentRow.DataBoundItem;
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
        Negocio.cnDistrito.Eliminar((Entidades.Distrito)dgvLista.CurrentRow.DataBoundItem);
        Leer("");
      }
      else
        MessageBox.Show("Debe seleccionar un registro...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      var oEntidad = new Entidades.Distrito();
      if (regActual != null)
        oEntidad.coddistrito = regActual.coddistrito;

      oEntidad.nomdistrito = txtDistrito.Text.Trim();

      try
      {
        Negocio.cnDistrito.Grabar(oEntidad);
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
