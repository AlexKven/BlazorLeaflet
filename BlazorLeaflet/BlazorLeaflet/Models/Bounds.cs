using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlazorLeaflet.Models
{
    public class Bounds
    {
        [DataMember(Name = "_northEast")]
        public LatLng NorthEast { get; set; }

        [DataMember(Name = "_southWest")]
        public LatLng SouthWest { get; set; }

        public Bounds() { }
        public Bounds(LatLng southWest, LatLng northEast)
        {
            NorthEast = northEast;
            SouthWest = southWest;
        }
    }
}
