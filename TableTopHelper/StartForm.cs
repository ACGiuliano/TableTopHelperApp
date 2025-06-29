namespace TableTopHelper;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Opens up the MainMenuForm when the start button is clicked
    private void startButton_Click(object sender, EventArgs e)
    {
        MainMenuForm mainMenuForm = new MainMenuForm();
        mainMenuForm.Show();
        this.Hide();
    }
}