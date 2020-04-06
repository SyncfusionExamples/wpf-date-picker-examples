using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDateSelector_footer
{
    class ViewModel : NotificationObject
    {
        private bool showOkButton = true;
        private bool showCancelButton = false;
        private bool isDropDownOpen;

        public bool IsDropDownOpen
        {
            get
            {
                return isDropDownOpen;
            }
            set
            {
                isDropDownOpen = value;
                this.RaisePropertyChanged("IsDropDownOpen");
            }
        }
        public bool ShowOkButton
        {
            get
            {
                return showOkButton;
            }
            set
            {
                showOkButton = value;
                this.RaisePropertyChanged("ShowOkButton");
                IsDropDownOpen = true;
            }
        }

        public bool ShowCancelButton
        {
            get
            {
                return showCancelButton;
            }
            set
            {
                showCancelButton = value;
                this.RaisePropertyChanged("ShowCancelButton");
                IsDropDownOpen = true;
            }
        }
        public ViewModel()
        {

        }
    }
}
