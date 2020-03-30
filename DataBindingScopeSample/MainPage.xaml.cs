using System.ComponentModel;
using Xamarin.Forms;

namespace DataBindingScopeSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        void ListOfPeople_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string person = "", message = "";

            switch (e.SelectedItem)
            {
                case ListModel m when m.Title.StartsWith("Jake"):
                    person = "Jake";
                    message = "Noice! Toit!";
                    break;
                case ListModel m when m.Title.StartsWith("Amy"):
                    person = "Amy";
                    message = "Oh my God, she's totally gonna flunk us. I haven't gotten an F since I failed recess in second grade. \"Teachers need a break too, Amy\".";
                    break;
                case ListModel m when m.Title.StartsWith("Rosa"):
                    person = "Rosa";
                    message = "So, what is this? Casual, serious? I need to know how to make fun of you.";
                    break;
                case ListModel m when m.Title.StartsWith("Ray"):
                    person = "Ray";
                    message = "Fun? I was never fun. You take that back.";
                    break;
                case ListModel m when m.Title.StartsWith("Charles"):
                    person = "Charles";
                    message = "If I was a unicorn, I'd never be angry.";
                    break;
                case ListModel m when m.Title.StartsWith("Terry"):
                    person = "Terry";
                    message = "Terry Loves Yogurt";
                    break;
            }

            DisplayAlert($"{person} says", message, "Cool beans!");
        }
    }
}