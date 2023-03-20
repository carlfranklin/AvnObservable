using AvnObservable;
namespace WindowsFormsDemo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listBox1 = new ListBox();
        nameTextBox = new TextBox();
        emailTextBox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(12, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(345, 284);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(379, 54);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(245, 27);
        nameTextBox.TabIndex = 1;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new Point(379, 121);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(245, 27);
        emailTextBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(377, 31);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 3;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(380, 98);
        label2.Name = "label2";
        label2.Size = new Size(49, 20);
        label2.TabIndex = 4;
        label2.Text = "Email:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(emailTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(listBox1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBox1;
    private TextBox nameTextBox;
    private TextBox emailTextBox;
    private Label label1;
    private Label label2;
}