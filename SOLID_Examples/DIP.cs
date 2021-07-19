using System;

namespace SOLID_Examples
{
	//High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces).
	//Abstractions should not depend on details. Details(concrete implementations) should depend on abstractions.

	#region Bad code
	class DatabaseReader
	{
		public string Read()
		{
			//Read from database
			return "";
		}
	}

	class FileReader
	{
		public string Read()
		{
			//Read from a file
			return "";
		}
	}

	class DataTransfer
	{
		private DatabaseReader _reader;
		public DataTransfer()
		{
			_reader = new DatabaseReader();
		}

		public void TransferData()
		{
			string data = _reader.Read();
			//Transfering the data
		}
	}
	#endregion

	#region Good code
	//interface IReader
	//{
	//	string Read();
	//}

	//class DatabaseReader : IReader
	//{
	//	public string Read()
	//	{
	//		//Read from database
	//		return "";
	//	}
	//}

	//class FileReader : IReader
	//{
	//	public string Read()
	//	{
	//		//Read from a file
	//		return "";
	//	}
	//}

	//class DataTransfer
	//{
	//	private IReader _reader;
	//	public DataTransfer()
	//	{
	//		_reader = Factory.CreateReader();
	//	}

	//	public void TransferData()
	//	{
	//		string data = _reader.Read();
	//		//Transfering the data
	//	}
	//}

	//static class Factory
	//{
	//	public static IReader CreateReader()
	//	{
	//		return new DatabaseReader();
	//	}
	//}
	#endregion
}
