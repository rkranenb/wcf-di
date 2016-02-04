using System;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace WcfDILab {
	public class StructureMapServiceHostFactory : ServiceHostFactory {

		protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses){
			return new StructureMapServiceHost(serviceType, baseAddresses);			
		}
		
	}
}