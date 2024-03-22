namespace Mission11_AmazonProject.Models
{
    public interface IBookRepository
    {
        // double check to make sure that its calles 'Books' right here 
        public IQueryable<Book> Books { get; }
    }
}
