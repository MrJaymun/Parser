using System;
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

namespace Parser
{
    /// <summary>
    /// Логика взаимодействия для AllThreats.xaml
    /// </summary>
    public partial class AllThreats : Window
    {
        private int currentPage = 0;
        public AllThreats()
        {
            InitializeComponent();
            FullThePage();
        }

        private void FullThePage()
        {
            if (Lists.current.Count < currentPage*15+15) {
                for (int i = 0; i < Lists.current.Count-currentPage*15; i++)
                {
                    allInfo.Items.Add(new { id = "УБИ." + Lists.current[currentPage * 15+i].id, name = Lists.current[currentPage * 15 + i].name });
                }
            }
            else
            {
                for (int i = currentPage*15; i < currentPage * 15+15; i++)
                {
                    allInfo.Items.Add(new { id = "УБИ." + Lists.current[i].id, name = Lists.current[i].name });
                }
            }
            if(currentPage == 0)
            {
                prev.IsEnabled = false;
            }
            else
            {
                prev.IsEnabled = true;
            }
            if (currentPage*15+15 >= Lists.current.Count)
            {
                next.IsEnabled = false;
            }
            else
            {
                next.IsEnabled = true;
            }
            allInfo.Items.Refresh();
            pager.Text = "Текущая страница: " + (currentPage+1);
        }

        private void ReturnHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            currentPage++;
           
            for (int i = 0; i < allInfo.Items.Count; i++)
            {
                allInfo.Items.Remove(i);
            }
            allInfo.Items.Clear();
            FullThePage();
        }
        private void PrevPage(object sender, RoutedEventArgs e)
        {
            currentPage--;
            for (int i = 0; i < allInfo.Items.Count; i++)
            {
                allInfo.Items.Remove(i);
            }
            allInfo.Items.Clear();
            FullThePage();
        }



    }
}
