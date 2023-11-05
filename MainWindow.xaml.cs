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

namespace GA_Hafsa_ListAndComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare 5 first names
        List<string> firstNames = new List<string> { "John", "Jane", "Doe", "Mary", "Bob" };

        //delare 5 last names
        List<string> lastNames = new List<string> { "Smith", "Doe", "Johnson", "Taylor", "Brown" };

        public MainWindow()
        {
            InitializeComponent();

            //aassign the list to the combo list
            cmbFirstName.ItemsSource = firstNames;

            //assign the new list to the list box
            lbLastNames.ItemsSource = lastNames;


        } //mainwindow

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            //getting selected index from combo box
            int firstNameIndex = cmbFirstName.SelectedIndex;

            //getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            //using the index to get the first name from the list
            string firstName = firstNames[firstNameIndex];

            //using the index to get the last name from the list
            string lastName = lastNames[lastNameIndex];

            //concatenating a full name
            string fullName = firstName + " " + lastName;

            //display full name with messagebox
            MessageBox.Show(fullName);

        } //btnDisplayFullName_Click

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            //users first name input
            string firstName = txtFirstName.Text;

            //users last name input
            string lastName = txtLastName.Text;

            //adding first name to first name list
            firstNames.Add(firstName);

            //adding last name to the last name list
            lastNames.Add(lastName);

            //refresh each of the boxes to show the newly added names to the list
            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();

        } //btnAddNames_Click

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            //getting selected index from combo box
            int firstNameIndex = cmbFirstName.SelectedIndex;

            //getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            //remove first name
            firstNames.RemoveAt(firstNameIndex);

            //remove last name
            lastNames.RemoveAt(lastNameIndex);

            //refresh each if the boces to show the newly added names to the list
            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();

        } //btnRemoveStudentAtIndex_CLick

        private void lbLastNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
        } //selction chsnged event


    } //class


} //namespace
