using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using System;

public class FormDbContext : DbContext
{
    #region Contructor
    public FormDbContext(DbContextOptions<FormDbContext> options)
            : base(options)
    {

    }
    #endregion

    #region Public properties
    public DbSet<Form> forms { get; set; }
    #endregion

    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Form>().HasData(GetForms());
        base.OnModelCreating(modelBuilder);
    }

    private Form[] GetForms()
    {
        throw new NotImplementedException();
    }
}
#endregion
