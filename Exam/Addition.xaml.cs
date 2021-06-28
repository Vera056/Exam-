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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Addition.xaml
    /// </summary>
    public partial class Addition : Window
    {
        public Addition()
        {
            InitializeComponent();
            Database1Entities db = new Database1Entities();
            vid.ItemsSource = db.Views.ToList();
        }

        private void AddRecords(object sender, RoutedEventArgs e)
        {
            Insert insert = new Insert();
            insert.Add();
        }
    }
}
