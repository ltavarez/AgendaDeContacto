namespace AgendaProg1
{
    partial class FrmAgendaContacto
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvPersons = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblTipoContacto = new System.Windows.Forms.Label();
            this.CbxTipoContacto = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFotoPerfil = new System.Windows.Forms.Label();
            this.BtnSubirFoto = new System.Windows.Forms.Button();
            this.FotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.PbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.08499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.86438F));
            this.tableLayoutPanel1.Controls.Add(this.DgvPersons, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbFotoPerfil, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.833333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1106, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvPersons
            // 
            this.DgvPersons.AllowUserToAddRows = false;
            this.DgvPersons.AllowUserToDeleteRows = false;
            this.DgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPersons.Location = new System.Drawing.Point(269, 232);
            this.DgvPersons.MultiSelect = false;
            this.DgvPersons.Name = "DgvPersons";
            this.DgvPersons.ReadOnly = true;
            this.DgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersons.Size = new System.Drawing.Size(558, 310);
            this.DgvPersons.TabIndex = 0;
            this.DgvPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersons_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnDeselect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(269, 548);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(558, 27);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnDeselect
            // 
            this.BtnDeselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeselect.Location = new System.Drawing.Point(282, 3);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(273, 21);
            this.BtnDeselect.TabIndex = 1;
            this.BtnDeselect.Text = "Deseleccionar";
            this.BtnDeselect.UseVisualStyleBackColor = true;
            this.BtnDeselect.Visible = false;
            this.BtnDeselect.Click += new System.EventHandler(this.BtnDeselect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(3, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(273, 21);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LblName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblPhone, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtLastName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtPhone, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.LblTipoContacto, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.CbxTipoContacto, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.LblFotoPerfil, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.BtnSubirFoto, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(558, 223);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(273, 21);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Nombre:";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(273, 21);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Apellido:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPhone
            // 
            this.LblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(3, 74);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(273, 21);
            this.LblPhone.TabIndex = 5;
            this.LblPhone.Text = "Telefono:";
            this.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(282, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(273, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLastName.Location = new System.Drawing.Point(282, 40);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(273, 20);
            this.TxtLastName.TabIndex = 7;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone.Location = new System.Drawing.Point(282, 77);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(273, 20);
            this.TxtPhone.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.BtnSave, 2);
            this.BtnSave.Location = new System.Drawing.Point(3, 188);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(552, 32);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblTipoContacto
            // 
            this.LblTipoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipoContacto.AutoSize = true;
            this.LblTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoContacto.Location = new System.Drawing.Point(3, 111);
            this.LblTipoContacto.Name = "LblTipoContacto";
            this.LblTipoContacto.Size = new System.Drawing.Size(273, 20);
            this.LblTipoContacto.TabIndex = 10;
            this.LblTipoContacto.Text = "Tipo de contacto:";
            this.LblTipoContacto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CbxTipoContacto
            // 
            this.CbxTipoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxTipoContacto.FormattingEnabled = true;
            this.CbxTipoContacto.Location = new System.Drawing.Point(282, 114);
            this.CbxTipoContacto.Name = "CbxTipoContacto";
            this.CbxTipoContacto.Size = new System.Drawing.Size(273, 21);
            this.CbxTipoContacto.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(830, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar Session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // LblFotoPerfil
            // 
            this.LblFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFotoPerfil.AutoSize = true;
            this.LblFotoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFotoPerfil.Location = new System.Drawing.Point(3, 148);
            this.LblFotoPerfil.Name = "LblFotoPerfil";
            this.LblFotoPerfil.Size = new System.Drawing.Size(273, 20);
            this.LblFotoPerfil.TabIndex = 12;
            this.LblFotoPerfil.Text = "Foto de perfil:";
            this.LblFotoPerfil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnSubirFoto
            // 
            this.BtnSubirFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubirFoto.Location = new System.Drawing.Point(282, 151);
            this.BtnSubirFoto.Name = "BtnSubirFoto";
            this.BtnSubirFoto.Size = new System.Drawing.Size(273, 23);
            this.BtnSubirFoto.TabIndex = 13;
            this.BtnSubirFoto.Text = "Subir foto";
            this.BtnSubirFoto.UseVisualStyleBackColor = true;
            this.BtnSubirFoto.Click += new System.EventHandler(this.BtnSubirFoto_Click);
            // 
            // PbFotoPerfil
            // 
            this.PbFotoPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFotoPerfil.Location = new System.Drawing.Point(3, 3);
            this.PbFotoPerfil.Name = "PbFotoPerfil";
            this.PbFotoPerfil.Size = new System.Drawing.Size(260, 223);
            this.PbFotoPerfil.TabIndex = 4;
            this.PbFotoPerfil.TabStop = false;
            // 
            // FrmAgendaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAgendaContacto";
            this.Text = "Agenda de contactos";
            this.Load += new System.EventHandler(this.FrmAgendaContacto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvPersons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnDeselect;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.Label LblTipoContacto;
        private System.Windows.Forms.ComboBox CbxTipoContacto;
        private System.Windows.Forms.Label LblFotoPerfil;
        private System.Windows.Forms.Button BtnSubirFoto;
        private System.Windows.Forms.OpenFileDialog FotoDialog;
        private System.Windows.Forms.PictureBox PbFotoPerfil;
    }
}

