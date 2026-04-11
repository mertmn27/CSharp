using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.Context;
using Uygulama.Core.Helper;
using Uygulama.Entities;

namespace Uygulama.Core.BusinessLogicLayer
{
    internal class UserService
    {
        private readonly UserContext context = new UserContext();
        private int LockMinutes = 5;

        public User Login(string username, string password)
        {
            List<User> users = context.Repository.GetAll();
            User foundUser = null;

            foreach (User item in users)
            {
                if (item.UserName == username)
                {
                    foundUser = item;
                    break;
                }
            }
            if(foundUser == null)
            {
                return null;
            }

            if(foundUser.Password != password)
            {
                return null;
            }

            double minutes = DateTime.Now.Subtract(foundUser.LockDate).TotalMinutes;

            if (minutes > LockMinutes) 
            {
                foundUser.IsLock = false;
                foundUser.UpdatedOn = DateTime.Now;
                context.Repository.Save(users);
            }

            if (foundUser.Password == password)
            {
                foundUser.LastLoginDate = DateTime.Now;
                context.Repository.Save(users);
                return foundUser;
            }
            //Şifre hatalı ise
            //Eğer koleksiyon içerisinde username key olarak bulunmuyorsa
            if(!LoginAttempt.FailedCounts.ContainsKey(username))
            {
                //İlk denemesi henüz helper içerisinde deneme işlemleri bulunmadığı için 0 count değerine sahip
                //bir kayıt oluştur.
                LoginAttempt.FailedCounts[username] = 0;
            }

            LoginAttempt.FailedCounts[username]++; // bulduk veya bulmadık farketmez 1 arttırdık.

            // eğer count değeri 3 den fazla ise ilgili kullanıcıyı lock et.

            if (LoginAttempt.FailedCounts[username] >= 3)
            {
                foundUser.IsLock = true;
                foundUser.LockDate = DateTime.Now;
                foundUser.UpdatedOn = DateTime.Now;
                context.Repository.Save(users);
            }

            return null;
        }
    }
}
