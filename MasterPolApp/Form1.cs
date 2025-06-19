using MasterPolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPartners();
         
        }
         



        //private void LoadPartners()
        //{
        //    using (var context = new DbModel())
        //    {
        //        var partners = context.Partners
        //            .Include(p => p.PartnerProducts)
        //            .ToList();
        //        dataGridViewPartners.DataSource = partners; 
        //    }
        //}

        private void LoadPartners()
        {
            using (var context = new DbModel())
            {
                var partners = context.Partners
                    .Include(p => p.PartnerProducts) // загрузим связанные данные
                    .ToList() // загружаем из БД, теперь мы в памяти

                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Director,
                        p.Email,
                        p.Address,
                        p.INN,
                        p.Phone,
                        p.Rating,
                        p.Discount // теперь можно безопасно использовать
                    })
                    .ToList();

                dataGridViewPartners.DataSource = partners;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoToAddPartner_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void buttonRefreshPartners_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void buttonDeletePartner_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartners.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнёра для удаления.");
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного партнёра?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            int partnerId = (int)dataGridViewPartners.CurrentRow.Cells["Id"].Value;

            using (var context = new DbModel())
            {
                var partnerToDelete = context.Partners.FirstOrDefault(p => p.Id == partnerId);
                if (partnerToDelete != null)
                {
                    context.Partners.Remove(partnerToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Партнёр успешно удалён.");

                    LoadPartners(); // Обновить таблицу после удаления
                }
                else
                {
                    MessageBox.Show("Партнёр не найден в базе данных.");
                }
            }
        }

        private void LoadComboBoxHistory()
        {
            using (var context = new DbModel())
            {
                var partners = context.Partners
                    .Select(p => new { p.Id, p.Name })
                    .ToList();

                comboBoxHistory.DisplayMember = "Name";
                comboBoxHistory.ValueMember = "Id";
                comboBoxHistory.DataSource = partners;
            }
        }
        private void LoadHistory(int? partnerId = null)
        {
            using (var context = new DbModel())
            {
                var query = context.PartnerProducts
                    .Include(pp => pp.Partners)
                    .Include(pp => pp.Products)
                    .AsQueryable();

                if (partnerId.HasValue)
                {
                    query = query.Where(pp => pp.PartnerId == partnerId.Value);
                }

                var historyData = query
                    .Select(pp => new
                    {
                        pp.Id,
                        PartnerName = pp.Partners.Name,
                        ProductName = pp.Products.Name,
                        pp.Quantity,
                        pp.SaleDate
                    })
                    .ToList();

                dataGridViewHistory.DataSource = historyData;
            }
        }
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Загрузка истории при переходе на вкладку "История"
            if (tabControlMain.SelectedIndex == 1)
            {
                LoadComboBoxHistory();
                LoadHistory(); 
            }
        }
        private void comboBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHistory.SelectedValue is int selectedPartnerId)
            {
                LoadHistory(selectedPartnerId);
            }
        }

        private void tabPageHistory_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPartner_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddPartnerName.Text))
            {
                MessageBox.Show("Введите название партнера");
                return;
            }

            if (!int.TryParse(textBoxAddPartnerRating.Text.Trim(),out int rating))
            {
                MessageBox.Show("Введите корректное число для рейтинга");
                return;
            }

            using (var context = new DbModel())
            {
                var newPartner = new Partners
                {
                    Name = textBoxAddPartnerName.Text,
                    Director = textBoxAddPertnerDirector.Text,  
                    Email = textBoxAddPartnerEmail.Text,    
                    Address = textBoxAddParentAddress.Text, 
                    INN = textBoxAddPartnerINN.Text,
                    Phone = textBoxAddPartnerPhone.Text,    
                    Rating = rating,  

                };

                context.Partners.Add(newPartner);
                context.SaveChanges();

            }
            MessageBox.Show("Партнер успешно добавлен");

            LoadPartners();
        }

      
    }
}
