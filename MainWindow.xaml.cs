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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AAAJurnalDBEntities2 _DB;
        public MainWindow()
        {
            InitializeComponent();
            _DB= new AAAJurnalDBEntities2();
        }

        public void ShowTablesAndUpdate()
        {
            if (comBObox.SelectedIndex == 0)
            {
                MainGrid.ItemsSource = _DB.Jurnal.ToList();
                MainGrid.Columns[4].Visibility = Visibility.Hidden;
                MainGrid.Columns[5].Visibility = Visibility.Hidden;
                MainGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 1)
            {
                MainGrid.ItemsSource = _DB.Student.ToList();
                MainGrid.Columns[4].Visibility = Visibility.Hidden;
                MainGrid.Columns[5].Visibility = Visibility.Hidden;
                MainGrid.Columns[6].Visibility = Visibility.Hidden;
                MainGrid.Columns[7].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 2)
            {
                MainGrid.ItemsSource = _DB.Predmet.ToList();
                MainGrid.Columns[2].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 3)
            {
                MainGrid.ItemsSource = _DB.Assessment.ToList();
                MainGrid.Columns[2].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 4)
            {
                MainGrid.ItemsSource = _DB.StudentGroup.ToList();
                MainGrid.Columns[2].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 5)
            {
                MainGrid.ItemsSource = _DB.People.ToList();
                MainGrid.Columns[4].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 6)
            {
                MainGrid.ItemsSource = _DB.Cours.ToList();
                MainGrid.Columns[2].Visibility = Visibility.Hidden;
            }
        }
        public void ShowTables()
        {
            if (comBObox.SelectedIndex == 0)
            {
                MainGrid.Columns[4].Visibility = Visibility.Hidden;
                MainGrid.Columns[5].Visibility = Visibility.Hidden;
                MainGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 1)
            {
                MainGrid.Columns[4].Visibility = Visibility.Hidden;
                MainGrid.Columns[5].Visibility = Visibility.Hidden;
                MainGrid.Columns[6].Visibility = Visibility.Hidden;
                MainGrid.Columns[7].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 2)
            {
                MainGrid.Columns[2].Visibility = Visibility.Hidden;
            }
            if (comBObox.SelectedIndex == 3)
            {
                MainGrid.Columns[2].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 4)
            {
                MainGrid.Columns[2].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 5)
            {
                MainGrid.Columns[4].Visibility = Visibility.Hidden;

            }
            if (comBObox.SelectedIndex == 6)
            {
                MainGrid.Columns[2].Visibility = Visibility.Hidden;
            }
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputtext = TextLookFor.Text.ToLower();

            if (comBObox.SelectedIndex == 0 && TextLookFor.Text != "")
            {
                List<Jurnal> listJ = _DB.Jurnal.ToList();
                var jurnal = listJ.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.Student.ToString().ToLower().Contains(inputtext) ||
                l.Predmet.ToString().ToLower().Contains(inputtext) ||
                l.Assessment.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = jurnal.ToList();
            }
            else if (comBObox.SelectedIndex == 0 && TextLookFor.Text == "") {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 1)
            {
                List<Student> listS = _DB.Student.ToList();
                var student = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.People.ToString().ToLower().Contains(inputtext) ||
                l.TitleGroup.ToString().ToLower().Contains(inputtext) ||
                l.Cours.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = student.ToList();
            }
            else if (comBObox.SelectedIndex == 1 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 2)
            {
                List<Predmet> listS = _DB.Predmet.ToList();
                var predmet = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.Title.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = predmet.ToList();

            }
            else if (comBObox.SelectedIndex == 2 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 3)
            {
                List<Assessment> listS = _DB.Assessment.ToList();
                var ass = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.Assessment1.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = ass.ToList();

            }
            else if (comBObox.SelectedIndex == 3 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 4)
            {
                List<StudentGroup> listS = _DB.StudentGroup.ToList();
                var group = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.Title.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = group.ToList();

            }
            else if (comBObox.SelectedIndex == 4 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 5)
            {
                List<People> listS = _DB.People.ToList();
                var people = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.Surname.ToString().ToLower().Contains(inputtext) ||
                l.FirsnName.ToString().ToLower().Contains(inputtext) ||
                l.MidName.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = people.ToList();

            }
            else if (comBObox.SelectedIndex == 5 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }

            if (comBObox.SelectedIndex == 6)
            {
                List<Cours> listS = _DB.Cours.ToList();
                var cours = listS.Where(
                l => l.ID.ToString().ToLower().Contains(inputtext) ||
                l.NUMBER.ToString().ToLower().Contains(inputtext));
                MainGrid.ItemsSource = cours.ToList();


            }
            else if (comBObox.SelectedIndex == 6 && TextLookFor.Text == "")
            {
                ShowTablesAndUpdate();
            }
            ShowTables();

        }
        private void b_ADD_Click(object sender, RoutedEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {
                Jurnal jurnal = new Jurnal();
                jurnal.Student = null;
                jurnal.Predmet = null;
                jurnal.Assessment = null;
                _DB.Jurnal.Add(jurnal);
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comBObox.SelectedIndex == 1)
            {
                Student student = new Student();
                student.People = null;
                student.TitleGroup = null;
                student.Cours = null;
                _DB.Student.Add(student);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 2)
            {
                Predmet predmet = new Predmet();
                predmet.Title = null;
                _DB.Predmet.Add(predmet);
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comBObox.SelectedIndex == 3)
            {
                Assessment ass = new Assessment();
                ass.Assessment1 = null;
                _DB.Assessment.Add(ass);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 4)
            {
                StudentGroup group = new StudentGroup();
                group.Title = null;
                _DB.StudentGroup.Add(group);
                _DB.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comBObox.SelectedIndex == 5)
            {
                People peopl = new People();
                peopl.Surname = "";
                peopl.FirsnName = "";
                peopl.MidName = "";
                _DB.People.Add(peopl);
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comBObox.SelectedIndex == 6)
            {
                Cours cours = new Cours();
                cours.NUMBER = null;
                _DB.Cours.Add(cours);
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
        }
        private void b_REMOVE_Click(object sender, RoutedEventArgs e)
        {
            if(comBObox.SelectedIndex == 0 )
            {
                Jurnal jurnal = MainGrid.SelectedItem as Jurnal;
                _DB.Jurnal.Remove(jurnal);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Jurnal.ToList();
                ShowTables();
            }
            if (comBObox.SelectedIndex == 1)
            {
                Student student = MainGrid.SelectedItem as Student;
                _DB.Student.Remove(student);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Student.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 2)
            {
                Predmet predmet = MainGrid.SelectedItem as Predmet;
                _DB.Predmet.Remove(predmet);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Predmet.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 3)
            {
                Assessment ass = MainGrid.SelectedItem as Assessment;
                _DB.Assessment.Remove(ass);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Assessment.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 4)
            {
                StudentGroup group = MainGrid.SelectedItem as StudentGroup;
                _DB.StudentGroup.Remove(group);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.StudentGroup.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 5)
            {
                People people = MainGrid.SelectedItem as People;
                _DB.People.Remove(people);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.People.ToList();
                ShowTables();

            }
            if (comBObox.SelectedIndex == 6)
            {
                Cours cours = MainGrid.SelectedItem as Cours;
                _DB.Cours.Remove(cours);
                _DB.SaveChanges();
                MainGrid.ItemsSource = _DB.Cours.ToList();
                ShowTables();

            }
        }
        private void b_Update_Click(object sender, RoutedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void b_SAVE_Click(object sender, RoutedEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {
                _DB.SaveChanges();
                ShowTablesAndUpdate();
            }
        }


        private void MainGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (comBObox.SelectedIndex == 0)
            {
                
                

            }

        }
    }
}
