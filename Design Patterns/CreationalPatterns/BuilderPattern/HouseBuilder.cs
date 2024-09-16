using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalPatterns.BuilderPattern
{
    public class HouseBuilder
    {
        // builder method will have necessary setter methods
        // and a method to pass the object of its own to house
        private House _house = new House();

        public HouseBuilder SetStoryHt(int value)
        {
            _house.storyHt = value;
            return this;
        }

        public HouseBuilder SetRoofType(string value)
        {
            _house.roofType = value;
            return this;
        }

        public HouseBuilder SetDoorType(string value)
        {
            _house.doorType = value;
            return this;
        }

        // build method to pass it to the constructor
        public House Build()
        {
            return _house;
        }
    }
}
