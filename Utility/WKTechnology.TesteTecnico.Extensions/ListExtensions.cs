namespace WKTechnology.TesteTecnico.Extensions
{
    public static class ListExtensions
    {
        public static bool HasValue<T>(this IEnumerable<T> lstValues)
        {
            return lstValues != null && lstValues.Any();
        }
    }
}
