using DVLD_DataAccess;
using DVLD_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsPerson
    {
        public enum enMode { AddNewMode=1, UpdateMode=2}
        public enMode Mode = enMode.UpdateMode;

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public byte Gender { get; set; }
        public string ImagePath { get; set; }
        public short CountryID { get; set; }

        public clsPerson()
        {
            this.ID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.PhoneNum = "";
            this.Address = "";
            this.BirthDate = DateTime.MinValue;
            this.Gender = 0;
            this.ImagePath = "";
            this.CountryID = -1;
            Mode = enMode.AddNewMode;
        }
        private clsPerson(PersonDTO Person)
        {
            this.ID = Person.ID;
            this.NationalNo = Person.NationalNo;
            this.FirstName = Person.FirstName;
            this.SecondName = Person.SecondName;
            this.ThirdName = Person.ThirdName;
            this.LastName = Person.LastName;
            this.Email = Person.Email;
            this.PhoneNum = Person.PhoneNum;
            this.Address = Person.Address;
            this.BirthDate = Person.BirthDate;
            this.Gender = Person.Gender;
            this.ImagePath = Person.ImagePath;
            this.CountryID = Person.CountryID;
            Mode = enMode.UpdateMode;
        }

        public static clsPerson Find(int PersonID)
        {
            if (!clsPersonData.IsPersonExistByID(PersonID))
                return null;

            PersonDTO Person = clsPersonData.GetPersonInfoByID(PersonID);
            return Person == null ? null : new clsPerson(Person);
        }
        public static clsPerson Find(string NationalNo)
        {
            if (!clsPersonData.IsPersonExistByNationalNo(NationalNo))
                return null;

            PersonDTO Person = clsPersonData.GetPersonInfoByNationalNo(NationalNo);
            return Person == null ? null : new clsPerson(Person);
        }

        private bool _AddNewPerson()
        {
            PersonDTO Person = new PersonDTO();
            Person.NationalNo = this.NationalNo;
            Person.FirstName = this.FirstName;
            Person.SecondName = this.SecondName;
            Person.ThirdName = this.ThirdName;
            Person.LastName = this.LastName;
            Person.Email = this.Email;
            Person.PhoneNum = this.PhoneNum;
            Person.Address = this.Address;
            Person.BirthDate = this.BirthDate;
            Person.Gender = this.Gender;
            Person.ImagePath = this.ImagePath;
            Person.CountryID = this.CountryID;
            this.ID = clsPersonData.AddNewPerson(Person);
            return this.ID != -1;
        }
        private bool _UpdatePerson()
        {
            PersonDTO Person = new PersonDTO();
            Person.ID = this.ID;
            Person.NationalNo = this.NationalNo;
            Person.FirstName = this.FirstName;
            Person.SecondName = this.SecondName;
            Person.ThirdName = this.ThirdName;
            Person.LastName = this.LastName;
            Person.Email = this.Email;
            Person.PhoneNum = this.PhoneNum;
            Person.Address = this.Address;
            Person.BirthDate = this.BirthDate;
            Person.Gender = this.Gender;
            Person.ImagePath = this.ImagePath;
            Person.CountryID = this.CountryID;
            return clsPersonData.UpdatePerson(Person);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewMode:
                    {
                        if (_AddNewPerson())
                        {
                            Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    return _UpdatePerson();
                default:
                    return false;
            }
        }
        public static bool Delete(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static DataTable GetAllPeopleDetails()
        {
            return clsPersonData.GetAllPeopleDetails();
        }   

    }
}
