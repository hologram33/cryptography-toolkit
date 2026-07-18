namespace cryptography_toolkit;

partial class ROT13Form
{
    private System.ComponentModel.IContainer components = null;

    private Label label_Input;
    private Label label_Key;
    private Label label_Output;

    private TextBox textBox_Input;
    private TextBox textBox_Key;
    private TextBox textBox_Output;

    private Button button_Transform;

    private Button button_Clear;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        label_Input = new Label();
        label_Key = new Label();
        label_Output = new Label();

        textBox_Input = new TextBox();
        textBox_Key = new TextBox();
        textBox_Output = new TextBox();

        button_Transform = new Button();
        button_Clear = new Button();

        SuspendLayout();

        // label_Input
        label_Input.AutoSize = true;
        label_Input.Location = new Point(30,20);
        label_Input.Text = "Input";

        // textBox_Input
        textBox_Input.Location = new Point(30,45);
        textBox_Input.Size = new Size(500,100);
        textBox_Input.Multiline = true;

        // label_Key
        label_Key.AutoSize = true;
        label_Key.Location = new Point(30,165);
        label_Key.Text = "Key";

        // textBox_Key
        textBox_Key.Location = new Point(30,190);
        textBox_Key.Size = new Size(100,27);
        textBox_Key.Text = "13";
        textBox_Key.ReadOnly = true;

        // label_Output
        label_Output.AutoSize = true;
        label_Output.Location = new Point(30,240);
        label_Output.Text = "Output";

        // textBox_Output
        textBox_Output.Location = new Point(30,265);
        textBox_Output.Size = new Size(500,100);
        textBox_Output.Multiline = true;
        textBox_Output.ReadOnly = true;

        // button_Transform
        button_Transform.Location = new Point(30,390);
        button_Transform.Size = new Size(120,40);
        button_Transform.Text = "Transform";
        button_Transform.Click += onClickButton_Transform;

        // button_Clear
        button_Clear.Location = new Point(310,390);
        button_Clear.Size = new Size(120,40);
        button_Clear.Text = "Clear";
        button_Clear.Click += onClickButton_Clear;

        // Form
        AutoScaleDimensions = new SizeF(7F,15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(580,470);

        Controls.Add(label_Input);
        Controls.Add(textBox_Input);

        Controls.Add(label_Key);
        Controls.Add(textBox_Key);

        Controls.Add(label_Output);
        Controls.Add(textBox_Output);

        Controls.Add(button_Transform);
        Controls.Add(button_Clear);

        Name = "ROT13Form";
        Text = "ROT13 Cipher";

        ResumeLayout(false);
        PerformLayout();
    }
}