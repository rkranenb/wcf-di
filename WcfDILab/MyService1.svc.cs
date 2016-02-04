using System;

namespace WcfDILab {
	
	public class MyService1 : IMyService1 {

		private INameProvider nameProvider;

		public MyService1(INameProvider nameProvider) {
			this.nameProvider = nameProvider;
		}

		public Foo GetFoo() {
			return new Foo { Name = nameProvider.GetName(), When = DateTime.Now };			
		}
	}
}
