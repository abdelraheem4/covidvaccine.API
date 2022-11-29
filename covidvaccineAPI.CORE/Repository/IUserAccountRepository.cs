﻿ using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
   public interface IUserAccountRepository
    {
        List<Useraccount> GetAllUsers();
        List<Useraccount> getALLDOCTOR();
        Useraccount GetUserById(int id);
        void CreateUser(Useraccount useraccount);
        void UpdateUser(Useraccount useraccount);
        void DeleteUser(int id);
        List<Useraccount> firstvaccine();
        List<Useraccount> Secondvaccine();
        List<Useraccount> NotTokeVaccine();


    }
}
