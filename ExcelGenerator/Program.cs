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
            var users = new ObservableCollection<user>(kepartners_data2Entities.GetContext().user);
            foreach (var user in users)
            {
                foreach (var item in user.activity)
                {
                    Console.WriteLine($"{user.email} {item.title}");
                }
            }
        }
    }
}
