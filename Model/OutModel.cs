namespace WinFormsApp1.Model;

using Binance.Net;
using Binance.Net.Clients;
using Bybit.Net;
using Kucoin.Net;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class OutModel : INotifyPropertyChanged
{
    private decimal binance;
    private decimal byBit;
    private decimal kucoin;
    public decimal Binance
    {
        get => binance;
        set
        {
            if (binance != value)
            {
                binance = value;
                OnPropertyChanged();
            }
        }
    }
    public decimal ByBit
    {
        get => byBit;
        set
        {
            if (byBit != value)
            {
                byBit = value;
                OnPropertyChanged();
            }
        }
    }
    public decimal Kucoin
    {
        get => kucoin;
        set
        {
            if (kucoin != value)
            {
                kucoin = value;
                OnPropertyChanged();
            }
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
