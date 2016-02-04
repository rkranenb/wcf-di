using StructureMap;
using System;

namespace WcfDILab {

	public static class IoC {

		public static IContainer Container {
			get { return GetOrCreateContainer(); }
		}

		private static IContainer ObjectContainer;
		private static object MutEx = new object();

		private static IContainer GetOrCreateContainer() {
			if (ObjectContainer == null) {
				lock (MutEx) {
					if (ObjectContainer == null) {
						ObjectContainer = new Container(registry => {
							registry.Scan(scan => {
								scan.TheCallingAssembly();
								scan.WithDefaultConventions();
							});
						});
					}
				}
			}
			return ObjectContainer;
		}	

		
	}
}