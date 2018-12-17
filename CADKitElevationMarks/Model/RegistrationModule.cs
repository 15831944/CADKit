﻿using Autofac;
using CADKitElevationMarks.Contract;
using System;

namespace CADKitElevationMarks.Model
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AssignableTo<IElevationMarkFactory>()
                .InstancePerLifetimeScope()
                .AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AssignableTo<IElevationMarkConfig>()
                .InstancePerLifetimeScope()
                .AsImplementedInterfaces();
        }
    }
}
