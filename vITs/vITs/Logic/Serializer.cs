﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using vITs.Models;

namespace vITs.Logic
{
    public static class Serializer
    {

        public const string Filename = "trips.xml";
        
        public static void Save(FullTrip fullTrip)
        {            
            var trips = new List<FullTrip>();
            //trips = Load();
            trips.Add(fullTrip);       
            var writer = new XmlSerializer(typeof(List<FullTrip>));
            var file = new StreamWriter(Filename);
            writer.Serialize(file, trips);
            file.Close();
        }

        public static void Overwrite(List<FullTrip> fulltrips)
        {
            var writer = new XmlSerializer(typeof(List<FullTrip>));
            var file = new System.IO.StreamWriter(Filename);
            writer.Serialize(file, fulltrips);
            file.Close();
        }

        public static List<FullTrip> Load()
        {

            var serializer = new XmlSerializer(typeof(List<FullTrip>));
            var reader = new StreamReader(Filename);
            var trips = (List<FullTrip>)serializer.Deserialize(reader);
            reader.Close();
            return trips;

        }

        
    }
}
