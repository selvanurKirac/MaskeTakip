﻿using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)// constructor new yapıldığında çalışır
        {

            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {


            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            

        }
    }
}