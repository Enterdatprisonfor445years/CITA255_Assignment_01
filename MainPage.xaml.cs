namespace PracticeSetup;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        
        if (decimal.TryParse(BillEntry.Text, out decimal bill))
        {
            
            decimal tip = bill * 0.20m;
            decimal total = bill + tip;

           
            TipResultLabel.Text = $"Tip: {tip:C}";
            TotalResultLabel.Text = $"Total: {total:C}";
        }
        else
        {
            
            TipResultLabel.Text = "Enter a number!";
            TotalResultLabel.Text = "";
        }
    }
}
