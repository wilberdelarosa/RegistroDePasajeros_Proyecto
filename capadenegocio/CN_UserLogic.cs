using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capadedatos;


namespace capadenegocio
{
    public class CN_UserLogic
    {
        private CD_User CD_User = new CD_User();
        private CryptographyLogic cryptoLogic = new CryptographyLogic();


        public bool RegisterUser(string username, string password)
        {
            byte[] salt = cryptoLogic.GenerateSalt();

            byte[] passwordHash = cryptoLogic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);

            UserBE user = new UserBE
            {
                Usuario = username,
                Salt = salt,
                PasswordHash = passwordHash
            };

            return CD_User.SaveUser(user);
        }



        public bool IsValidUser(string username, string password)
        {
            UserBE user = CD_User.GetUserFromDB(username);
            if (user == null) return false;

            byte[] passwordHash = cryptoLogic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), user.Salt);
            return passwordHash.SequenceEqual(user.PasswordHash);




        }


    }


}




