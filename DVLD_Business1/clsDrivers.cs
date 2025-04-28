using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;

namespace DVLD_Business1
{
    public class clsDrivers
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { get; private set; }

        public int DriverID { get; private set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public clsPerson PersonInfo
        {
            get
            {
                return clsPerson.Find(this.PersonID);
            }
        }
        public byte ActiveLicensesCount
        {
            get
            {
                return clsDriversData.GetActiveLicensesCount(this.DriverID);
            }
        }

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.MinValue;
            Mode = enMode.AddNew;
        }

        private clsDrivers(DriversDTO dto)
        {
            DriverID = dto.DriverID;
            PersonID = dto.PersonID;
            CreatedByUserID = dto.CreatedByUserID;
            CreatedDate = dto.CreatedDate;
            Mode = enMode.Update;
        }

        public static clsDrivers Find(int driverID)
        {
            DriversDTO dto = clsDriversData.GetDriverByID(driverID);
            return dto == null ? null : new clsDrivers(dto);
        }

        public static clsDrivers FindByPersonID(int personID)
        {
            DriversDTO dto = clsDriversData.GetDriverByPersonID(personID);
            return dto == null ? null : new clsDrivers(dto);
        }

        public bool Save()
        {
            DriversDTO dto = new DriversDTO
            {
                DriverID = this.DriverID,
                PersonID = this.PersonID,
                CreatedByUserID = this.CreatedByUserID,
                CreatedDate = this.CreatedDate
            };

            switch (Mode)
            {
                case enMode.AddNew:
                    this.DriverID = clsDriversData.AddNewDriver(dto);
                    Mode = this.DriverID != -1 ? enMode.Update : enMode.AddNew;
                    return this.DriverID != -1;

                case enMode.Update:
                    return clsDriversData.UpdateDriver(dto);

                default:
                    return false;
            }
        }

        public static bool Delete(int driverID)
        {
            return clsDriversData.DeleteDriver(driverID);
        }

        public static List<clsDrivers> GetAllDrivers()
        {
            List<DriversDTO> driversDTO = clsDriversData.GetAllDrivers();
            List<clsDrivers> driversList = new List<clsDrivers>();

            foreach (DriversDTO dto in driversDTO)
            {
                driversList.Add(new clsDrivers(dto));
            }

            return driversList;
        }
    }
}