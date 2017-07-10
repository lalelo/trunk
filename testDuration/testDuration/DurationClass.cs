using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDuration
{
    public class DurationSettings : BaseDataClass
    {
        public TimerClass timer = new TimerClass();
        public override int Value
        {
            get
            {
                return base.Value;
            }

            set
            {
                base.Value = value;
                timer.Value = value;
                //Display = "";
            }
        }
        public string Display
        {
            get
            {
                return timer.DisplayAll;
            }

            set
            {
                OnPropertyChanged("Display");
            }
        }
    }
}
