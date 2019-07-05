using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            uisng(var context = new GearShopContext(
                serviceProvider.GetRequiredService<DbContextOptions<GearShopContext>>()))
            {

            }
    }
}
