using Forum.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Forum.Models.RoleConfiguration
{
    public class AppRole : RoleProvider
    {
        public override string ApplicationName { get; set; }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            
        }

        public override void CreateRole(string roleName)
        {
            Role role = new Role
            {
                Name = roleName
            };
            Util.Instance.DB().Entry(role).State = System.Data.Entity.EntityState.Added;
            Util.Instance.DB().SaveChanges();
       }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            return false;
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            return new string[0];
        }

        public override string[] GetAllRoles()
        {
            List<string> listRole = new List<string>();

            foreach(Role role in Util.Instance.DB().Roles)
            {
                listRole.Add(role.Name);
            }
            return listRole.ToArray();
        }

        public override string[] GetRolesForUser(string username)
        {
            return new string[0];
        }

        public override string[] GetUsersInRole(string roleName)
        {
            return new string[0];
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            User user = Util.Instance.DB().Users.FirstOrDefault(x => x.Username == username);
            if(user.Role.Name == roleName)
            {
                return true;
            }
            return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            
        }

        public override bool RoleExists(string roleName)
        {
            return false;
        }
    }
}