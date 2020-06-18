using MindMap.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMap.Controllers
{
    public class UserController
    {
        public static bool AddUser(User user)
        {
            bool a = false;
            using (HmindMapEntities db = new HmindMapEntities())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    a = true;
                }
                catch
                {
                    a = false;
                }
            }
            return a;
        }
        public static User GetUser(string username)
        {
            User user = null;
            using (HmindMapEntities db = new HmindMapEntities())
            {
                user =  db.Users.Find(username);
            }
            return user;
        }
        public static bool CanSignIn(string user, string Pass)
        {
            bool a = false;
            using (HmindMapEntities db = new HmindMapEntities())
            {
                User u = db.Users.Find(user);
                if(u != null && u.Pass == Pass)
                {
                    a = true;
                }    

            }
            return a;
        }

        public static List<MapUser> GetMapUsers(string Username)
        {
            using (HmindMapEntities db = new HmindMapEntities())
            {
                return db.Users.Find(Username).MapUsers.ToList();
            }
            
        }
        public static List<MapUser> GetMapUsers()
        {
            List <MapUser> a= null;
            using (HmindMapEntities db = new HmindMapEntities())
            {
                if(CurrentUser != null)
                {
                    a =  db.Users.Find(CurrentUser).MapUsers.ToList();
                }    
            }
            return a;

        }
        public static string CurrentUser { get; set; }
        public static void DeletedMap(string mapname)
        {
            using(HmindMapEntities db = new HmindMapEntities())
            {
                db.MapUsers.Remove(db.MapUsers.Find(mapname));
                db.SaveChanges();
            }    
        }

    }
}
