using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.EntityFrameworkCore.InMemory;
//using Microsoft.EntityFrameworkCore.SqlServer; 
using Entidades;



namespace DB
{
    public class Context : DbContext
    {

        public DbSet<Marca> Marcas { get; set; }


        public Context()
        {


        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Marca>().HasKey(m => m.Id);
  



            /*One to many: Sports have many teams and Team have one sport

            modelBuilder.Entity<Team>()
                .HasOne<Sport>(s => s.sport);
               

            modelBuilder.Entity<GameTeam>().HasKey(f => new {f.gameId, f.teamId});
            
            modelBuilder.Entity<GameTeam>()
            .HasOne(pc => pc.team);
            

             modelBuilder.Entity<GameTeam>()
            .HasOne(pc => pc.game);

           
            //Many to many: Users have many teams (favorites)
            modelBuilder.Entity<Favorite>().HasKey(f => new {f.userId, f.teamId});
            
            modelBuilder.Entity<Favorite>()
            .HasOne(pc => pc.team);
            

             modelBuilder.Entity<Favorite>()
            .HasOne(pc => pc.user);
           

         
            //One to many: Game have many comments and Comment have one game
            modelBuilder.Entity<Comment>()
                        .HasOne<Game>(t => t.game);
                       


            //One to many: User have many comments and Comment have one user
            modelBuilder.Entity<Comment>()
                        .HasOne<User>(t => t.user);
                        
*/

            base.OnModelCreating(modelBuilder);

        }
    }

}



