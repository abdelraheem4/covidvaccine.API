﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using Dapper;

namespace covidvaccineAPI.INFRA.Repository
{
    public class VaccinesRepository : IVaccinesRepository
    {
        private readonly IDbContext _dbContext;

        public VaccinesRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void CreateVaccines(Vaccines vaccines)
        {
            var p = new DynamicParameters();
            p.Add("Vacci_nename", vaccines.Vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Vaccine_doses", vaccines.Vaccinedoses, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("Vaccine_exp", vaccines.Vaccineexp, dbType: DbType.Date, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Vaccines_Package.CREATEVaccines", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteVaccines(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Vaccines_Package.DELETEVaccines", p, commandType: CommandType.StoredProcedure);
        }

        public List<Vaccines> GetAllVaccine()
        {
            IEnumerable<Vaccines> result = _dbContext.Connection.Query<Vaccines>("Vaccines_Package.GetAllVaccines", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public Vaccines GetVaccinesById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Vaccines> result = _dbContext.Connection.Query<Vaccines>("Vaccines_Package.GetVaccinesById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateVaccines(Vaccines vaccines)
        {
            var p = new DynamicParameters();
            p.Add("Vacci_nename", vaccines.Vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Vaccine_doses", vaccines.Vaccinedoses, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("Vaccine_exp", vaccines.Vaccineexp, dbType: DbType.Date, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Vaccines_Package.UPDATEVaccines", p, commandType: CommandType.StoredProcedure);
        }
    }
}