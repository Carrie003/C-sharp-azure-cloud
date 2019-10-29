namespace ServiceManagement
{
    public class AzureSubscription
    {

    }
      public partial class CreateContainerForm : Form
    {
        public string ContainerName { get; set; }

        public CreateContainerForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ContainerName = textBoxContainerName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
