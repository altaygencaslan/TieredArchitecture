using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TieredArchitecture.Business.LocationRepository;
using TieredArchitecture.Business.Model;

namespace TieredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveLocation()
        {
            LocationRepository locationRepository = new LocationRepository();
            locationRepository.Create(new LocationModel
            {
                Id = 340001,
                Name = "İstanbul-Bolge1",
                Adress = "Başakşehir"
            });
        }

        private void saveCategory()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.Create(new CategoryModel
            {
                Id = 1,
                LocationId = 340001,
                Name = "Ana Merkez",
                PopulationLimit = 100

            });
        }


        private void saveEmploye()
        {
            EmployeRepository employeRepository = new EmployeRepository();
            employeRepository.Create(new EmployeModel
            {
                Id = 1,
                CategoryId = 1,
                Name = "Ad",
                LastName = "Soyad",
                StartDate = DateTime.Parse("01/01/2019")
            });
        }
    }
}
