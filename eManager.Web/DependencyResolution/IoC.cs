using eManager.Web.Infrastructure;
using eManger.Domain;
using StructureMap;
namespace eManager.Web.DependencyResolution {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentDataStore>().HttpContextScoped().Use<DepartmentDB>();
                        });
            return ObjectFactory.Container;
        }
    }
}