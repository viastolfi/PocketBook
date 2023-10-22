using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace MyToolkit;
public class ObervableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected void MyOnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string name = "")
    {
        if (EqualityComparer<T>.Default.Equals(property, value)) return;
        property = value;
        OnPropertyChanged(name);
    }

    protected void MyOnPropertyChanged<T>(T property, T value, Action<T> action,
        [CallerMemberName] string name = "")
    {
        if (EqualityComparer<T>.Default.Equals(property, value)) return;
        action(value);
        OnPropertyChanged(name);        
    }
}