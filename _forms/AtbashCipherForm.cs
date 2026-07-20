using cryptography_toolkit._algorithms;
namespace cryptography_toolkit;

public partial class AtbashCipherForm : Form
{
    public AtbashCipherForm()
    {
        InitializeComponent();
    }

     private void onClickButton_Transform(object? sender, EventArgs e)
    {
        textBox_Output.Text = AtbashCipher.Transform(textBox_Input.Text);
    }

    private void onClickButton_Clear(object sender, EventArgs e)
    {
        textBox_Input.Clear();
        textBox_Output.Clear();
    }
}