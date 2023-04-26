namespace InfoServerGRPC.Repositories
{
    public abstract class BaseRepository
    {
        protected InfoDbContext context;
        public BaseRepository(InfoDbContext context)
        {
            this.context = context;
        }
    }
}
