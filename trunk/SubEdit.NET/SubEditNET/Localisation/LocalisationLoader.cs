using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SubEditNET.Logger;

namespace SubEditNET.Loader
{
    class LocalisationLoader
    {
        static LocalisationLoader instance = null;
        static readonly object padlock = new object();
        DebugLogger logger = DebugLogger.Instance;

        public static LocalisationLoader Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LocalisationLoader();
                    }
                    return instance;
                }
            }
        }
    }
}
