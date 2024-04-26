namespace sales
{
    public partial class MainPage : ContentPage
    {
        string gender;
        string si_1, si_2, si_3, si_4;
       
        List<SalesClass> salesLise = new List<SalesClass>();

       

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void add_Clicked(object sender, EventArgs e)
        {
            if (male.IsChecked)
                gender = "male";
            else if (female.IsChecked)
                gender = "female";
            if (fisher.IsChecked)
                si_1 = "Fishing";
            if (homee.IsChecked)
            {
                si_2 = "Staying at home";
            }
                
            if (paint.IsChecked)
                si_3 = "Painting";
            if (football.IsChecked)
                si_4 = "Football";
            int tel;
            int.TryParse(Tel.Text, out tel);
            salesLise.Add(new SalesClass(Name.Text, lastName.Text, tel, gender, si_1, si_2, si_3, si_4));
        }

        private void show_Clicked(object sender, EventArgs e)
        {
            salesListXaml.ItemsSource = null;
            salesListXaml.ItemsSource = salesLise;
        }
        private async void salesListXaml_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var sales = e.Item as SalesClass;
            int tel;
            int.TryParse(Tel.Text, out tel);
            await DisplayAlert("Selected person","Name: " + Name.Text + "\n" + "Last Name: " + lastName.Text + "\n" + "Number: " + tel, "OK");
        }
    }

}
