using Domains.Domains;

namespace Repository.Repositories {
    public class DurationRepository : IRepository<DurationDomain> {
        private readonly SlenderTrendContext _context;

        public DurationRepository(SlenderTrendContext context) {
            _context = context;
        }
        
        public IEnumerable<DurationDomain> GetAll() {
            return _context.Durations;
        }
    }
}
