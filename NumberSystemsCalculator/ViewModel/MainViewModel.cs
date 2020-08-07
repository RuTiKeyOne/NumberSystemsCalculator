
using GalaSoft.MvvmLight.Command;
using NumberSystemsCalculator.Model;
using NumberSystemsCalculator.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NumberSystemsCalculator.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Field
        private string isNeedTransform { get; set; }
        public string IsNeedTransform
        {
            get => isNeedTransform;
            set
            {
                isNeedTransform = value;
                OnPropertyChanged(nameof(IsNeedTransform));
            }
        }
        private int inTheNumberSystem { get; set; }
        public int InTheNumberSystem
        {
            get => inTheNumberSystem;
            set
            {
                inTheNumberSystem = value;
                OnPropertyChanged(nameof(InTheNumberSystem));
            }
        }

        #endregion

        #region Ctor
        public MainViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseCommand);
            TransformCommand = new ActionCommand(OnTransformCommandExecuted, CanTransformCommandExecute);
        }
        #endregion

        #region TransformCommand
        public ICommand TransformCommand { get; set; }

        private bool CanTransformCommandExecute(object p) => true;

        private void OnTransformCommandExecuted(object p)
        {
            MainModel.TransformNumber(IsNeedTransform, InTheNumberSystem);
        }
        #endregion

        #region CloseCommand
        public RelayCommand<Window> CloseWindowCommand { get; set; }

        private void CloseCommand(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        #endregion

    }
}
