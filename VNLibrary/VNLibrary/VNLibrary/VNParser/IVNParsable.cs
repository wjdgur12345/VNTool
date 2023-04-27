using System;
namespace VNLibrary
{
	public interface IVNParsable
	{
		string Stringify();
		object Parse(string _SerializedString);
	}
}

