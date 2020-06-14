using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        /*
        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private DelegateCommand _clickCommnd;
        public DelegateCommand ClickCommnd =>
            _clickCommnd ?? (_clickCommnd = new DelegateCommand(ExecuteClickCommnd));

        void ExecuteClickCommnd()
        {
            this.Text = "Click Me！";
        }

        public MainWindowViewModel()
        {
            this.Text = "Hello Prism!";
        }
        */

        private bool _isCanExcute;
        public bool IsCanExcute
        {
            get { return _isCanExcute; }
            set
            {
                SetProperty(ref _isCanExcute, value);
                GetCurrentTimeCommand.RaiseCanExecuteChanged();
            }
        }

        private string _currentTime;
        public string CurrentTime
        {
            get { return _currentTime; }
            set { SetProperty(ref _currentTime, value); }
        }

        private DelegateCommand _getCurrentTimeCommand;
        public DelegateCommand GetCurrentTimeCommand =>
            _getCurrentTimeCommand ?? (_getCurrentTimeCommand = new DelegateCommand(ExecuteGetCurrentTimeCommand, CanExecuteGetCurrentTimeCommand));

        void ExecuteGetCurrentTimeCommand()
        {
            this.CurrentTime = DateTime.Now.ToString();
        }

        bool CanExecuteGetCurrentTimeCommand()
        {
            return IsCanExcute;
        }
    }
}
