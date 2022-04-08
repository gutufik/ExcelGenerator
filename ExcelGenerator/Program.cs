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

            int count = 0;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var users = new ObservableCollection<user>(kepartners_data2Entities.GetContext().user);
            foreach (var user in users)
            {
                if (user.email.Contains('@'))
                {
                    if (user.activity.Count == 0)
                        continue;
                    var rowIndex = 2;
                    application.SheetsInNewWorkbook = 1;

                    Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

                    Excel.Worksheet worksheet = application.Worksheets.Item[1];
                    worksheet.Name = $"Sheet 1";
                    for (int i = 0; i < user.activity.Count; i++)
                    {
                        for (int c = 0; c < user.activity.ToList()[i].category.Count; c++)
                        {
                            var category = user.activity.ToList()[i].category.ToList()[c];

                            worksheet.Cells[1][1] = "Категория";
                            worksheet.Cells[2][1] = "Дата";
                            worksheet.Cells[3][1] = "Комментарий";
                            worksheet.Cells[4][1] = "Сумма";
                            worksheet.Cells[5][1] = "Тип";

                            for (int j = 0; j < category.registry.Count(); j++)
                            {
                                worksheet.Cells[1][rowIndex] = category.title;
                                worksheet.Cells[2][rowIndex] = category.registry.ToList()[j].date;
                                worksheet.Cells[3][rowIndex] = category.registry.ToList()[j].comment;
                                worksheet.Cells[4][rowIndex] = category.registry.ToList()[j].money;
                                worksheet.Cells[5][rowIndex] = Convert.ToBoolean(category.is_income) ? "Доход": "Расход";
                                rowIndex++;
                            }
                            worksheet.Columns.AutoFit();
                            worksheet.Rows.AutoFit();
                        }
                        
                    }
                    count += (rowIndex - 2);
                    application.Visible = false;
                    //application.ActiveWorkbook.SaveAs();
                    application.ActiveWorkbook.SaveAs($"D:\\Users\\gutuf\\Desktop\\excels\\{user.email}.xlsx");
                    application.ActiveWorkbook.Close();
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
