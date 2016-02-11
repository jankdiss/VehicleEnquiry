using System;
using Microsoft.Practices.Unity;
using VehicleEnquiry.Querying.Query;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Commands;
using VehicleEnquiry.Commands.Handlers;
using VehicleEnquiry.Storage.EventStorage;
using VehicleEnquiry.Domain.Repository;
using VehicleEnquiry.Service.Handlers;
using VehicleEnquiry.Service;
using VehicleEnquiry.Storage;

namespace VehicleEnquiry.Web.UI.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        private static bool _isInitialized;

        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            if (!_isInitialized)
            {
                RegisterTypes(container);
                _isInitialized = true;
            }
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            //IRepository
            container.RegisterType<IEventHandlerFactory, EnqueryEventHandlerFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType<IEventBus, EventBus>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPresistantStorage, FileStorage>(new ContainerControlledLifetimeManager());


            container.RegisterType<IEventStorage, InMemoryEventStorage>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRepository, EnquiryRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICommandHandlerFactory, CommandHandlerFactory>();
            container.RegisterType<IVehicleQuerying, VehicleDataQuery>();
            container.RegisterType<ICommandBus, CommandBus>();
        }
    }
}
