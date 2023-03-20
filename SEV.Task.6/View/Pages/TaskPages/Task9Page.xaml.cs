﻿using SEV.Task._6.Core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SEV.Task._6.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                int DecimalNumber = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[A.Length - i - 1] == '0') continue;
                    DecimalNumber += (int)Math.Pow(2, i);
                }
                string B = Convert.ToString(DecimalNumber, 16);
                MessageBox.Show($"{B}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
