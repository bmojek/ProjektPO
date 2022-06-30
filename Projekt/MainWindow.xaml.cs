using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> MyStudents { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ProjektDataContext db = new ProjektDataContext();

            var stu = from d in db.Students
                      select new
                      {
                          Uczeń = d.Names,
                      };

            data1.ItemsSource = stu.ToList();
        }
    }
}