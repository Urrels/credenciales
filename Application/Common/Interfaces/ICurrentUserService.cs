using Domain.Enums;
using System.Collections.Generic;

namespace Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int? UserId { get; }

        public string FirstName { get; }
        
        public string LastName { get; }

        string UserEmail { get; }

        string Token { get; }

        public ERoleUser EUserType { get; }

        public int? GetAnonymousId();
        public int? GetSystemId();
        public List<UserDetail> GetUsersFromConfig();
    }

    public class UserDetail
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int? AspNetId { get; set; }
        public string UserName { get; set; }
    }
}