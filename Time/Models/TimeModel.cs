using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Time.Models
{
     public class TimeModel : BindableBase
    {
        private string _timeMessage;
        public string TimeMessage
        {
            get { return _timeMessage; }
            set { SetProperty(ref _timeMessage, value); }
        }
        //public ISynchronizeInvoke SynchronizingObject { get; set; }
    }
}
