using Domains.Domains;

namespace Repository.Repositories {
    public class TagRepository : IRepository<TagDomain> {
        private readonly SlenderTrendContext _context;

        public TagRepository(SlenderTrendContext context) {
            _context = context;
        }

        public IEnumerable<TagDomain> GetAll() {
            return _context.Tags;
        }
    }
}
