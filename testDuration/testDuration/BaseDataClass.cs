using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace testDuration
{
    public class BaseDataClass : INotifyPropertyChanged
    {
        private bool _maxoff = false;

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public string Unit = "";

        public List<int[]> array = new List<int[]>();

        public virtual int MaxIndex { get; set; }

        public virtual int MinimumIndex { get; set; }

        public virtual int Index { get; set; }

        public BaseDataClass()
        {
        }

        public BaseDataClass(int minind, int maxind)
        {
            MaxIndex = maxind;
            MinimumIndex = minind;
        }

        public BaseDataClass(int minind, int maxind, bool maxoff)
        {
            MaxIndex = maxind;
            MinimumIndex = minind;
            _maxoff = maxoff;
        }

        public virtual int Value
        {
            get
            {
                return Index;
            }
            set
            {
                Index = value;
                DisplayIndex = Index.ToString();
            }
        }

        public virtual void AddValue()
        {
            Index += 1;

            if (Index > MaxIndex)
            {
                if (_maxoff)
                    Index = MinimumIndex;
                else
                    Index = MaxIndex;
                Console.Beep(300, 50);
            }
            else
            {
                Console.Beep(500, 50);
            }
            Value = Index;
            DisplayIndex = Index.ToString();
        }

        public virtual void MinusValue()
        {
            Index -= 1;
            if (Index < MinimumIndex)
            {
                Index = MinimumIndex;
                Console.Beep(300, 50);
            }
            else
            {
                Console.Beep(500, 50);
            }
            Value = Index;
            DisplayIndex = Index.ToString();
        }

        private string _display;

        public virtual string DisplayIndex
        {
            get
            {
                return _display;
            }
            set
            {
                if (value == "0")
                    _display = "OFF";
                else
                    _display = value;
                OnPropertyChanged("DisplayIndex");
            }
        }
    }
}