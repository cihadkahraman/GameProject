using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class GamerManager : IGamerService
    {
        IVerifyService verifyService;



        public GamerManager(IVerifyService verifyService)
        {
            this.verifyService = verifyService;
        }

        public void Add(Gamer gamer)
        {   
            if(verifyService.IdentityControl(gamer) == true)
            {
                Console.WriteLine("Oyuncu " + gamer.Name_Surname + " sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulama hatası.");
            }
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu " + gamer.Name_Surname + " sistemden silindi.");
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu " + gamer.Name_Surname + " güncellendi.");
        }
    }
}
