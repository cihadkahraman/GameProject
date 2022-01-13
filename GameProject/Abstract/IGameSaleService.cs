using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Games games, Campaign campaign);
    }
}
