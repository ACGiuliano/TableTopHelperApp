namespace TableTopHelper;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        startLabel = new Label();
        startButton = new Button();
        startPictureBox = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)startPictureBox).BeginInit();
        SuspendLayout();
        // 
        // startLabel
        // 
        startLabel.Font = new Font("Josefin Sans", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        startLabel.Location = new Point(-11, 43);
        startLabel.Margin = new Padding(6, 0, 6, 0);
        startLabel.Name = "startLabel";
        startLabel.Size = new Size(1028, 145);
        startLabel.TabIndex = 0;
        startLabel.Text = "Welcome to TableTop Helper!";
        startLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // startButton
        // 
        startButton.Location = new Point(373, 708);
        startButton.Margin = new Padding(6, 7, 6, 7);
        startButton.Name = "startButton";
        startButton.Size = new Size(265, 69);
        startButton.TabIndex = 1;
        startButton.Text = "Start";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButton_Click;
        // 
        // startPictureBox
        // 
        startPictureBox.Image = (Image)resources.GetObject("startPictureBox.Image");
        startPictureBox.Location = new Point(248, 167);
        startPictureBox.Margin = new Padding(6, 7, 6, 7);
        startPictureBox.Name = "startPictureBox";
        startPictureBox.Size = new Size(512, 512);
        startPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        startPictureBox.TabIndex = 2;
        startPictureBox.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(1006, 886);
        Controls.Add(startPictureBox);
        Controls.Add(startButton);
        Controls.Add(startLabel);
        Font = new Font("Josefin Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(6, 7, 6, 7);
        Name = "Form1";
        Text = "TableTop Helper";
        ((System.ComponentModel.ISupportInitialize)startPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.PictureBox startPictureBox;

    private System.Windows.Forms.Label startLabel;

    #endregion
}