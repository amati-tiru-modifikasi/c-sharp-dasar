using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic_c_sharp
{
    public class Planet
    {
        // field
        private int _id;
        public string Name { get; set; }

        private int _radius;
        public int Radius { 
            get { return _radius; } 
            set { _radius = value; }
        }

        // Generic Collection
        private List<string> _satelites =  new();

        // Constructor
        public Planet(int id){
            _id = id;
        }

        // Method
        public int GetTempratureId(){
            return new Random().Next(-200,200);
        }

        // Method
        public void AddSatelite(string name) {
            _satelites.Add(name);
        }

        // Print
        public void PrintInfo() {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string planetInfo = $"Planet ID: {_id}" + Environment.NewLine;
            planetInfo += $"Name: {Name}" + Environment.NewLine;
            planetInfo += $"Radius: {_radius}" + Environment.NewLine;
            planetInfo += $"{Name} has {_satelites.Count} satellites(s)" + Environment.NewLine;
            return planetInfo;
        }

    }
}