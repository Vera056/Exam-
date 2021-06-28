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
            ExamIsrpoEntities db = new ExamIsrpoEntities();
            vid.ItemsSource = db.View.ToList();
        }

        private void AddRecords(object sender, RoutedEventArgs e)
        {
            int comb = (vid.SelectedItem as View).IdView;
            Insert insert = new Insert();
            insert.Add(numb.Text,comb,sum.Text);
        }
        
    }
}
