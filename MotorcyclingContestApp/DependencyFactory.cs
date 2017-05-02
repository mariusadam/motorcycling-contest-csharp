using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MotorcyclingContestApp.Client;
using System.Configuration;
using Grpc.Core;
using MotorcyclingContestApp.Domain;
using MotorcyclingContestApp.Forms;

namespace MotorcyclingContestApp
{
    class DependencyFactory
    {
        private static IUnityContainer _container;

        /// <summary>
        /// Public reference to the unity container which will 
        /// allow the ability to register instrances or take 
        /// other actions on the container.
        /// </summary>
        public static IUnityContainer Container
        {
            get { return _container; }
            private set { _container = value; }
        }

        /// <summary>
        /// Static constructor for DependencyFactory which will 
        /// initialize the unity container.
        /// </summary>
        static DependencyFactory()
        {
            var container = new UnityContainer();

            var section = (UnityConfigurationSection) ConfigurationManager.GetSection("unity");
            section?.Configure(container);
            _container = container;
            RegisterTypes();
        }

        private static void RegisterTypes()
        {
            Container.RegisterType<IClientProxy, GrpcClientProxy>(new ContainerControlledLifetimeManager());
            Container.RegisterType<LoginForm>();
            Container.RegisterType<MainForm>();
            Container.RegisterType<Converter>();
            Container.RegisterInstance<Channel>(new Channel("127.0.0.1:50051", ChannelCredentials.Insecure));
        }

        /// <summary>
        /// Resolves the type parameter T to an instance of the appropriate type.
        /// </summary>
        /// <typeparam name="T">Type of object to return</typeparam>
        public static T Resolve<T>()
        {
            T ret = default(T);

            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }

            return ret;
        }
    }
}
