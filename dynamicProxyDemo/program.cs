﻿using Autofac;
using Castle.DynamicProxy;
using ConsoleProxy.Proxies;
using Core.Moduls;
using Entities.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy
{
    public class program
    {
       static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultModule());

            var container=builder.Build();
            var willBeIntercepted = container.Resolve<EmployeeManager>();
            willBeIntercepted.Add(new Employee { firstName = "Burak", lastName = "Kesen", id = 1 });


     
        }
    }
}
 