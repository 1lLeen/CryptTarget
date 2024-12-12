namespace CryptTarget.Models.Helpers
{
    public abstract class HanldeData
    {
        public List<Crypt> GetDataCrypt()
        {
            List<Crypt> values = new List<Crypt>();
            dynamic obj = UrlHelper.makeAPICall();
            foreach (var item in obj.data)
            {
                values.Add(
                    new Crypt
                    {
                        Id = item.id,
                        Name = item.name,
                        Logo = $"https://s2.coinmarketcap.com/static/img/coins/64x64/{item.id}.png",
                        Symbol = item.symbol,
                        Price = item.quote.USD.price,
                        ValumeChange24H = item.quote.USD.volume_change_24h,
                        MarkteCap = item.quote.USD.market_cap,
                        LastUpdate = item.quote.USD.last_update
                    });
            }
            return values;
        }
    }
}
