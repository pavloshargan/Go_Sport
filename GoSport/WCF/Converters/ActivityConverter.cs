﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF.Converters
{
    public static class ActivityConverter
    {
        public static Activity ToActivity(ActivityInfo activity)
        {
            Activity rez = new Activity();
            rez.Route = RouteConverter.ToRoute(activity.Route);
            using (DataModel context = new DataModel())
            {
                foreach (UserInfo us in activity.Users)
                {
                    rez.Users.Add(context.Users.FirstOrDefault(x => x.Login == us.Login));
                }
            }
            rez.Type = ActivityTypeConverter.ToActivityType(activity.Type);
            foreach (ImageInfo im in activity.ActivityImages)
            {
                rez.ActivityImages.Add(ImageConverter.ToImage(im));
            }
            rez.Date = activity.Date;
            return rez;

        }
    }
}