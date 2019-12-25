﻿using Autofac;
using CADKitElevationMarks.Contracts.Services;
using System;

namespace CADKitElevationMarks.Models
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AssignableTo<IMarkTypeService>()
                .InstancePerLifetimeScope()
                .AsImplementedInterfaces();
        }
    }
}
