namespace ApisMbO.DAL
{
    public enum TipoOperacao
    {
        Detached = 0,
        Unchanged = 1,
        Deleted = 2,
        Modified = 3,
        Added = 4
    }
    public abstract class GenericDao<T> where T:class
    {
        public GenericDao()
        {
                
        }
    }
}
