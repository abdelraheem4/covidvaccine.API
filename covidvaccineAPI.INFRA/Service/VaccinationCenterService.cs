﻿using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class VaccinationCenterService : IVaccinationCenterService
    {
        private readonly IVaccinationCenterRepository _VaccinationCenterRepository;
        public VaccinationCenterService(IVaccinationCenterRepository vaccinationCenterRepository)
        {
            _VaccinationCenterRepository = vaccinationCenterRepository;
        }

        public void CreateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            _VaccinationCenterRepository.CreateVaccinationCenter(vaccinationcenter);
        }

        public void DeleteVaccinationCenter(int id)
        {
            _VaccinationCenterRepository.DeleteVaccinationCenter(id);
        }

        public List<Vaccinationcenter> GetAllVaccinationCenter()
        {
            return _VaccinationCenterRepository.GetAllVaccinationCenter();
        }

        public Vaccinationcenter GetVaccinationCenterById(int id)
        {
            return _VaccinationCenterRepository.GetVaccinationCenterById(id);
        }

        public void UpdateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            _VaccinationCenterRepository.UpdateVaccinationCenter(vaccinationcenter);
        }
    }
}
