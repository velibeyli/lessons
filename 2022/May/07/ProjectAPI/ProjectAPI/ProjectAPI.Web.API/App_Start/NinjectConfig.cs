﻿using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using ProjectAPI.Web.API.App_Start;
using ProjectAPI.Web.API.Infrastructure.NinjectModules;
using System;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(NinjectConfig), "Stop")]

namespace ProjectAPI.Web.API.App_Start
{
    public static class NinjectConfig
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();
        
        /// <summary>
        {
        
        /// <summary>

        /// <summary>
            try
        
        /// <summary>
    }
}