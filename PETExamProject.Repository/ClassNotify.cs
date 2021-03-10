using System.ComponentModel;

namespace FormelIt.Repository
{
    // The following class handles and ensures that changes in properties gets updated in the GUI accordingly. It does so with Data Binding.
    public class ClassNotify : INotifyPropertyChanged
    {
        // Local instance of class PropertyChangedEventHandler, which links to the class.
        public event PropertyChangedEventHandler PropertyChanged;

        // Default constructor
        public ClassNotify()
        {
        }

        // The following protected method makes sure the updates get 'broadcasted' to the whole application by receiving a string that contains an ID
        // which is identical to the property that has been updated, and to the element on the User Interface, which gets linked with binding.
        // The received ID triggers two actions:
        // 1. A call being made to the property with the same name to get its 'data'.
        // 2. It 'broadcasts' ID and data to all classes which have been linked via the DataContext statement.
        protected void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
