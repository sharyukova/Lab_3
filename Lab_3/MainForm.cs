using Lab_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            FillComboBox();

            dt.Columns.Add("id", typeof(decimal));
            dt.Columns.Add("Название", typeof(string));
            dt.Columns.Add("Город", typeof(string));
            dt.Columns.Add("Изображение", typeof(string));

            dt.Columns["id"].AutoIncrement = true;
            dt.Columns["id"].AutoIncrementSeed = 1; // начальное значение
            dt.Columns["id"].AutoIncrementStep = 1;

            LoadUniversities(); 

            universGridView.DataSource = dt;

        }

        private List<City> LoadCities()
        {
            List<City> cities = new List<City>();
            
            string[] lines = File.ReadAllLines("..\\..\\Files\\City.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('.');
                if (parts.Length == 2)
                {
                    cities.Add(new City { CityNumber = int.Parse(parts[0]), CityName = parts[1] });
                }
            }
            

            return cities;
        }

      

        private void FillComboBox()
        {
            List<City> cities = LoadCities();
            citySelected.DataSource = cities;
            citySelected.DisplayMember = "CityName";
            citySelected.ValueMember = "CityNumber";
        }

        private void LoadUniversities()
        {
            universGridView.Rows.Clear();
            
            string[] lines = File.ReadAllLines("..\\..\\Files\\Universities.txt");
            string[] values;
            
            int nextId = 1;
            
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(new char[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                
                values[0] = nextId.ToString();
                values[values.Length - 2] = GetCityName(int.Parse(values[values.Length - 1]));
                values[values.Length - 1] = GetPicName(int.Parse(values[values.Length - 1]));

                string[] row = new string[values.Length];
                
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                
                dt.Rows.Add(row);   
                
                nextId++;
            }
        }

        private void citySelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = citySelected.SelectedItem.ToString();


            DataView view = dt.DefaultView;
            
            view.RowFilter = $"Город = '{selectedCity}'";

            universGridView.DataSource = view.ToTable();

        }

        private string GetCityName(int cityNumber)
        {
            List<City> cities = LoadCities();
            switch (cityNumber)
            {
                case 0:
                     return cities[0].CityName;

                case 1:
                     return cities[1].CityName; 

                case 2:
                     return cities[2].CityName;
                     break;
            }
            return cities[0].CityName;
        }

        private string GetPicName(int picNumber)
        {
            switch (picNumber)
            {
                case 1:
                    return "..\\..\\Images\\1 КФУ.jpg";

                case 2:
                    return "..\\..\\Images\\2 МГУ.jpg";

                case 3:
                    return "..\\..\\Images\\3 СПБГУ.jpg";
                
                case 4:
                    return "..\\..\\Images\\4 ИТМО.jpg";
                
                case 5:
                    return "..\\..\\Images\\5 МФТИ.jpg";
                
                case 6:
                    return "..\\..\\Images\\6 КАИ.jpg";

                    //break;
            }
            return "..\\..\\Images\\1 КФУ.jpg";
        }


        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void universGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = universGridView.Rows[e.RowIndex];

                nameField.Text = row.Cells[1].Value.ToString();
                cityField.Text = row.Cells[2].Value.ToString();
                Image image = Image.FromFile(row.Cells[3].Value.ToString());
                univerPic.Image = image;
                imagePath.Text = row.Cells[3].Value.ToString();

               
            }
        }

        private void строкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотить удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (universGridView.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = universGridView.SelectedCells[0];


                    int rowIndex = selectedCell.RowIndex;

                    if (rowIndex != -1)
                    {
                        universGridView.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотить удалить всю таблицу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dt.Rows.Clear();
            }

        }

        private void addPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {               
                string imagePath = openFileDialog.FileName;

                imageField.Text = imagePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();
            newRow["Название"] = newNameField.Text;
            newRow["Город"] = newCityField.Text;
            newRow["Изображение"] = imageField.Text;

            dt.Rows.Add(newRow);

            addPanel.Visible = false;
        }

        private void newNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
            else
            {              
                e.Handled = false;
            }
        }

        private void newCityField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            chanPanel.Visible = false;
        }

        private void OK2btn_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();
            newRow["Название"] = chanNameField.Text;
            newRow["Город"] = chanCityField.Text;
            newRow["Изображение"] = chanImageField.Text;

            dt.Rows.Add(newRow);

            chanPanel.Visible = false;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            chanNameField.Text = nameField.Text;

            chanCityField.Text = cityField.Text;

            Image image2 = univerPic.Image;
            chanUniverPic.Image = univerPic.Image;
            chanImageField.Text = imagePath.Text;

            chanPanel.Visible = true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение «Университеты» \n\nРазработано программой Microsoft Visual Studio Community 2022 (64-разрядная версия) - Current\r\nВерсия 17.7.3\r\n\nШарюкова Алина, группа 09-322 ", "Сведения (О программе)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
