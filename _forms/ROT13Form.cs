using cryptography_toolkit._algorithms;
namespace cryptography_toolkit;

public partial class ROT13Form : Form
{
    public ROT13Form()
    {
        InitializeComponent();
    }

     private void onClickButton_Transform(object? sender, EventArgs e)
    {
        if (!int.TryParse(textBox_Key.Text, out int key))
        {
            MessageBox.Show("Key must be a number.");
            return;
        }

        textBox_Output.Text = ROT13.Transform(textBox_Input.Text, key);
    }

    private void onClickButton_Clear(object sender, EventArgs e)
    {
        textBox_Input.Clear();
        textBox_Output.Clear();
    }
}