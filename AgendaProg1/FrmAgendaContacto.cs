using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Database;
using Database.Models;
using System.Configuration;
using System.IO;
using AgendaProg1.CustomControlItem;

namespace AgendaProg1
{
    public partial class FrmAgendaContacto : Form
    {
        private readonly PersonService _service;
        private int _id;
        private string _filename;

        private readonly TipoContactoRepositoryDatabase _repositoryTipoContacto;

        public FrmAgendaContacto()
        {
          
            _id = 0;
            _filename = "";
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            _service = new PersonService(connection);
            _repositoryTipoContacto = new TipoContactoRepositoryDatabase(connection);
        }

        #region Events


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                Add();
            }
            else
            {
                Edit();
            }

        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void FrmAgendaContacto_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }


        private void DgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;

                _id = Convert.ToInt32( DgvPersons.Rows[index].Cells[0].Value.ToString());
                TxtName.Text = DgvPersons.Rows[index].Cells[1].Value.ToString();
                TxtLastName.Text = DgvPersons.Rows[index].Cells[2].Value.ToString();
                TxtPhone.Text = DgvPersons.Rows[index].Cells[3].Value.ToString();

                CbxTipoContacto.SelectedIndex =
                    CbxTipoContacto.FindStringExact(DgvPersons.Rows[index].Cells[4].Value.ToString());

                string path = _service.GetPhotoPath(_id);

                PbFotoPerfil.ImageLocation = path;

                BtnDeselect.Visible = true;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSubirFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        #endregion


        #region Private Methods
        private void Add()
        {
            Person person = new Person();

            ComboBoxItem selectedItem = CbxTipoContacto.SelectedItem as ComboBoxItem;

            person.Name = TxtName.Text;
            person.LastName = TxtLastName.Text;
            person.Phone = TxtPhone.Text;
            person.IdTipoContacto = Convert.ToInt32(selectedItem.Value);

            _service.Add(person);

            if (!string.IsNullOrEmpty(_filename))
            {
                SavePhoto();
            }
            LoadData();
            ClearData();


        }

        private void Edit()
        {
            Person person = new Person();
            ComboBoxItem selectedItem = CbxTipoContacto.SelectedItem as ComboBoxItem;

            person.Id = _id;
            person.Name = TxtName.Text;
            person.LastName = TxtLastName.Text;
            person.Phone = TxtPhone.Text;
            person.IdTipoContacto = Convert.ToInt32(selectedItem.Value);

            _service.Edit(person);

            if (!string.IsNullOrEmpty(_filename))
            {
                SavePhoto();
            }

            LoadData();
            ClearData();
            Deselect();


        }

        private void AddPhoto()
        {

            DialogResult result = FotoDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = FotoDialog.FileName;

                _filename = file;

                PbFotoPerfil.ImageLocation = _filename;
            }

        }

        private void SavePhoto()
        {
            int id = _id == 0 ? _service.GetLastId() : _id;

            string directory = @"Images\Contacto\" + id + "\\";


            string[] fileNameSplit = _filename.Split('\\');
            string filename = fileNameSplit[(fileNameSplit.Length - 1)];

            CreateDirectory(directory);

            string destination = directory + filename;

            File.Copy(_filename,destination,true);

            _service.SavePhoto(id, destination);

        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private void ClearData()
        {
            TxtName.Clear();
            TxtLastName.Clear();
            TxtPhone.Clear();

            CbxTipoContacto.SelectedIndex = 0;

            _filename = "";

            PbFotoPerfil.ImageLocation = "";
        }

        private void LoadComboBox()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = null
            };

            List<TipoContacto> listaTipo = _repositoryTipoContacto.GetAll();

            CbxTipoContacto.Items.Add(opcionPorDefecto);

            foreach (TipoContacto item in listaTipo)
            {

                ComboBoxItem comboItem = new ComboBoxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };

                CbxTipoContacto.Items.Add(comboItem);

            }

            CbxTipoContacto.SelectedItem = opcionPorDefecto;

        }


        private void LoadData()
        {
          

            DgvPersons.DataSource = _service.GetAll();
            DgvPersons.ClearSelection();

        }

        private void Deselect()
        {
            DgvPersons.ClearSelection();
            _id = 0;
            BtnDeselect.Visible = false;
            ClearData();
        }

        private void Delete()
        {
            if (_id < 0)
            {
                MessageBox.Show("Debe seleccionar a un contacto", "Notificacion");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar a este contacto",
                    "Advertencia", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    var path = _service.GetPhotoPath(_id);
                    _service.Delete(_id);
                    File.Delete(path);
                    LoadData();
                    Deselect();
                    ClearData();
                }

            }
        }

        #endregion

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola","hola");
        }

       
    }
}
