using StructureMap;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;


namespace WcfDILab {
	public class StructureMapInstanceProvider : IInstanceProvider {
		
		private readonly Type pluginType;

		private static IContainer Container;
		static StructureMapInstanceProvider() {
			Container = new Container(registry => {
				registry.Scan(scan => {
					scan.TheCallingAssembly();
					scan.WithDefaultConventions();
				});
			});
		}

		public StructureMapInstanceProvider(Type pluginType) {
			this.pluginType = pluginType;
		}

		public object GetInstance(InstanceContext instanceContext, Message message) {
			return Container.GetInstance(pluginType);
		}

		public object GetInstance(InstanceContext instanceContext) {
			return GetInstance(instanceContext, null);
		}

		public void ReleaseInstance(InstanceContext instanceContext, object instance) { }
	}
}