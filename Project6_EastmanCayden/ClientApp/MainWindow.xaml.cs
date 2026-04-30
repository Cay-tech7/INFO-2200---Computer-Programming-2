using System.Windows;
using System.Windows.Input;

namespace ClientApp
{
    public partial class MainWindow : Window
    {
        private SynchronousSocketClient client = new SynchronousSocketClient();

        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Whenever the user presses "enter" send out a client request to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxClientRequest_KeyDown(object sender, KeyEventArgs e)
        {
            //check if the enter key is pressed
            if (e.Key == Key.Enter)
            {
                //Contact the server
                TextBoxServerResponse.Text += client.ContactServer(TextBoxClientRequest.Text.Trim()) + "\n";
            }
        }

        /// <summary>
        /// Whever the user presses the send request button, retreive a response from the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSendClientRequest_Click(object sender, RoutedEventArgs e)
        {
            //Contact the server
            TextBoxServerResponse.Text += client.ContactServer(TextBoxClientRequest.Text.Trim()) + "\n";
        }
    }
}

