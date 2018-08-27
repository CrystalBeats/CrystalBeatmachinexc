using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBeatmachine
{
    class MainViewModel : INotifyPropertyChanged
    {

        #region Interface
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public void onPropertyChanged(object propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(propName)));
        }

        #endregion


    }
}
