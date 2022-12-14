using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
using System.Xml;

namespace practik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sqlExpression = "";
        string connectionString = "";
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        private DataTable table = null;
        SqlCommand command = new SqlCommand();
        public MainWindow()
        {
            InitializeComponent();
            //string connectionString = @"Data Source=DESKTOP-4DQ06PD\SQLEXPRESS;Initial Catalog=pract;Integrated Security=True";
            //string sqlExpression = "SELECT category INTO category FROM product";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    int number = command.ExecuteNonQuery();
            //    Console.WriteLine("Добавлено таблиц: {0}", number);
            //}
            //Console.Read();
            //string sqlExpressions = "ALTER TABLE product DROP COLUMN category";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpressions, connection);
            //    int number = command.ExecuteNonQuery();
            //    Console.WriteLine("Удалено объектов: {0}", number);
            //}
            //Console.Read();
            //string sqlExpression2 = "ALTER TABLE category ADD CatId INT PRIMARY KEY IDENTITY ";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression2, connection);
            //    int number = command.ExecuteNonQuery();
            //    Console.WriteLine("Добавлено объектов: {0}", number);
            //}
            //Console.Read();

            //string sqlExpression3 = "ALTER TABLE category ADD FOREIGN KEY  (CatId) REFERENCES product(sku)";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression3, connection);
            //    int number = command.ExecuteNonQuery();
            //    Console.WriteLine("Добавлено объектов: {0}", number);
            //}
            Console.Read();
            //чтение из файла
            //    string path = @"C:\Users\alina\Desktop\programms\УП 0.4\practik\connectionString.txt";
            //    var imput = File.ReadAllLines(path);
            //    foreach (string line in imput)
            //    {
            //        var l = line.Split('=');
            //        if (!string.IsNullOrWhiteSpace(l[1]))
            //        {
            //           connectionString +=  $"{line};";

            //        }
            //    };
            //    string pathS = @"C:\Users\alina\Desktop\programms\УП 0.4\practik\Command.txt";
            //    var imputS = File.ReadAllLines(pathS);
            //    foreach (string lineS in imputS)
            //    {
            //        var ls = lineS.Split(' ');
            //        if (!string.IsNullOrWhiteSpace(ls[1]))
            //        {
            //            sqlExpression = $"{lineS};";
            //            SqlConnection connection = new SqlConnection(connectionString);
            //            connection.Open();
            //            SqlCommand command = new SqlCommand(sqlExpression, connection);
            //            command.CommandType = CommandType.Text;
            //            int number = command.ExecuteNonQuery();
            //        }
            //    };
        }

        private void pick_Click(object sender, RoutedEventArgs e)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(@"https://github.com/ZaraZ04ka/pract01.04/blob/main/upd11xml");
            var a = xml.Name.ToString();
            }
        }
    }
