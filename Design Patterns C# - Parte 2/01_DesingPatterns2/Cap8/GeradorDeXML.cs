using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _01_DesingPatterns2.Cap8
{
	public class GeradorDeXML
	{
		public string GeraXML(object o)
		{
			XmlSerializer serializer = new XmlSerializer(o.GetType());
			StringWriter writer = new StringWriter();
			serializer.Serialize(writer, o);
			return writer.ToString();
		}
	}
}
