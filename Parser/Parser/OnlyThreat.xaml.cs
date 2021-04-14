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

namespace Parser
{
    /// <summary>
    /// Логика взаимодействия для OnlyThreat.xaml
    /// </summary>
    public partial class OnlyThreat : Window
    {
        public OnlyThreat()
        {
            InitializeComponent();
        }

        private void ReturnHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Clear()
        {
            name.Text = "";
            description.Text = "";
            source.Text = "";
            objective.Text = "";
            conf.Text = "";
            integ.Text = "";
            avail.Text = "";
            error.Text = "";

        }

        private void FindInfo(object sender, RoutedEventArgs e)
        {
            Clear();
            try
            {
                int a = Convert.ToInt32(ChooseId.Text);
                if(a > 0 && a <= Lists.current.Count)
                {
                    name.Text = Lists.current[a-1].name;
                    description.Text = Lists.current[a-1].description;
                    source.Text = Lists.current[a-1].source;
                    objective.Text = Lists.current[a-1].objective;
                    conf.Text = Lists.current[a-1].isPolicy.ToString();
                    integ.Text = Lists.current[a-1].isIntegrity.ToString();
                    avail.Text = Lists.current[a-1].isAvailability.ToString();
                }
                else
                {
                    error.Text = "Запись не найдена";
                }
            }
            catch(Exception)
            {
                error.Text = "Введены некорректные данные";
            }
           
        }

    }
}
