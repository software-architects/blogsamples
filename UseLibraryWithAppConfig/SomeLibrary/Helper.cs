namespace SomeLibrary
{
	using System.Configuration;

	/// <summary>
	/// Example helper class.
	/// </summary>
	public static class Helper
    {
		/// <summary>
		/// Gets a string which contains some data from appSettings.
		/// </summary>
		/// <returns>Some string including config data.</returns>
		public static string GetSomeValueUsingConfig()
		{
			var someSetting = ConfigurationManager.AppSettings["SomeSetting"];
			return string.Format("The config contains: {0}", someSetting);
		}
    }
}
