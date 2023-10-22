namespace MyToolkit;

public class BaseViewModel<TModel> : ObervableObject
{
    private TModel _model;
    public TModel Model
    {
        get => _model;
        set => MyOnPropertyChanged(ref _model, value);
    }

    public BaseViewModel(TModel model)
    {
        Model = model;
    }

    public BaseViewModel() 
        : this(default(TModel))
    {}
}

public class BaseViewModel : ObervableObject
{
    public BaseViewModel()
    {}
}