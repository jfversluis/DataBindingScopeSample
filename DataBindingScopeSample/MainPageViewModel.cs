using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DataBindingScopeSample
{
    public class MainPageViewModel
    {
        public ObservableCollection<ListModel> MyItems { get; set; } = new ObservableCollection<ListModel>
        {
            // Images from https://brooklyn99.fandom.com/wiki
            new ListModel
            {
                Title = "Jake Peralta", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/8/88/S7_Andy_Samberg_-_Jake_Peralta.png/revision/latest/scale-to-width-down/700?cb=20200312165943"
            },
            new ListModel
            {
                Title = "Amy Santiago", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/7/78/S7_Melissa_Fumero_-_Amy_Santiago.png/revision/latest/scale-to-width-down/700?cb=20200312162615"
            },
            new ListModel
            {
                Title = "Rosa Diaz", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/d/db/S7_Stephanie_Beatriz_-_Rosa_Diaz.png/revision/latest/scale-to-width-down/700?cb=20200312163101"
            },
            new ListModel
            {
                Title = "Ray Holt", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/8/86/S7_Andre_Braugher_-_Raymond_Holt.png/revision/latest/scale-to-width-down/700?cb=20200312162634"
            },
            new ListModel
            {
                Title = "Charles Boyle", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/f/f3/S7_Joe_Lo_Truglio_-_Charles_Boyle.png/revision/latest/scale-to-width-down/700?cb=20200312162831"
            },
            new ListModel
            {
                Title = "Terry Jeffords", Image = "https://vignette.wikia.nocookie.net/brooklynnine-nine/images/1/16/S7_Terry_Crews_-_Terry_Jeffords.png/revision/latest/scale-to-width-down/700?cb=20200312163116"
            }
        };

        public Command<ListModel> DeleteCommand { get; private set; }

        public MainPageViewModel()
        {
            DeleteCommand = new Command<ListModel>(model =>
            {
                MyItems.Remove(model);
            });
        }
    }
}