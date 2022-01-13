using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IVerifyService
    {
        bool IdentityControl(Gamer gamer);
        bool BirthYearControl(Gamer gamer);
        bool Name_SurnameControl(Gamer gamer);

    }
}
