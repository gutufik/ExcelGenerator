using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Excel.Application();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var users = new ObservableCollection<user>(kepartners_data2Entities.GetContext().user);
            foreach (var user in users)
            {
                if (user.email.Contains('@'))
                {
                    if (user.activity.Count == 0)
                        continue;
                    
                    for (int i = 0; i < user.activity.Count; i++)
                    {
                        application.SheetsInNewWorkbook = user.activity.ToList()[i].category.Count;

                        Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

                        for (int c = 0; c < user.activity.ToList()[i].category.Count; c++)
                        {
                            var category = user.activity.ToList()[i].category.ToList()[c];
                            Excel.Worksheet worksheet = application.Worksheets.Item[c + 1];
                            //Console.WriteLine($"{user.email} {category.title} {item.date} {item.money} {item.comment}");
                            worksheet.Name = $"{category.title}{c}";

                            var rowIndex = 1;

                            for (int j = 0; j < category.registry.Count(); j++)
                            {
                                worksheet.Cells[1][rowIndex] = category.title;
                                worksheet.Cells[2][rowIndex] = category.registry.ToList()[j].date;
                                worksheet.Cells[3][rowIndex] = category.registry.ToList()[j].comment;
                                rowIndex++;
                            }
                            worksheet.Columns.AutoFit();
                            worksheet.Rows.AutoFit();
                        }
                    }
                    application.Visible = true;
                    //application.ActiveWorkbook.SaveAs();
                    application.ActiveWorkbook.SaveAs($"D:\\Users\\gutuf\\Desktop\\excels\\{user.email}.xlsx");
                    application.ActiveWorkbook.Close();
                }
            }
        }
    }
}
