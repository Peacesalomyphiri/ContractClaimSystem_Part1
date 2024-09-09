using System.Windows;
using System.Windows.Controls;

namespace ContractClaimSystem
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the username, password, and selected role
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Check that all fields are filled
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(role))
            {
                // Open the main window with the appropriate role
                MainWindow mainWindow = new MainWindow(role);
                mainWindow.Show(); // Show the main window
                this.Close();      // Close the login window
            }
            else
            {
                MessageBox.Show("Please enter your username, password, and select a role.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
