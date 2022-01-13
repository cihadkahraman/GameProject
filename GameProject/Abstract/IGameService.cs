using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        public void Add(Games games);
        public void Delete(Games games);

    }
}
