namespace WinFormsApp1;

using System;
using WinFormsApp1.Model;
using WinFormsApp1.Services;

public partial class Form1 : Form
{
    private IPriceServices priceServices;
    private OutModel outModel;

    public Form1(IPriceServices priceServices)
    {
        InitializeComponent();
        outModel = new OutModel() { Binance = 0, ByBit = 0, Kucoin = 0 };
        this.priceServices = priceServices;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Task.Run(async () =>
        {
            try
            {
                while (true)
                {
                    outModel = priceServices.GetAllServicesPriceTicket("BTCUSDT");
                    Invoke((MethodInvoker)delegate
                    {
                        outModelBindingSource.DataSource = outModel;
                    });

                    await Task.Delay(4100);
                }
            }
            catch (Exception ex) { }
        });
    }
}