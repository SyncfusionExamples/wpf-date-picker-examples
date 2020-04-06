using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDateSelector_ItemCustomization
{
    class ViewModel : NotificationObject
    {
        private bool showDropDownButton = true;
        private bool isDropDownOpen = false;
        public bool ShowDropDownButton
        {
            get
            {
                return showDropDownButton;
            }
            set
            {
                showDropDownButton = value;
                this.RaisePropertyChanged("ShowDropDownButton");
            }
        }

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
        public ViewModel()
        {

        }
    }
}
