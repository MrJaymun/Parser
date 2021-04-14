using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Parser
{
    public class Lists
    {
        public static List<ThreatUnit> current = new List<ThreatUnit>();
        public static List<ThreatUnit> previous = new List<ThreatUnit>();

        public const string fileInfo = "prod.xlsx";

        public static void ReplaceToPrevious()
        {
            previous.Clear();
            foreach (var item in current)
            {
                previous.Add(item);
            }
        }

        public static void DownloadFile()
        {
            if (File.Exists(fileInfo))
            {
                File.Delete(fileInfo);
            }

            WebClient wc = new WebClient();
            wc.DownloadFile(new Uri("https://bdu.fstec.ru/files/documents/thrlist.xlsx"), fileInfo);
            while (wc.IsBusy) { }
        }

        public static void FullCurrentList()
        {

            current.Clear();
            IWorkbook workbook = null;
            FileStream fs = new FileStream(fileInfo, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(fs);
            ISheet sheet = workbook.GetSheetAt(0);


            int rowcount = sheet.LastRowNum;

            for (int i = 2; i <= rowcount; i++)
            {
                IRow curRow = sheet.GetRow(i);

                var cellValue0 = curRow.GetCell(0).NumericCellValue;
                string cellValue1 = curRow.GetCell(1).StringCellValue.Trim();
                string cellValue2 = curRow.GetCell(2).StringCellValue.Trim();
                string cellValue3 = curRow.GetCell(3).StringCellValue.Trim();
                string cellValue4 = curRow.GetCell(4).StringCellValue.Trim();
                var cellValue5 = curRow.GetCell(5).NumericCellValue;
                var cellValue6 = curRow.GetCell(6).NumericCellValue;
                var cellValue7 = curRow.GetCell(7).NumericCellValue;
                bool isPolicy;
                bool isIntegrity;
                bool isAvailability;
                if (cellValue5 == 1)
                {
                    isPolicy = true;
                }
                else
                {
                    isPolicy = false;
                }
                if (cellValue6 == 1)
                {
                    isIntegrity = true;
                }
                else
                {
                    isIntegrity = false;
                }
                if (cellValue5 == 1)
                {
                    isAvailability = true;
                }
                else
                {
                    isAvailability = false;
                }

                current.Add(new ThreatUnit(Convert.ToInt32(cellValue0), cellValue1, cellValue2, cellValue3, cellValue4, isPolicy, isIntegrity, isAvailability));
            }


        }

        public static bool CompareItems(ThreatUnit a, ThreatUnit b)
        {
            bool result = true;
            if (a.id != b.id) { result = false; }
            if (a.name != b.name) { result = false; }
            if (a.description != b.description) { result = false; }
            if (a.source != b.source) { result = false; }
            if (a.objective != b.objective) { result = false; }
            if (a.isPolicy != b.isPolicy) { result = false; }
            if (a.isIntegrity != b.isIntegrity) { result = false; }
            if (a.isAvailability != b.isAvailability) { result = false; }
            return result;

        }

        public static void ChooseFileDialog()
        {
            Stream myStream;
           
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
           

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter writer = new StreamWriter(myStream, Encoding.UTF8);
                    writer.WriteLine("id угрозы;Название угрозы;Описание угрозы;Источник угрозы;Объект взаимодействия;Нарушение конфиденциальности;Нарушение целостности;Нарушение доступности");

                    foreach (ThreatUnit item in current)
                    {

                        string a = Validation(item.id.ToString()) + ";" + Validation(item.name) + ";" + Validation(item.description) + ";" + Validation(item.source) + ";" + Validation(item.objective) + ";"
                            + Validation(item.isPolicy.ToString()) + ";" + Validation(item.isIntegrity.ToString()) + ";" + Validation(item.isAvailability.ToString());
                       
                        writer.WriteLine(a);
                    }
                    writer.Close();
                    myStream.Close();
                }
            }
            
        }

        public static string Validation(string s)
        {
            string result = "";
            char[] add = s.ToCharArray();
            for (int i = 0; i < add.Length; i++)
            {
                if (Char.IsLetterOrDigit(add[i]) || add[i] == ';' || add[i] == ' ')
                {
                    if(add[i] == ';')
                    {
                        result +=',';
                    }
                    else
                    {
                        result += add[i];
                    }
                   
                }
            }
            return result;

        }
    }

   
}

