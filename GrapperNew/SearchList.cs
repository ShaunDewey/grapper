using System.Windows.Forms;

namespace GrapperNew
{
    class SearchList
    {
        public TextBox Location;

        public SearchList(TextBox location)
        {
            Location = location;
        }

        public string[] GetSearchStrings()
        {
            return Location.Text.Split();
        }
    }
}
