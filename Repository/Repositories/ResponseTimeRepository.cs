using Domains.Domains;

namespace Repository.Repositories {
    public class ResponseTimeRepository : IRepository<ResponseTimeDomain> {
        private readonly SlenderTrendContext _context;

        public ResponseTimeRepository(SlenderTrendContext context) {
            _context = context;
        }

        public IEnumerable<ResponseTimeDomain> GetAll() {
            return _context.ResponseTimes;
        }
    }
}
