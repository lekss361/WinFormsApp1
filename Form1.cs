namespace WinFormsApp1
{
    using Binance.Net.Clients;
    using Bybit.Net.Clients;
    using Kucoin.Net.Clients;
    using System;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutModel outModel = new OutModel() { Binance = 0, ByBit = 0, Kucoin = 0 };


            //textBinance.DataBindings.Add(new Binding("Text", outModel, "Binance", false, DataSourceUpdateMode.OnPropertyChanged));
            //textBybit.DataBindings.Add(new Binding("Text", outModel, "ByBit", false, DataSourceUpdateMode.OnPropertyChanged));
            //textkucoin.DataBindings.Add(new Binding("Text", outModel, "Kucoin", false, DataSourceUpdateMode.OnPropertyChanged));



        }
        OutModel outModel = new OutModel();
        private async void button2_Click(object sender, EventArgs e)
        {
            var binanceRestClient = new BinanceRestClient();
            var spotOrderBookData = await binanceRestClient.SpotApi.ExchangeData.GetPriceAsync("BTCUSDT");
            //outModel = spotOrderBookData.Data.Price.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                try
                {
                        var binanceRestClient = new BinanceRestClient();
                        var bybitClient = new BybitRestClient();
                        var kucoinClient = new KucoinRestClient();
                    while (true)
                    {
                        outModel.Binance = binanceRestClient.SpotApi.ExchangeData.GetPriceAsync("BTCUSDT").Result.Data.Price;
                        outModel.ByBit =  bybitClient.UsdPerpetualApi.ExchangeData.GetTickerAsync("BTCUSDT").Result.Data.First().LastPrice;
                        outModel.Kucoin = (decimal)kucoinClient.SpotApi.ExchangeData.GetTickerAsync("BTC-USDT").Result.Data.LastPrice!;

                        Invoke((MethodInvoker)delegate
                        {
                            outModelBindingSource.DataSource= outModel;
                        });
                        //Task.Delay(5000);
                    }
                }
                catch (Exception ex)
                {


                }
            });
        }

        private void label3_Click_1(object sender, EventArgs e)
        {


        }
    }
}