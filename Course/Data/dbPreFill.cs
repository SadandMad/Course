using Course.Data.mocks;
using Course.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Data
{
    public class dbPreFill
    {
        public static void Initial(AppDBContent content) {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Unit.Any())
            {
                content.AddRange(Units.Select(c => c.Value));
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            /*get {
                if(category == null) {
                    var list = new Category[] {
                        new Category { Name = "HQ", Desc = "Командующие персонажи вашей армии" },
                        new Category { Name = "Troops", Desc = "Ваши основные войска" },
                        new Category { Name = "Elites", Desc = "Особые подразделения" },
                        new Category { Name = "Fast Attack", Desc = "Gonna go FAST" },
                        new Category { Name = "Heavy Support", Desc = "KILL THEM ALL!" }
                    };
                    
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.Name, el);
                }
                return category;
            }*/
            get
            {
                if (category == null)
                {
                    MockCategory temp = null;

                    category = new Dictionary<string, Category>();
                    foreach (Category el in temp.getAllCategories)
                        category.Add(el.Name, el);
                }
                return category;
            }
        }
        private static Dictionary<string, Unit> unit;

        public static Dictionary<string, Unit> Units
        {
            get
            {
                if (unit == null)
                {
                    MockUnits temp = null;

                    unit = new Dictionary<string, Unit>();
                    foreach (Unit el in temp.getUnits)
                        unit.Add(el.Name, el);
                }
                return unit;
            }
        }
    }
}