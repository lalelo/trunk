using System.ComponentModel;

namespace testDuration
{
    public class TimerClass : INotifyPropertyChanged
    {
        private int _value = 0;
        private string _minute = "00";
        private string _second = "00";
        private string _all;

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }//end OnPropertyChanged

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                //Display = value.ToString();
                Minute = (value / 60).ToString("00");
                Second = (value % 60).ToString("00");
                DisplayAll = Minute + " m " + Second + " s ";
            }
        }

        public string Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                _minute = value;
                OnPropertyChanged("Minute");
            }
        }

        public string Second
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
                OnPropertyChanged("Second");
            }
        }

        public string DisplayAll
        {
            get
            {
                return _all;
            }
            set
            {
                _all = value;
                OnPropertyChanged("DisplayAll");
            }
        }
    }
}