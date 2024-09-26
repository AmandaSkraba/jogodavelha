namespace jogodavelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(vez == "X") {
                btn.Text = "X";
                vez = "O";

            } else {
                btn.Text = "O";
                vez = "X";
            }

            /*Verificando se x ganhou na primeira linha*/

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") {
                DisplayAlert("Parabéns!", "O X ganhou", "OK");
            }
        }
    }

}
