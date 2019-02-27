using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace TodoApi.Models
{
    public class RegisterViewModel
    {
        // other properties omitted

        public IFormFile AvatarImage { get; set; }
    }
}