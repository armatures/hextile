using UnityEngine;
namespace Adaptors
{
	public class UnityEngineObject : IUnityEngineObject
	{
		public string name { 
			get{
				return this.obj.name;
			} 
			set{
				this.obj.name = value;
			}}
		private UnityEngine.Object obj { get; set; }
		
		public UnityEngineObject (UnityEngine.Object obj)
		{
			this.obj = obj;
		}
	}
}

public interface IUnityEngineObject {
	string name{ get; set; }
}

public class FakeUnityGameEngineObject : IUnityEngineObject {
	public string name{ get; set; }
}