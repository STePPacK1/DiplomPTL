using System.Linq;
using ProgrammingLearningTasks.Database.Entities;

namespace ProgrammingLearningTasks.Database.Repositories
{
    public class UserRepository
    {
        private readonly ProgrammingLearningTasksContext _context;

        public UserRepository(ProgrammingLearningTasksContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return _context.Users.FirstOrDefault(user => user.Login == login && user.Password == password);
        }
        
        public User GetUserByLogin(string login)
        {
            return _context.Users.FirstOrDefault(user => user.Login == login);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}