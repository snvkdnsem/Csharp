using System.ComponentModel;

namespace LoginWindow.Model
{

    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _fisrtname;
        public string FirstName
        {
            get
            {
                return _fisrtname;
            }
            set
            {
                _fisrtname = value;
                RaisePropertyChange("FirstName");
            }
        }
        private string _lastname;

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                RaisePropertyChange("LastName");
            }
        }
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}