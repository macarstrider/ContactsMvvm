using Contacts.Core.Model;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.ViewModel
{
    public class ContactDetailViewModel: BaseViewModel
    {
        public ContactProfileModel _selectedContact;
        MvxCommand CloseCommand { get; set; }
        public IMvxMessenger _messenger;
        //On close clicled
        public ContactDetailViewModel(IMvxMessenger messenger): base(messenger)
        {
            _messenger = messenger;
            CloseCommand = new MvxCommand(() => Close(this));
        }

        //Load data
        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }
        protected override Task InitializeAsync()
        {
            return base.InitializeAsync();
            //get the contact id to load
        }

        //On item clicked
        public ContactProfileModel SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                RaisePropertyChanged(() => SelectedContact);
            }
        }
    }
}
