﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PZModels;

namespace RestaurantReviews
{
    class SerializeConsole
    {
        static void Main(string[] args)
        {
            FranchiseCollection f = null;
            string path = @"C:\Users\jgrip\Documents\GitHub\GrippoJ_ProjectZero_RestaurantReviews\ProjectZero\RestaurantReviews\ConsoleApp1\franchise.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(FranchiseCollection));

            StreamReader reader = new StreamReader(path);
            f = (FranchiseCollection)serializer.Deserialize(reader);
            reader.Close();

            foreach (Franchise x in f.FranchiseCollectionList)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine(f.FranchiseCollectionList.Count);
            Console.Read();
        }
    }
    [XmlRoot("FranchiseCollection")]
    public class FranchiseCollection
    {
        [XmlArray("Franchises")]
        [XmlArrayItem("Franchise",typeof(Franchise))]
        public List<Franchise> FranchiseCollectionList { get; set; }
    }
}
