using System.Windows;

namespace ContractClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow(string role)
        {
            InitializeComponent();

            // Set the appropriate tab based on the role
         
            switch (role)
            {
                case "Lecturer":
                    RoleTabs.SelectedIndex = 0;
                    break;
                case "Program Coordinator":
                    RoleTabs.SelectedIndex = 1;
                    break;
                case "Academic Manager":
                    RoleTabs.SelectedIndex = 2;
                    break;
            }
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button will open a file dialog to select a document.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UploadDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button will upload the selected document to the server.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button will submit your claim for review.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RefreshStatusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button will refresh and update the claim status list.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
       
        private void ReviewSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to review the selected claim
            MessageBox.Show("Review Selected button clicked. Open detailed view.");
        }

        private void ApproveSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve the selected claim
            MessageBox.Show("Approve Selected button clicked. The claim will be approved.");
        }

        private void RejectSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to reject the selected claim
            MessageBox.Show("Reject Selected button clicked. The claim will be rejected.");
        }


    }
}
