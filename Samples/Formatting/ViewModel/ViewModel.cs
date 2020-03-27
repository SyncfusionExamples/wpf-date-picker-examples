using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDatePicker_Formatting
{
    class ViewModel : NotificationObject
    {
        private ICommand formatselectionChangedCommand;
        private ICommand selectionChangedCommand;
        private string selectorFormatString="M";
        private string formatString="M";
        public string SelectorFormatString
        {
            get
            {
               return selectorFormatString;
            }
            set
            {
                 selectorFormatString = value;
                this.RaisePropertyChanged("SelectorFormatString");
            }
        }

        public string FormatString
        {
            get
            {
                return formatString;
            }
            set
            {
                formatString = value; ;
                this.RaisePropertyChanged("FormatString");
            }
        }

        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }
       

        public ICommand FormatSelectionChangedCommand
        {
            get
            {
                return formatselectionChangedCommand;
            }
        }
        public ViewModel()
        {
            selectionChangedCommand = new DelegateCommand<object>(selectionChanged);
            formatselectionChangedCommand = new DelegateCommand<object>(selectionChanged);
        }

        public void selectionChanged(object parameter)
        {
            ComboBoxItem comboBoxItem = (parameter as ComboBox).SelectedItem as ComboBoxItem;
            if(comboBoxItem.Content.ToString()== "Date")
            {
                FormatString = "D";
            }
            else if (comboBoxItem.Content.ToString() == "Month")
            {
                FormatString = "M";
            }
            else if(comboBoxItem.Content.ToString() == "Year")
            {
                FormatString = "Y";
            }
            else if(comboBoxItem.Content.ToString() == "Date Selector")
            {
                SelectorFormatString = "D";
            }
            else if(comboBoxItem.Content.ToString() == "Month Selector")
            {
                SelectorFormatString = "M";
            }
            else if(comboBoxItem.Content.ToString() == "Year Selector")
            {
                SelectorFormatString = "Y";
            }
        }
    }


}
