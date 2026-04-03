using Microsoft.EntityFrameworkCore;
using SME_Ecotech2A.Domain.Entity;
using Task = SME_Ecotech2A.Domain.Entity.Task;

namespace SME_Ecotech2A.Infrastructure.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<BugAttachment> BugAttachments { get; set; }
        public DbSet<BugRCAHistory> BugRcaHistories { get; set; }
        public DbSet<BugTicket> BugTickets { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientContact> ClientContacts { get; set; }
        public DbSet<ConflictEvent> ConflictEvents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDocument> ProjectDocuments { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<ReviewFeedback> ReviewFeedbacks { get; set; }
        public DbSet<ReviewSession> ReviewSessions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskAttachment> TaskAttachments { get; set; }
        public DbSet<TaskDependency> TaskDependencies { get; set; }
        public DbSet<TaskProgressLog> TaskProgressLogs { get; set; }
        public DbSet<TimesheetEntry> TimesheetEntries { get; set; }
        public DbSet<RegressionItem> RegressionItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }
    }
}
