using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.ORM;
using Web_Api_Infrastructure.Repository;
using Web_Api_Infrastructure.Service;
using Web_Api_Infrastructure.UniofWork;
using Web_App.ORM;

namespace Web_Api_Infrastructure
{
    public class InfrastructureModule:Module
    {
        public readonly string? _connnectionstring;
        public readonly string? _assembly;
        public InfrastructureModule(string? Connectionstring, string? Assembly)
        {
            _connnectionstring = Connectionstring;
            _assembly = Assembly;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("Assembly", _assembly)
                .WithParameter("Connectionstring",_connnectionstring)
                .InstancePerLifetimeScope();
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("Assembly", _assembly)
                .WithParameter("Connectionstring", _connnectionstring)
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitofWork>().InstancePerLifetimeScope();
            builder.RegisterType<ApplicationUnitofWork>().As<IApplicationUnitofWork>().InstancePerLifetimeScope();
            builder.RegisterType<RegionService>().As<IRegionService>().InstancePerLifetimeScope();
            builder.RegisterType<WalkRepository>().As<IWalkRepository>().InstancePerLifetimeScope();
            builder.RegisterType<WalkService>().As<IWalkService>().InstancePerLifetimeScope();
            builder.RegisterType<WalkDifficultyService>().As<IWalkDifficultyService>().InstancePerLifetimeScope();

            builder.RegisterType<Regionrepository>().As<IRegionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<WalkRepository>().As<IWalkRepository>().InstancePerLifetimeScope();
            builder.RegisterType<WalkDifficultyRepository>().As<IWalkdifficultyRepository>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
