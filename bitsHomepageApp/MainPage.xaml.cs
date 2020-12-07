using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using bitsEFClasses.Models;
//using bitsHomepageUWP.Models;
using bitsEFClasses.Services;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using System.Net.Http;


namespace bitsHomepageApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Supplier selected = null;
        private HttpDataService service;

        public Supplier Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        public Visibility IsVisible => LoggedIn ? Visibility.Collapsed : Visibility.Visible;

        public Visibility IsNotVisible => !LoggedIn ? Visibility.Collapsed : Visibility.Visible;

        public bool LoggedIn = false;

        public bool isLoggedIn = false;

        /* -----With some modifications, this code should let me get the supplier table from the bits database to display on the suppliers list page after logging in
        string M_str_sqlcon = "server=localhost;user id=root;password=YOURPASSWORDHERE;database=bits";
        MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
        MySqlCommand mysqlcom = new MySqlCommand("select * from table1", mysqlcon);
        mysqlcon.Open();
        MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
        while (mysqlread.Read())
                 {
                Debug.WriteLine(mysqlread.GetString(0)+":"+mysqlread.GetString(1));
                     }
                mysqlcon.Close();
        */

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            service = new HttpDataService("http://localhost:5000/api");
            List<Supplier> suppliers = await service.GetAsync<List<Supplier>>("supplier");
            foreach (Supplier s in suppliers)
                this.Suppliers.Add(s);
        }


    }
}

