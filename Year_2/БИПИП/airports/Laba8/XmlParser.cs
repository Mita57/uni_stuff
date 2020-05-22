using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace Laba8
{
    public class XmlParser
    {
        protected DataSet ds = new DataSet();
        protected XElement xEl;
        protected object[] southern;
        protected object[] southAlaska;

        public XmlParser()
        {
            ds.ReadXml("UsAirport.xml");
            xEl = XElement.Load("UsAirport.xml");
            southern = GetSouthernAirpots();
            southAlaska = GetSouthAirpotsAndAlaska();
        }

        public DataTable XML
        {
            get { return ds.Tables[0]; }
        }

        public object[] South
        {
            get { return southern; }
        }

        public object[] SouthAlaska
        {
            get { return southAlaska; }
        }

        protected object[] GetSouthernAirpots()
        {
            string latitude = "S";
            int degree = 0;

            var s = xEl.Elements().Where(i => int.Parse(i.Element("LatitudeDegree").Value) >= degree)
                                  .Where(i => i.Element("LatitudeNpeerS").Value == latitude)
                                  .OrderByDescending(i => int.Parse(i.Element("RunwayLengthFeet").Value))
                                  .Select(x => new
                                                  {
                                                      CityOrAirportName = x.Element("CityOrAirportName").Value,
                                                      RunwayLengthFeet = x.Element("RunwayLengthFeet").Value,
                                                      LatitudeDegree = x.Element("LatitudeDegree").Value,
                                                      LatitudeNpeerS = x.Element("LatitudeNpeerS").Value
                                                  })
                                  .Distinct()
                                  .Take(10)
                                  .ToArray();
            return s;
        }

        protected object[] GetSouthAirpotsAndAlaska()
        {
            var s = xEl.Elements().Where(i => int.Parse(i.Element("CountryCode").Value) == 1
                                           && i.Element("LatitudeNpeerS").Value == "N" 
                                           || i.Element("LatitudeNpeerS").Value == "S")
                                  .Select(x => new
												  {
													  CityOrAirportName = x.Element("CityOrAirportName").Value,
													  LatitudeDegree = x.Element("LatitudeDegree").Value,
													  LongitudeDegree = x.Element("LongitudeDegree").Value,
													  LatitudeNpeerS = x.Element("LatitudeNpeerS").Value
												  })
                                  .Distinct()
                                  .ToArray();
            return s;
        }

        public object[] ByCoords(int coords)
        {
            var s = xEl.Elements().Where(i => int.Parse(i.Element("LatitudeDegree").Value) > coords
                                                     && i.Element("LatitudeNpeerS").Value == "N")
                                  .Select(x => new
												  {
													  CityOrAirportName = x.Element("CityOrAirportName").Value,
													  LatitudeDegree = x.Element("LatitudeDegree").Value,
													  LongitudeDegree = x.Element("LongitudeDegree").Value,
													  LatitudeNpeerS = x.Element("LatitudeNpeerS").Value
												  })
                                  .Distinct()
                                  .Take(20)
                                  .ToArray();
            return s;
        }
    }
}
