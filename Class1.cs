using System;

namespace MappingGeneratorTest
{
	public class Class1: Persistent
	{
		public string TempFlagRd { get; set; }
		public int? DocumentLegacyId { get; set; }
		public int? RegulationLegacyId { get; set; }
		public int? CountryId { get; set; }
		public string TitleShort { get; set; }
		public string OfficialTitle { get; set; }

		public Class1 Clone()
		{
			return new Class1
			       {

			       };
		}
	}

	public class Persistent { }
}