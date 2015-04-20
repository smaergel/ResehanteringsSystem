using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vITs.Models;

namespace vITs.Logic
{
    public static class Serializer
    {
        
        public static void Save(FullTrip fullTrip)
        {
            var Filename = "bajshog.xml";
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(FullTrip));

            var file = new System.IO.StreamWriter(Filename);
            writer.Serialize(file, fullTrip);
            file.Close();
        }
    }
}
