using Codeplex.Reactive.Extensions;
using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Models;

namespace Time.ViewModels
{
    public class ViewAViewModel // : BindableBase
    {
        private TimeModel timeModel;
        public String timeMessage { get; }

        public ViewAViewModel()
        {
            //    timeModel = new TimeModel();
            //timeMessage = timeModel.ToReactivePropertyAsSynchronized(
            //    t => t.TimeMessage);
        }

        //private string _message;
        //public string Message
        //{
        //    get { return _message; }
        //    set { SetProperty(ref _message, value); }
        //}

        //ReactiveProperty<TimeModule> TimeMessage { get; set; }
        
        ///*
        //private string _timeMessage;
        //public string TimeMessage
        //{
        //    get { return _timeMessage; }
        //    set { SetProperty(ref _timeMessage, value); }
        //}
        //*/
        //public ViewAViewModel()
        //{
        //    Message = "View A from your Prism Module";
        //    TimeMessage = "";
        //}

    }
}
