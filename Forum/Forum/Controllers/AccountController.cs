using Forum.Models;
using Forum.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Host.SystemWeb;
using Forum.Models.ViewModel;

namespace Forum.Controllers
{
    public class AccountController : Controller
    {
        private ForumBdd forumBdd = Util.Instance.DB();
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                User searchUser = forumBdd.Users.FirstOrDefault(x => x.Username == user.Username && x.Email == user.Email);
                Role role = forumBdd.Roles.FirstOrDefault(x => x.Name == "Admin");


                if (searchUser != null)
                {
                    
                    if (user.Email == searchUser.Email)
                    {
                        ModelState.AddModelError("Email", "Cet e-mail est déja utilisé");
                    }
                    if (user.Username == searchUser.Username)
                    {
                        ModelState.AddModelError("Username", "Ce nom d'utilisteur est déja utilisé ");
                    }

                    return View(user);
                }

                user.Role = role;
                forumBdd.Entry(user).State = System.Data.Entity.EntityState.Added;
                forumBdd.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            if(user.Password.Equals(user.ConfirmPassword))
            {
                User searchUser = forumBdd.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
                Role role = forumBdd.Roles.FirstOrDefault(x => x.Id == searchUser.RoleID);
                if (searchUser != null)
                {
                    searchUser.Role = role;
                    var ident = new ClaimsIdentity(
                        new[] { 
                            //Ajout de l'username
                            new Claim(ClaimTypes.NameIdentifier, user.Username),

                            new Claim(ClaimTypes.Name,user.Username),

                            //Ajout des rôles
                            new Claim(ClaimTypes.Role, searchUser.Role == null ? " " : searchUser.Role.Name)

                                },
                                DefaultAuthenticationTypes.ApplicationCookie);

                    HttpContext.GetOwinContext().Authentication.SignIn(
                    new AuthenticationProperties { IsPersistent = false }, ident);

                    return RedirectToAction("index", "home");
                }
                //Mot de passe ou utilisateur incorrect
                ModelState.AddModelError("", "Nom d'utilisateur ou mot de passe invalide");
                return View(user);
            }

            ModelState.AddModelError("", "Les mots de passe ne sont pas identique");
            return View(user);
            
           
        }


        public ActionResult LogOff()
        {
            var owinContext = Request.GetOwinContext();
            var authenticationManager = owinContext.Authentication;
            authenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}