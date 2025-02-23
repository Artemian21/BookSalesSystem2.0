namespace BookSalesSystem2._0
{
    public class DatabaseAvailable
    {
        public static bool IsDatabaseAvailable()
        {
            try
            {
                using (var context = new BookSalesSystemContext())
                {
                    return context.Database.CanConnect();
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
