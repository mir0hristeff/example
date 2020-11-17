namespace ConsoleApp1.AnOtherHelper.Helpers.SqlHelpers
{
    class ConnectionHelper
    {
        public QueryMethods QueryMethod { get; set; }
    }

    public enum QueryMethods
    { 
        SELECT,
        DELETE,
        UPDATE,
        INSERT
    }
}
