using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class ActivityTypeConverter
    {
        public static ActivityType ToActivityType(string ActivityType)
        {
            using (DataModel context = new DataModel())
            {
                return context.ActivityTypes.FirstOrDefault(x => x.Name == ActivityType);
            }
        }





    }
}
