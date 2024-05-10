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

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillComboBox();
        }

        private List<City> LoadCities()
        {
            List<City> cities = new List<City>();
            string[] lines = File.ReadAllLines("City.txt");
            
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
            comboBox1.DataSource = cities;
            comboBox1.DisplayMember = "CityName";
            comboBox1.ValueMember = "CityNumber";
        }

    }
}
