namespace WinFormsApp1.Services
{
    using WinFormsApp1.Model;

    public interface IPriceServices
    {
        OutModel GetAllServicesPriceTicket(string ticket);
        decimal GetTicketKuCoin(string ticket);
        decimal GetTicketPriceBinance(string ticket);
        decimal GetTicketPriceByBit(string ticket);
    }
}