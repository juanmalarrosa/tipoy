using System;
using System.Collections.Generic;
using Logica;
using Entidades;


namespace DB
{
    public class MarcaStorage : IMarcaDataAccess
    {

        public readonly Context _context;


        public MarcaStorage(Context context)
        {
            _context = context;
        }


        public User Find(int id)
        {
            return _context.Users.FirstOrDefault(c => c.id == id);
        }

        public User FindByUsername(string username)
        {

            return _context.Users.FirstOrDefault(c => c.username == username);

        }

        public List<User> List()
        {

            return _context.Users.ToList();

        }

        public void Add(User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();

        }

        public void Delete(User user)
        {

            _context.Users.Remove(user);
            _context.SaveChanges();

        }

        public int ListCount()
        {

            return _context.Users.ToList().Count();

        }


        //Modifiers


        public void Modify(User user, User newUser)
        {

            User actualUser = _context.Users.Find(user.id);
            actualUser.name = newUser.name;
            actualUser.lastname = newUser.lastname;
            actualUser.email = newUser.email;
            actualUser.password = newUser.password;
            actualUser.username = newUser.username;
            actualUser.isAdmin = newUser.isAdmin;

            _context.SaveChanges();


        }


    }
}
