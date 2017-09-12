using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.ViewModel
{
    public class BaseViewModel: MvxViewModel, IDisposable
    {
        protected IMvxMessenger messenger;

        public BaseViewModel(IMvxMessenger messenger)
        {
            this.messenger = messenger;
        }

        protected async Task ReloadDataAsync()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        protected virtual Task InitializeAsync()
        {
            return Task.FromResult(0);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
