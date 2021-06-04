using biz.premier.Entities;
using biz.premier.Repository;
using dal.premier.DBContext;
using CryptoHelper;
using System;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using biz.premier.Models.Email;
using biz.premier.Servicies;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace dal.premier.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private IConfiguration _config;
        private IEmailService _emailservice;

        public UserRepository(Db_PremierContext context, IConfiguration config, IEmailService emailService) : base(context)
        {
            _config = config;
            _emailservice = emailService;
        }

        public string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }

        public string BuildToken(User user)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public bool VerifyPassword(string hash, string password)
        {
            return Crypto.VerifyHashedPassword(hash, password);
        }

        public override User Add(User user)
        {
            user.Password = HashPassword(user.Password);
            return base.Add(user);
        }

        public override User Update(User user, object id)
        {
            user.UpdatedDate = DateTime.Now;
            return base.Update(user, id);
        }

        public string SendMail(string emailTo, string body, string subject)
        {
            EmailModel email = new EmailModel();
            email.To = emailTo;
            email.Subject = subject;
            email.Body = body;
            email.IsBodyHtml = true;

            return _emailservice.SendEmail(email);

        }

        public ActionResult get()
        {
            var item = (from a in _context.WorkOrders
                        select new
                        {
                            a.Id,
                            standalone = a.StandaloneServiceWorkOrders.Where(x => x.ServiceTypeId == 2).ToList(),
                            buncled = a.BundledServicesWorkOrders.ToList()
                        });
            return new ObjectResult(item);
        }

        public ActionResult userList(int key, int[] users)
        {
            var query = _context.Set<User>().Where(x => x.Id != key && !users.Contains(x.Id)).Select(s => new
            {
                s.Id,
                name = $"{s.Name} {s.LastName} {s.MotherLastName}",
                immigration = s.ProfileUsers.FirstOrDefault().Immigration,
                Relocation = s.ProfileUsers.FirstOrDefault().Relocation,
            }).ToList();
            return new ObjectResult(query);
        }

        public string VerifyEmail(string email)
        {
            var result = "";

            if (_context.Users.SingleOrDefault(x => x.Email.ToLower().Trim() == email.ToLower().Trim()) != null)
            {
                result = "Exist";
            }
            else
            {
                result = "No Exist";
            }

            return result;
        }

        public ActionResult GetCustom(int? role)
        {
            var usersList = _context.ProfileUsers.Where(x => x.User.Status == true || !x.User.Status.HasValue).Select(s => new
            {
                s.Id,
                s.UserId,
                name = $"{s.Name} {s.LastName} {s.MotherLastName}",
                office = s.ResponsablePremierOfficeNavigation.Office,
                country = s.CountryNavigation.Name,
                title = s.TitleNavigation.Title,
                s.User.Role.Role,
                s.CreatedDate,
                s.User.RoleId
            }).ToList();
            
            var usersAssignee = _context.AssigneeInformations.Where(x => x.User.Status == true || !x.User.Status.HasValue).Select(s => new
            {
                s.Id,
                s.UserId,
                name = s.AssigneeName,
                office = "-",
                country = s.HostCountryNavigation.Name,
                title = "-",
                s.User.Role.Role,
                s.CreatedDate,
                s.User.RoleId
            }).ToList();
            var users = usersList.Union(usersAssignee).ToList();
            if (role.HasValue)
            {
                switch (role.Value)
                {
                    case 1:
                        users = users.Where(x => x.RoleId == 1 || x.RoleId == 2).ToList();
                        break;
                    case 2:
                        users = users.Where(x => x.RoleId == 3).ToList();
                        break;
                    case 3:
                        users = users.Where(x => x.RoleId != 1 || x.RoleId != 2 || x.RoleId != 3 || x.RoleId != 4).ToList();
                        break;
                    case 4:
                        users = users.Where(x => x.RoleId == 4).ToList();
                        break;
                    default:
                        users = users.ToList();
                        break;
                }
                
            }
            return new ObjectResult(users);
        }

        public ActionResult GetUsersInactive()
        {
            var usersList = _context.ProfileUsers.Where(x => x.User.Status == false).Select(s => new
            {
                s.Id,
                s.UserId,
                name = $"{s.Name} {s.LastName} {s.MotherLastName}",
                office = s.ResponsablePremierOfficeNavigation.Office,
                country = s.CountryNavigation.Name,
                title = s.TitleNavigation.Title,
                s.User.Role.Role,
                s.CreatedDate,
                s.User.RoleId
            }).ToList();
            
            var usersAssignee = _context.AssigneeInformations.Where(x => x.User.Status == false).Select(s => new
            {
                s.Id,
                s.UserId,
                name = s.AssigneeName,
                office = "-",
                country = s.HostCountryNavigation.Name,
                title = "-",
                s.User.Role.Role,
                s.CreatedDate,
                s.User.RoleId
            }).ToList();         
            var users = usersList.Union(usersAssignee).ToList();

            return new ObjectResult(users);
        }

        public ActionResult GetUserData(int key)
        {
            var usersList = _context.ProfileUsers.Select(s => new
            {
                s.Id,
                s.Photo,
                s.UserId,
                s.Name,
                s.LastName,
                s.MotherLastName,
                s.Country,
                s.City,
                office = s.ResponsablePremierOffice,
                s.Title,
                role = s.User.RoleId,
                phone = s.PhoneNumber,
                s.Email,
                s.CreatedDate
            }).SingleOrDefault(s => s.Id == key);
            return new ObjectResult(usersList);
        }

        public string GetClientName(int key)
        {
            var client = _context.ServiceRecords.Where(x => x.AssigneeInformations.FirstOrDefault().Id == key)
                .Select(s => s.Client.Name).FirstOrDefault();
            return client;
        }

        public CatRole GetRole(int key)
        {
            var role = _context.CatRoles
                .Include(x => x.Permissions)
                .SingleOrDefault(x => x.Id == key);
            return role;
        }
    }
}
