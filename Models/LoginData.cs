using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.com.Models
{
    public class LoginData : DbContext
    {
        public LoginData(DbContextOptions<LoginData> options) : base(options)
        {

        }

        public DbSet<UserModel> UserModels { get; set; }
    }
}
