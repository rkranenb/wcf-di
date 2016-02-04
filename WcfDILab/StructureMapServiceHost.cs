using System;
using System.ServiceModel;

namespace WcfDILab {
	public class StructureMapServiceHost : ServiceHost {

		public StructureMapServiceHost(Type serviceType, Uri[] baseAddresses)
			: base(serviceType, baseAddresses) { }

		protected override void OnOpen(TimeSpan timeout) {
			Description.Behaviors.Add(new StructureMapServiceBehavior());
			base.OnOpen(timeout);
		}
	}
}