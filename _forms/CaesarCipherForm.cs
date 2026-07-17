using cryptography_toolkit._algorithms;
namespace cryptography_toolkit;

public partial class CaesarForm : Form
{
    public CaesarForm()
    {
        InitializeComponent();
    }

     private void onClickButton_Encrypt(object sender, EventArgs e)
    {
        if (!int.TryParse(textBox_Key.Text, out int key))
        {
            MessageBox.Show("Key must be a number.");
            return;
        }

        textBox_Output.Text = CaesarCipher.Encrypt(textBox_Input.Text, key);
    }

    private void onClickButton_Decrypt(object sender, EventArgs e)
    {
        if (!int.TryParse(textBox_Key.Text, out int key))
        {
            MessageBox.Show("Key must be a number.");
            return;
        }

        textBox_Output.Text = CaesarCipher.Decrypt(textBox_Input.Text, key);
    }

    private void onClickButton_Clear(object sender, EventArgs e)
    {
        textBox_Input.Clear();
        textBox_Key.Clear();
        textBox_Output.Clear();
    }
}