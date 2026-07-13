using ZenOS.DAL.Models;
using ZenOS.Util;

namespace ZenOS.BLL.Services
{
    public class DevUserSeeder
    {
        private readonly ZenOsContext _context; // Dùng để truy cập vào DbContext

        public DevUserSeeder(ZenOsContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Users.Any(u => u.Id == Guid.Parse("00000000-0000-0000-0000-000000000001")))
                return;

            var devUser = new User
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Username = "dev",
                Email = "tri.nguyen.sft@gmail.com",
                PasswordHash = PasswordHasher.HashPassword("Dev123!@#"),
            };

            _context.Users.Add(devUser);
            _context.SaveChanges();
        }
    }
}
