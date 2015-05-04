using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace AspMvcStart
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private static void AddBindingsToKernel(IKernel kernel)
        {
            if (kernel == null)
            {
                throw new ArgumentNullException("kernel");
            }
            //TODO write bindings here
            kernel.Bind<Data.Repository.IFileRepositry>().To<Data.Repository.StubFileRepositry>().InSingletonScope();
        }

        public static void RegisterNinjectDependencyResolver()
        {
            IDependencyResolver ninjectDependencyResolver = new NinjectDependencyResolver();
            DependencyResolver.SetResolver(ninjectDependencyResolver);
        }

        private IKernel _kernel = new StandardKernel();

        public NinjectDependencyResolver()
        {
            AddBindingsToKernel(_kernel);
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}