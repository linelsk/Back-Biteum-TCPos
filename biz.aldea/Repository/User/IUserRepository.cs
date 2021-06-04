using biz.premier.Entities;
using Microsoft.AspNetCore.Mvc;

namespace biz.premier.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        string HashPassword(string password);
        bool VerifyPassword(string hash, string password);
        string BuildToken(User user);
        string SendMail(string emailTo, string body, string subject);
        ActionResult get();
        ActionResult userList(int key, int[] users);
        string VerifyEmail(string email);
        ActionResult GetCustom(int? role);
        ActionResult GetUsersInactive();
        ActionResult GetUserData(int key);
        string GetClientName(int key);
        CatRole GetRole(int key);
    }
}
