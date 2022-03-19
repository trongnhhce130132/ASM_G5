﻿using ASMLibrary.DataAccess;
using ASMLibrary.Management.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ASMWPF
{
    /// <summary>
    /// Interaction logic for HomePageForm.xaml
    /// </summary>
    public partial class HomePageForm : Window
    {
        MonAnService monAnService = new MonAnService();
        List<MonAn> monAnList;
        KhachHang khachHang;
        public HomePageForm(KhachHang khach)
        {
            InitializeComponent();
            this.khachHang = khach;
            load();
        }
        public void load()
        {

            MonAn monAn = new MonAn();
            monAnList = monAnService.GetMonAns().ToList();
            List<FoodData> foods = new List<FoodData>();
            List<FoodData> foodsMost = new List<FoodData>();

            foreach (MonAn mon in monAnList)
            {
                foods.Add(new FoodData { Id = mon.Idmon, Price = "Giá :" + mon.DonGia, Title = mon.TenMon, ImageData = LoadImage(mon.Hinh) });
            }
            for (int i = 0; i < 3; i++)
            {
                foodsMost.Add(new FoodData { Id = monAnList[i].Idmon, Price = "Giá :" + monAnList[i].DonGia, Title = monAnList[i].TenMon, ImageData = LoadImage(monAnList[i].Hinh) });
            }
            this.lvMostOrdered.ItemsSource = foodsMost;
            this.lvMenu.ItemsSource = foods;
        }

        // for this code image needs to be a project resource
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri(filename));
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            UserForm user = new UserForm(khachHang);
            user.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void lvMostOrdered_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvMostOrdered.SelectedIndex != -1)
            {
                DetailsForm detailsForm = new DetailsForm(monAnList[lvMostOrdered.SelectedIndex], khachHang);
                //    detailsForm.monAn = monAnList[lvMenu.SelectedIndex];
                detailsForm.Show();
                this.Close();
            }
        }

        private void lvMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvMenu.SelectedIndex != -1)
            {
                DetailsForm detailsForm = new DetailsForm(monAnList[lvMenu.SelectedIndex], khachHang);
                //    detailsForm.monAn = monAnList[lvMenu.SelectedIndex];
                detailsForm.Show();
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<FoodData> foods = new List<FoodData>();
            monAnList = monAnService.SearchMonAnByName(txtSearch.Text).ToList();
            foreach (MonAn mon in monAnList)
            {
                foods.Add(new FoodData { Id = mon.Idmon, Price = "Giá :" + mon.DonGia, Title = mon.TenMon, ImageData = LoadImage(mon.Hinh) });
            }
            this.lvMenu.ItemsSource = foods;
        }
    }
    public class FoodData
    {
        private string id;
        private string _Title;
        private string _Price;

        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private BitmapImage _ImageData;
        public BitmapImage ImageData
        {
            get { return this._ImageData; }
            set { this._ImageData = value; }
        }
    }
}
