using Model.Dto;
using Model.Model;


namespace BL.Managers.Interfaces
{
    public interface IUserManager
    {
        UserDisplayDto CreateUser(UserRegisterDto user);
        User FindUser(string userName, string password);
    }
}

