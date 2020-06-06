using System.IO;
using System.Reflection;
using BulkMailSender.Components;
using BulkMailSender.Core;
using Ninject.Modules;

namespace BulkMailSender
{
  public class ApplicationModule : NinjectModule
  {
    public override void Load()
    {
      var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

      Bind<IAppRepository>().To<AppRepository>().InTransientScope()
        .WithConstructorArgument("dbPath",path);

      Bind<IAppService>().To<AppService>().InThreadScope();

      // Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
    }
  }
}