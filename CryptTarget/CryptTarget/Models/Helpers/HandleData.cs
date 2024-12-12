namespace CryptTarget.Models.Helpers
{
    public class HanldeData
    {
        public async Task<List<Crypt>> GetDataCrypt()
        {
            List<Crypt> values = new List<Crypt>();
            var obj = await UrlHelper.makeAPICall();
            dynamic dy = obj;
            foreach (var item in dy.data)
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
                    });
            }
            return values;
        }
    }
}
