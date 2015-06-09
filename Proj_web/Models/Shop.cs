using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj_web.Models
{
    public class Shop
    {    
            // ID магазина
            public int Id { get; set; }
            // название магазина
            public string Name { get; set; }
            // адрес магазина
            public string Address { get; set; }
            // Телефон
            public string Phone { get; set; }
            // Координаты
            public double CoordinatesX { get; set; }
            public double CoordinatesY { get; set; }
            // e-mail
            public string E_mail { get; set; }
            // сайт магазина
            public string in_adress { get; set; }
    }
}