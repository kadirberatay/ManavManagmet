using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavManagmet
{
    class Login
    {
        private List<User> _users = new List<User>();
        public Login()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Id=1,
                    UserName="erhankaya",
                    Password="123",
                    Name="Erhan",
                    Surname="Kaya"
                },
                new User()
                {
                    Id=2,
                    UserName="yektagoleli",
                    Password="456",
                    Name="Yekta",
                    Surname="Goleli"
                }
            };
            _users = users;
        }
        public bool UserLogin(string userName, string password)
        {
            User loginUser = null;

            //bool status = false; // 2.Yöntem
            foreach (var user in _users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    //status=true;//2.Yöntem
                    loginUser = user;
                }
            }
            //if (loginUser!=null)  // 1.Yöntem
            //{
            //    return true;

            //}
            //else
            //{
            //    return false;
            //}
            return loginUser != null ? true : false; // 3.Yöntem
        }

    }
}
