
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Parser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

      
        public MainWindow()
        {
            InitializeComponent();
            CheckFile();

        }

        private void CheckFile()
        {
            if (!File.Exists(Lists.fileInfo))
            {
                DialogResult result = (DialogResult)System.Windows.MessageBox.Show("Файл с данными не был найден. Вы хотите загрузить данные?", "Загрузка данных", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Lists.DownloadFile();
                }
                else
                {
                    this.Close();
                }

            }
            Lists.FullCurrentList();
        }

        private void WatchAllThreats(object sender, RoutedEventArgs e)
        {
            AllThreats taskWindow = new AllThreats();
            taskWindow.Show();
            this.Close();
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Lists.ReplaceToPrevious();
            Lists.DownloadFile();
            Lists.FullCurrentList();
            if (!File.Exists(Lists.fileInfo))
            {
             System.Windows.MessageBox.Show("Не удалось скачать файл", "Ошибка");
            }
            else
            {
                int count = 0;
                
                for (int i = 0; i < Lists.previous.Count; i++)
                {
                    for (int j = 0; j < Lists.current.Count; j++)
                    {
                        if(Lists.CompareItems(Lists.current[j], Lists.previous[i]))
                        {
                            count++;
                           
                        }
                    }
                }
                if((count == Lists.previous.Count) && (count == Lists.current.Count))
                {
                    System.Windows.MessageBox.Show("Используется последняя версия данных", "Ошибка");
                }
                else
                {
                    System.Windows.MessageBox.Show("Данные были успешно изменены", "Успешно");
                    ChangedInfo changedInfo = new ChangedInfo();
                    changedInfo.Show();
                    this.Close();
                }
              
            }
           
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Lists.ChooseFileDialog();
        }
        private void SaveCsv(object sender, RoutedEventArgs e)
        {
            Lists.ChooseFileDialog();
        }

        private void WatchOnly(object sender, RoutedEventArgs e)
        {
            OnlyThreat onlyThreat = new OnlyThreat();
            onlyThreat.Show();
            this.Close();
        }

    }
}

