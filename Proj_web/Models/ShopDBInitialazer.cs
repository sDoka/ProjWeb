using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proj_web.Models;

namespace Proj_web.Models
{
    public class ShopDBInitialazer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            db.Shops.Add(new Shop { Name = "Первый", Address = "Спб1", Phone = "1-555-444", CoordinatesX = 59.939188, CoordinatesY = 30.315620 });
            db.Shops.Add(new Shop { Name = "Второй", Address = "Спб2", Phone = "2-555-444", CoordinatesX = 59.959186, CoordinatesY = 30.325622 });

         base.Seed(db);
        }
    }
}