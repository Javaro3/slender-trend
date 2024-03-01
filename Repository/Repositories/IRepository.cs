namespace Repository.Repositories {
    public interface IRepository<TEntity> {
        IEnumerable<TEntity> GetAll();
    }
}
