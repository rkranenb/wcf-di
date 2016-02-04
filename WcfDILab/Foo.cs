using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfDILab {
	[DataContract]
	public class Foo {
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public DateTime When { get; set; }
	}
}