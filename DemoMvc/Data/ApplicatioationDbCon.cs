using DemoMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DemoMvc.Data
{
    public class ApplicationDbContext:DbContext{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

}
    public DbSet<Person>Person{get;set;}
    }
}