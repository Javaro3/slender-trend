using Domains.Domains;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public partial class SlenderTrendContext : DbContext {
    public SlenderTrendContext() {
    }

    public SlenderTrendContext(DbContextOptions<SlenderTrendContext> options)
        : base(options) {
    }

    public virtual DbSet<DurationDomain> Durations { get; set; }

    public virtual DbSet<RatingDomain> Ratings { get; set; }

    public virtual DbSet<ResponseTimeDomain> ResponseTimes { get; set; }

    public virtual DbSet<TagDomain> Tags { get; set; }

    public virtual DbSet<TotalChatDomain> TotalChats { get; set; }
}
