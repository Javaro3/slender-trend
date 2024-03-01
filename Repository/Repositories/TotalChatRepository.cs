using Domains.Domains;

namespace Repository.Repositories {
    public class TotalChatRepository : IRepository<TotalChatDomain> {
        private readonly SlenderTrendContext _context;

        public TotalChatRepository(SlenderTrendContext context) {
            _context = context;
        }

        public IEnumerable<TotalChatDomain> GetAll() {
            return _context.TotalChats;
        }
    }
}
