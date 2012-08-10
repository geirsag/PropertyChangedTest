namespace PropertyChangedTest.NameService
{
    public partial class Person
    {
        private string _addressLine1;
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value;
                RaisePropertyChanged("AddressLine1");
            }
        }

        public string AddressLine2 { get; set; }

        public string FullAddress { get { return string.Format("{0}\n{1}", AddressLine1, AddressLine2); } }
    }
}
