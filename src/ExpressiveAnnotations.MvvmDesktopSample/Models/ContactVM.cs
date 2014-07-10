﻿using ExpressiveAnnotations.Attributes;

namespace ExpressiveAnnotations.MvvmDesktopSample.Models
{
    public class ContactVM : ViewModelBase
    {
        private string _email;
        private string _phone;

        [RequiredIf("Phone == null")]
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertiesChanged();
            }
        }

        [RequiredIf("Email == null")]
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertiesChanged();
            }
        }

        private void OnPropertiesChanged()
        {
            OnPropertyChanged(() => Email);
            OnPropertyChanged(() => Phone);
        }
    }
}