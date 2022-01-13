using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class GameManager : IGameService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.GamePrice + " tutarındaki " + games.GameName + " oyunumuzu satın aldığınız için teşekkür ederiz. " + games.GameNo + " oyun numarasıyla oyunla ilgili dosyalara kütüphanemizden erişebilirsiniz.");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.GameName + " oyununu iade ettiniz. Yine bekleriz.");
        }

    }
}
