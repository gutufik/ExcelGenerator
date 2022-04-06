using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var users = new ObservableCollection<user>(kepartners_data2Entities.GetContext().user);
            foreach (var user in users)
            {
                if (user.email.Contains('@'))
                {
                    foreach (var activity in user.activity)
                    {
                        foreach (var category in activity.category)
                        {
                            foreach (var item in category.registry)
                            {
                                Console.WriteLine($"{user.email} {category.title} {item.date} {item.money} {item.comment}");
                            }
                        }
                    }
                }
            }
        }
    }
}
