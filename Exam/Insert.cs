using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows;

namespace Exam
{
    public class Insert
    {
        public bool Add(string numb,int comb,string sum)
        {
            try
            {
                ExamIsrpoEntities db = new ExamIsrpoEntities();
                CashBox cashBox = new CashBox();
                cashBox.Number = numb.Trim();
                cashBox.IdView = comb;
                cashBox.Money = Convert.ToInt32(sum.Trim());
                db.CashBox.Add(cashBox);
                db.SaveChanges();
                MessageBox.Show("Хорошо!\nЗапись добавлена", "My App", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
