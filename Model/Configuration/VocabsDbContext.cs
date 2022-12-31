namespace Model.Configuration;

public class VocabsDbContext : DbContext
{
    public DbSet<Folder> Folders { get; set; }
    public DbSet<StudySet> StudySets { get; set; }
    public DbSet<Word> Words { get; set; }
    public DbSet<Wordpair> Wordpairs { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleClaim> RoleClaims { get; set; }
    

    public VocabsDbContext(DbContextOptions<VocabsDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folder>()
            .HasOne(f => f.ParentFolder)
            .WithMany()
            .HasForeignKey(f => f.ParentFolderId);

        modelBuilder.Entity<StudySet>()
            .HasOne(s => s.Folder)
            .WithMany()
            .HasForeignKey(s => s.FolderId);

        modelBuilder.Entity<Wordpair>()
            .HasOne(p => p.StudySet)
            .WithMany()
            .HasForeignKey(p => p.StudySetId);

        modelBuilder.Entity<Wordpair>()
            .HasOne(p => p.KnownWord)
            .WithMany()
            .HasForeignKey(p => p.KnownWordId);

        modelBuilder.Entity<Wordpair>()
            .HasOne(p => p.LearningWord)
            .WithMany()
            .HasForeignKey(p => p.LearningWordId);

        modelBuilder.Entity<Word>()
            .HasOne(w => w.Language)
            .WithMany()
            .HasForeignKey(w => w.LanguageId);
        
        modelBuilder.Entity<Word>()
            .HasDiscriminator<string>("WORD_TYPE")
            .HasValue<Noun>("NOUN")
            .HasValue<Verb>("VERB")
            .HasValue<Adjective>("ADJECTIVE")
            .HasValue<Pronoun>("PRONOUN")
            .HasValue<Adverb>("ADVERB")
            .HasValue<Preposition>("PREPOSITION")
            .HasValue<Conjunction>("CONJUNCTION")
            .HasValue<Interjection>("INTERJECTION");
        
        // UNIQUE

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Role>()
            .HasIndex(r => r.Identifier)
            .IsUnique();

        // HAS KEY

        modelBuilder.Entity<RoleClaim>()
            .HasKey(rc => new { rc.UserId, rc.RoleId });
        
        // RELATIONSHIPS
        // 1:1
        // 1:N
        // N:M

        modelBuilder.Entity<RoleClaim>()
            .HasOne(rc => rc.Role)
            .WithMany(r => r.RoleClaims)
            .HasForeignKey(rc => rc.RoleId);

        modelBuilder.Entity<RoleClaim>()
            .HasOne(rc => rc.User)
            .WithMany(u => u.RoleClaims)
            .HasForeignKey(rc => rc.UserId);
        
        // OTHER
        // SEEDING
        modelBuilder.Entity<Role>()
            .HasData(new Role { Id = 1, Identifier = "Admin", Description = "Administrator" });
    }
}