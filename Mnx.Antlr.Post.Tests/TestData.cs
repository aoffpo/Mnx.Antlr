using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mnx.Antlr.Post.Listeners.Models;

namespace Mnx.Antlr.Post.Tests
{
    public static class TestData
    {
        public static Location BasicLocation()
        {
            return new Location()
            {
                Address = "214 Hunt St",
                City = "Durham",
                Region = String.Empty,
            };
        }

        public static PostData BasicData()
        {
            return new PostData
            {
                StartDate = DateTime.Now,
                Location = BasicLocation()
            };
        }
    }
}
