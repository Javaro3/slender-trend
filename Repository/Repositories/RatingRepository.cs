using Domains.Domains;

namespace Repository.Repositories {
    public class RatingRepository : IRepository<RatingDomain> {
        private readonly SlenderTrendContext _context;

        public RatingRepository(SlenderTrendContext context) {
            _context = context;
        }

        public IEnumerable<RatingDomain> GetAll() {
            return _context.Ratings;
        }
    }
}
