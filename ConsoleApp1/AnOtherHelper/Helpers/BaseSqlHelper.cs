namespace ConsoleApp1.AnOtherHelper.Helpers
{
    using SqlHelpers;
    using static SqlHelpers.QueryMethods;

    class BaseSqlHelper
    {
        public BaseSqlHelper()
        {
            var connectionHelper = new ConnectionHelper {QueryMethod = DELETE};
        }
    }
}