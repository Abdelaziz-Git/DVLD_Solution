using DVLD_DataAccess1;
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business1
{
    public class clsUser
    {
        public enum enMode { AddNewMode = 0, UpdateMode = 1 }
        public enMode Mode = enMode.AddNewMode;

        public int Id { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }
        private byte[] PasswordHash { get; set; }
        private string Salt { get; set; }
        public bool IsActive { get; set; }
        public int Permissions { get; set; }

        public clsUser()
        {
            this.Id = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.Permissions = -1;
            Mode = enMode.AddNewMode;
        }
        private clsUser(UserDTO User)
        {
            this.Id = User.UserID;
            this.PersonID = User.PersonID;
            this.PersonInfo = clsPerson.Find(User.PersonID);
            this.UserName = User.UserName;
            this.PasswordHash = User.PasswordHash;
            this.Salt = User.Salt;
            this.IsActive = User.IsActive;
            this.Permissions = User.Permissions;
            Mode = enMode.UpdateMode;
        }

        public static clsUser Find(int UserID)
        {
            return clsUserData.GetUserInfo(UserID) == null ? null : new clsUser(clsUserData.GetUserInfo(UserID));
        }
        public static clsUser Find(string UserName,string Password)
        {
            return clsUserData.GetUserInfo(UserName,Password) == null ? null : new clsUser(clsUserData.GetUserInfo(UserName,Password));
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            return clsUserData.GetUserInfoByPersonID(PersonID) == null ? null : new clsUser(clsUserData.GetUserInfoByPersonID(PersonID));
        }
        public static bool IsExistByID(int UserID)
        {
            return clsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }
        public static bool IsExistByUsername(string UserName)
        {
            return clsUserData.IsUserNameExists(UserName);
        }
        public static bool IsCorrectPassword(int UserID, string Password)
        {
            return clsUserData.IsCorrectPassword(UserID, Password);
        }
        public static bool ChangePassword(int UserID, string NewPassword)
        {
            return clsUserData.ChangePassword(UserID, NewPassword);
        }
        private bool _AddNewUser()
        {
           
            this.Id = clsUserData.AddNewUser(this.PersonID,this.UserName,this.Password,this.IsActive,this.Permissions);
            return (this.Id != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.Id, this.UserName, this.IsActive, this.Permissions);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewMode:
                    {
                        if (_AddNewUser())
                        {
                            Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    return _UpdateUser();
                default:
                    return false;
            }
        }
        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static DataView GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static DataView GetAllUsersDetails()
        {
            return clsUserData.GetAllUsersDetails();
        }
    }
}
