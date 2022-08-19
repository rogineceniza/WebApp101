namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }// use this instead of IEnumerable
    }                                        // Maka filter, but can be evaluated again, new query will be sent to the db 
}                                              
