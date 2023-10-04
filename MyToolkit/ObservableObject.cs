using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace MyToolkit;
public class ObervableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public void MyOnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string name = "")
    {
        if (!EqualityComparer<T>.Default.Equals(property, value))
        {
            property = value;
            OnPropertyChanged(nameof(name));
        }
    }
}