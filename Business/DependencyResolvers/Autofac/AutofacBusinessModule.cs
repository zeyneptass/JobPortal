using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<RoleManager>().As<IRoleService>().SingleInstance();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>().SingleInstance();

            builder.RegisterType<JobTypeManager>().As<IJobTypeService>().SingleInstance();
            builder.RegisterType<EfJobTypeDal>().As<IJobTypeDal>().SingleInstance();

            builder.RegisterType<JobSeekerManager>().As<IJobSeekerService>().SingleInstance();
            builder.RegisterType<EfJobSeekerDal>().As<IJobSeekerDal>().SingleInstance();

            builder.RegisterType<JobListingManager>().As<IJobListingService>().SingleInstance();
            builder.RegisterType<EfJobListingDal>().As<IJobListingDal>().SingleInstance();

            builder.RegisterType<EmployerManager>().As<IEmployerService>().SingleInstance();
            builder.RegisterType<EfEmployerDal>().As<IEmployerDal>().SingleInstance();

            builder.RegisterType<ApplicationStatusManager>().As<IApplicationService>().SingleInstance();
            builder.RegisterType<EfApplicationStatusDal>().As<IApplicationStatusDal>().SingleInstance();

            builder.RegisterType<ApplicationManager>().As<IApplicationService>().SingleInstance();
            builder.RegisterType<EfApplicationDal>().As<IApplicationDal>().SingleInstance();
                
        }
    }
}
