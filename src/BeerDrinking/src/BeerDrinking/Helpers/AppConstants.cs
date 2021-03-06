﻿using System;
using Realms;
using Realms.Sync;

namespace BeerDrinking.Helpers
{
    public static class AppConstants
    {
        // Put constants here that are not of a sensitive nature
        public const string DynamicTabKey = "tab";

        public static RealmConfigurationBase RealmConfiguration
        {
            get
            {
                return RealmConfiguration.Default;
            }
        }
    }
}
