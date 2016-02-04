using System;

namespace WcfDILab {

	public interface INameProvider {
		string GetName();
	}

	public class NameProvider : INameProvider {

		private static readonly string[] Names = new[] { 
			"Arjen", 
			"Ionut", 		
			"Maarten", 
			"Robert", 
			"Sebastian", 
			"Tudor" 
		};

		public string GetName() {
			return Names[new Random(DateTime.Now.Millisecond).Next(Names.Length)];
		}
	}
}
