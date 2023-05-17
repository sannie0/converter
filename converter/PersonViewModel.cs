using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Android.Icu.Util;
using Android.Provider;
using Flurl.Http;
using Android.Renderscripts;
using Bumptech.Glide.Load.Model;

namespace converter;

public class PersonViewModel:INotifyPropertyChanged
{
    
    public ObservableCollection<Valutes> ValutesList { get;} = new ObservableCollection<Valutes> { };
    public PersonViewModel()
    {
        LoadData(DateTime.Today.ToString("yyyy/MM/dd").Replace(".", "/"));
        LoadDataCommand = new Command(s =>
        {
            LoadData(SelectedDate.ToString("yyyy/MM/dd").Replace(".", "/"));
        });
            //ConvertCommand = new Command(ExecuteConvert);
    }
    public double conversion;
    
        public double Conversion
        {
            get => conversion;
            set
            {
                if (conversion != value)
                {
                    conversion = value;
                    OnPropertyChanged(nameof(Conversion));
                    ExecuteConvert();
                }
            }
        }
    private void ExecuteConvert()
    {
        if(FirstValute == null || SecondValute == null) return;
        double conversion = Valuedouble;
        double result = conversion * (SecondValute.Value / FirstValute.Value);
        Conversion = result;
    }

    public double Valuedouble
    {
        get
        {
            return double.TryParse(_valueinput, out var doubleval) ? doubleval : 0;
        }
    }
    
    
    public ICommand LoadDataCommand { get; }
    //public ICommand ConvertCommand { get; }
    private DateTime _selectedDate = DateTime.Today;
    
    private Valutes _firstvalute;

    public Valutes FirstValute
    {
        get => _firstvalute;
        set
        {
            if (_firstvalute != value)
            {
                _firstvalute = value;
                OnPropertyChanged(nameof(FirstValute));
            }
        }
    }

    private Valutes _secondvalute;

    public Valutes SecondValute
    {
        get => _secondvalute;
        set
        {
            if (_secondvalute != value)
            {
                _secondvalute = value;
                OnPropertyChanged(nameof(SecondValute));
            }
        }
    }
    private string _valueinput = string.Empty;

    public string ValueInput
    {
        get => _valueinput;
        set
        {
            if (_valueinput == value) return;
            _valueinput = value;
            OnPropertyChanged(nameof(ValueInput));
            ExecuteConvert();
        }
    }
    
    public DateTime SelectedDate
    {
        get => _selectedDate;
        set
        {
            if (_selectedDate != value)
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
                LoadDataCommand.Execute(null);
                ExecuteConvert();
            }
        }
    }
    private async Task LoadData(string date)
    {
        int findex = 0;
        int sindex = 0;
        if (FirstValute != null)
        {
            findex = ValutesList.IndexOf(FirstValute);
        }
        if (SecondValute != null)
        {
            sindex = ValutesList.IndexOf(SecondValute);
        }
        try
        {
            var result = await $"https://www.cbr-xml-daily.ru/archive/{date}/daily_json.js".GetJsonAsync<Root>();
            if (result == null)
                return;
            ValutesList.Clear();
            ValutesList.Add(new Valutes() { CharCode = "RUB", Name = "Российский рубль", Value = 1, Nominal = 1 });
            foreach (var i in result.Valute.Items)
            {
                ValutesList.Add(i);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        ExecuteConvert();
        FirstValute = ValutesList[findex];
        SecondValute = ValutesList[sindex];
    }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
}