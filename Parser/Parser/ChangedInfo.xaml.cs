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
    /// Логика взаимодействия для ChangedInfo.xaml
    /// </summary>
    public partial class ChangedInfo : Window
    {
        public ChangedInfo()
        {
            InitializeComponent();
            FullThePage();
        }

        private void FullThePage()
        {
            int added = 0;
            int deleted = 0;
            int changed = 0;
            List<int> addedList = new List<int>();
            List<int> deletedList = new List<int>();
            List<int> changedList = new List<int>();
            for (int i = 0; i < Lists.current.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < Lists.previous.Count; j++)
                {
                    if (Lists.current[i].id == Lists.previous[j].id && !Lists.CompareItems(Lists.current[i], Lists.previous[j]))
                    {
                        //Изменение
                        changedList.Add(Lists.current[i].id);
                        changed++;
                        allInfo.Items.Add(new
                        {
                            id = Lists.current[i].id,
                            nameOld = Lists.previous[j].name,
                            descriptionOld = Lists.previous[j].description,
                            sourceOld = Lists.previous[j].source,
                            objectiveOld = Lists.previous[j].objective,
                            isPolicyOld = Lists.previous[j].isPolicy,
                            isIntegrityOld = Lists.previous[j].isIntegrity,
                            isAvailAbilityOld = Lists.previous[j].isAvailability,
                            nameNew = Lists.current[i].name,
                            descriptionNew = Lists.current[i].description,
                            sourceNew = Lists.current[i].source,
                            objectiveNew = Lists.current[i].objective,
                            isPolicyNew = Lists.current[i].isPolicy,
                            isIntegrityNew = Lists.current[i].isIntegrity,
                            isAvailAbilityNew = Lists.current[i].isAvailability
                        });
                    }
                    if (Lists.current[i].id == Lists.previous[j].id)
                    {
                        count++;
                    }
                }
                if(count == 0)
                {
                    //Добавление
                    addedList.Add(Lists.current[i].id);
                    added++;
                    allInfo.Items.Add(new
                    {
                        id = Lists.current[i].id,
                        nameNew = Lists.current[i].name,
                        descriptionNew = Lists.current[i].description,
                        sourceNew = Lists.current[i].source,
                        objectiveNew = Lists.current[i].objective,
                        isPolicyNew = Lists.current[i].isPolicy,
                        isIntegrityNew = Lists.current[i].isIntegrity,
                        isAvailAbilityNew = Lists.current[i].isAvailability
                    });
                }
            }
            for (int i = 0; i < Lists.previous.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < Lists.current.Count; j++)
                {
                   
                    if (Lists.current[j].id == Lists.previous[i].id)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    //Удаление
                    deleted++;
                    deletedList.Add(Lists.previous[i].id);
                    allInfo.Items.Add(new
                    {
                        id = Lists.previous[i].id,
                        nameOld = Lists.previous[i].name,
                        descriptionOld = Lists.previous[i].description,
                        sourceOld = Lists.previous[i].source,
                        objectiveOld = Lists.previous[i].objective,
                        isPolicyOld = Lists.previous[i].isPolicy,
                        isIntegrityOld = Lists.previous[i].isIntegrity,
                        isAvailAbilityOld = Lists.previous[i].isAvailability
                    });
                }
            }
            string str = "";
            for (int i = 0; i < addedList.Count; i++)
            {
                str += addedList[i] + " ";
            }
            add.Text = "Всего записей добавлено: " + added + ". Список id добавленных записей: " + str ;
            str = "";
            for (int i = 0; i < changedList.Count; i++)
            {
                str += changedList[i] + " ";
            }
            change.Text = "Всего записей изменено: " + changed +  ". Список id изменных записей: " + str;
            str = "";
            for (int i = 0; i < deletedList.Count; i++)
            {
                str += deletedList[i] + " ";
            }
            delete.Text = "Всего записей удалено: " + deleted + ". Список id удаленных записей: " + str;



            allInfo.Items.Refresh();
        }
        private void ReturnHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
