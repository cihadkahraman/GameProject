using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class VerifyManager : IVerifyService

    {
        public bool BirthYearControl(Gamer gamer)
        {
            if (gamer.BirthYear <=2004 )

            {   
                
                return true;
            }
            else
            {
                System.Console.WriteLine("18 yaşından küçükler kayıt olamaz");
                return false;
            }
        }

        public bool IdentityControl(Gamer gamer)
        {
            if (gamer.Identity.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Name_SurnameControl(Gamer gamer)
        {
            return true;
        }
    }
}
