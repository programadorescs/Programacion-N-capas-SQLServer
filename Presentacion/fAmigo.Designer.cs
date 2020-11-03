namespace Presentacion
{
  partial class fAmigo
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pDato = new System.Windows.Forms.Panel();
      this.cbSexo = new System.Windows.Forms.ComboBox();
      this.mtbFecNac = new System.Windows.Forms.MaskedTextBox();
      this.cbDistrito = new System.Windows.Forms.ComboBox();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDni = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.pCatalogo = new System.Windows.Forms.Panel();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.dgvLista = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pDato.SuspendLayout();
      this.pCatalogo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
      this.SuspendLayout();
      // 
      // pDato
      // 
      this.pDato.Controls.Add(this.cbSexo);
      this.pDato.Controls.Add(this.mtbFecNac);
      this.pDato.Controls.Add(this.cbDistrito);
      this.pDato.Controls.Add(this.txtTelefono);
      this.pDato.Controls.Add(this.label8);
      this.pDato.Controls.Add(this.txtDireccion);
      this.pDato.Controls.Add(this.label7);
      this.pDato.Controls.Add(this.label6);
      this.pDato.Controls.Add(this.label5);
      this.pDato.Controls.Add(this.txtDni);
      this.pDato.Controls.Add(this.label4);
      this.pDato.Controls.Add(this.txtNombre);
      this.pDato.Controls.Add(this.label3);
      this.pDato.Controls.Add(this.label2);
      this.pDato.Controls.Add(this.btnCancelar);
      this.pDato.Controls.Add(this.btnAceptar);
      this.pDato.Dock = System.Windows.Forms.DockStyle.Right;
      this.pDato.Enabled = false;
      this.pDato.Location = new System.Drawing.Point(576, 0);
      this.pDato.Name = "pDato";
      this.pDato.Size = new System.Drawing.Size(208, 338);
      this.pDato.TabIndex = 1;
      // 
      // cbSexo
      // 
      this.cbSexo.BackColor = System.Drawing.Color.White;
      this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSexo.FormattingEnabled = true;
      this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
      this.cbSexo.Location = new System.Drawing.Point(6, 188);
      this.cbSexo.Name = "cbSexo";
      this.cbSexo.Size = new System.Drawing.Size(190, 21);
      this.cbSexo.TabIndex = 9;
      // 
      // mtbFecNac
      // 
      this.mtbFecNac.BackColor = System.Drawing.Color.White;
      this.mtbFecNac.Location = new System.Drawing.Point(6, 149);
      this.mtbFecNac.Mask = "00/00/0000";
      this.mtbFecNac.Name = "mtbFecNac";
      this.mtbFecNac.Size = new System.Drawing.Size(190, 20);
      this.mtbFecNac.TabIndex = 7;
      this.mtbFecNac.ValidatingType = typeof(System.DateTime);
      // 
      // cbDistrito
      // 
      this.cbDistrito.BackColor = System.Drawing.Color.White;
      this.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDistrito.FormattingEnabled = true;
      this.cbDistrito.Location = new System.Drawing.Point(6, 31);
      this.cbDistrito.Name = "cbDistrito";
      this.cbDistrito.Size = new System.Drawing.Size(190, 21);
      this.cbDistrito.TabIndex = 1;
      // 
      // txtTelefono
      // 
      this.txtTelefono.BackColor = System.Drawing.Color.White;
      this.txtTelefono.Location = new System.Drawing.Point(6, 267);
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(190, 20);
      this.txtTelefono.TabIndex = 13;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 251);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(49, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "Telefono";
      // 
      // txtDireccion
      // 
      this.txtDireccion.BackColor = System.Drawing.Color.White;
      this.txtDireccion.Location = new System.Drawing.Point(6, 228);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new System.Drawing.Size(190, 20);
      this.txtDireccion.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 212);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(52, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Direccion";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 172);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Sexo";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 133);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(106, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Fecha de nacimiento";
      // 
      // txtDni
      // 
      this.txtDni.BackColor = System.Drawing.Color.White;
      this.txtDni.Location = new System.Drawing.Point(6, 110);
      this.txtDni.MaxLength = 8;
      this.txtDni.Name = "txtDni";
      this.txtDni.Size = new System.Drawing.Size(190, 20);
      this.txtDni.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 94);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(26, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "DNI";
      // 
      // txtNombre
      // 
      this.txtNombre.BackColor = System.Drawing.Color.White;
      this.txtNombre.Location = new System.Drawing.Point(6, 71);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(190, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 55);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Nombres";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Distrito";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(107, 303);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 15;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(26, 303);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 14;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // pCatalogo
      // 
      this.pCatalogo.Controls.Add(this.btnEliminar);
      this.pCatalogo.Controls.Add(this.btnEditar);
      this.pCatalogo.Controls.Add(this.btnNuevo);
      this.pCatalogo.Controls.Add(this.dgvLista);
      this.pCatalogo.Controls.Add(this.txtBuscar);
      this.pCatalogo.Controls.Add(this.label1);
      this.pCatalogo.Dock = System.Windows.Forms.DockStyle.Left;
      this.pCatalogo.Location = new System.Drawing.Point(0, 0);
      this.pCatalogo.Name = "pCatalogo";
      this.pCatalogo.Size = new System.Drawing.Size(570, 338);
      this.pCatalogo.TabIndex = 0;
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(174, 303);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.Location = new System.Drawing.Point(93, 303);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(75, 23);
      this.btnEditar.TabIndex = 4;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnNuevo
      // 
      this.btnNuevo.Location = new System.Drawing.Point(12, 303);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(75, 23);
      this.btnNuevo.TabIndex = 3;
      this.btnNuevo.Text = "Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // dgvLista
      // 
      this.dgvLista.AllowUserToAddRows = false;
      this.dgvLista.AllowUserToDeleteRows = false;
      this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
      this.dgvLista.Location = new System.Drawing.Point(12, 34);
      this.dgvLista.Name = "dgvLista";
      this.dgvLista.ReadOnly = true;
      this.dgvLista.RowHeadersVisible = false;
      this.dgvLista.Size = new System.Drawing.Size(555, 263);
      this.dgvLista.TabIndex = 2;
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "codamigo";
      this.Column1.Frozen = true;
      this.Column1.HeaderText = "Cod";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Visible = false;
      this.Column1.Width = 50;
      // 
      // Column2
      // 
      this.Column2.DataPropertyName = "nombredistrito";
      this.Column2.Frozen = true;
      this.Column2.HeaderText = "Distrito";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 150;
      // 
      // Column3
      // 
      this.Column3.DataPropertyName = "nombre";
      this.Column3.Frozen = true;
      this.Column3.HeaderText = "Nombre";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 200;
      // 
      // Column4
      // 
      this.Column4.DataPropertyName = "dni";
      this.Column4.HeaderText = "DNI";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 80;
      // 
      // Column5
      // 
      this.Column5.DataPropertyName = "fecnac";
      this.Column5.HeaderText = "FecNac";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 80;
      // 
      // Column6
      // 
      this.Column6.DataPropertyName = "sexo";
      this.Column6.HeaderText = "Sexo";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Width = 70;
      // 
      // Column7
      // 
      this.Column7.DataPropertyName = "direccion";
      this.Column7.HeaderText = "Direccion";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.Width = 180;
      // 
      // Column8
      // 
      this.Column8.DataPropertyName = "telefono";
      this.Column8.HeaderText = "Telefono";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      // 
      // txtBuscar
      // 
      this.txtBuscar.BackColor = System.Drawing.Color.White;
      this.txtBuscar.Location = new System.Drawing.Point(55, 8);
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(311, 20);
      this.txtBuscar.TabIndex = 1;
      this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Buscar";
      // 
      // fAmigo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 338);
      this.Controls.Add(this.pDato);
      this.Controls.Add(this.pCatalogo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fAmigo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Amigos";
      this.Load += new System.EventHandler(this.fAmigo_Load);
      this.pDato.ResumeLayout(false);
      this.pDato.PerformLayout();
      this.pCatalogo.ResumeLayout(false);
      this.pCatalogo.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pDato;
    private System.Windows.Forms.MaskedTextBox mtbFecNac;
    private System.Windows.Forms.ComboBox cbDistrito;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtDni;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Panel pCatalogo;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.DataGridView dgvLista;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbSexo;
  }
}