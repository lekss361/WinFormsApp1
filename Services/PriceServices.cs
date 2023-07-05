namespace WinFormsApp1.Services
{
    using Binance.Net.Clients;
    using Bybit.Net.Clients;
    using Kucoin.Net.Clients;
    using Kucoin.Net.Objects.Models.Spot;
    using System.Collections.Generic;
    using System.Linq;
    using WinFormsApp1.Model;

    public class PriceServices : IPriceServices
    {
        private readonly BinanceRestClient binanceRestClient;
        private readonly BybitRestClient bybitClient;
        private readonly KucoinRestClient kucoinClient;
        private readonly List<KucoinSymbol> kucoinSymbols;


        public PriceServices()
        {
            this.binanceRestClient = new BinanceRestClient();
            this.bybitClient = new BybitRestClient();
            this.kucoinClient = new KucoinRestClient();
            this.kucoinSymbols = kucoinClient.SpotApi.ExchangeData.GetSymbolsAsync().Result.Data.ToList();
        }

        public OutModel GetAllServicesPriceTicket(string ticket)
        {
            OutModel result = new();

            result.Binance = GetTicketPriceBinance(ticket);
            result.ByBit = GetTicketPriceByBit(ticket);
            result.Kucoin = GetTicketKuCoin(ticket);
            return result;
        }

        public decimal GetTicketPriceBinance(string ticket)
        {
            return binanceRestClient.SpotApi.ExchangeData.GetPriceAsync(ticket).Result.Data.Price;
        }

        public decimal GetTicketPriceByBit(string ticket)
        {
            return bybitClient.UsdPerpetualApi.ExchangeData.GetTickerAsync(ticket).Result.Data.First().LastPrice;
        }

        public decimal GetTicketKuCoin(string ticket)
        {
            return (decimal)kucoinClient.SpotApi.ExchangeData.GetTickerAsync(HyphenatedTicket(ticket)).Result.Data.LastPrice!;
        }

        private string HyphenatedTicket(string ticket)
        {
            for (int i = 3; i < 6; i++)
            {
                if (kucoinSymbols.Any(x => x.BaseAsset == ticket.Substring(0, i)))
                {
                    ticket = ticket.Insert(i, "-");
                    break;
                }
            }

            return ticket;
        }
    }
}
