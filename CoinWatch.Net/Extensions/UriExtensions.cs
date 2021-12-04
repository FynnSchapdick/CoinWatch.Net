namespace CoinWatch.Net.Extensions
{
    public static class UriExtensions
    {
        public static Uri AddUriEndpoint(this Uri baseUri, string? endpoint)
        {
            Uri uri = new Uri(baseUri, endpoint);
            UriBuilder uriBuilder = new UriBuilder(uri);
            return uriBuilder.Uri;
        }
    }
}