﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio_Inventory_API.Models
{
    public class Equipment
    {
        //Need to link to rental model
        private string _RentalDates { get; set; }
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string RentalDates {
            get
            {
                return _RentalDates;
            }
            set
            {
                _RentalDates = _RentalDates + "," + value;
            }
        }

        public ICollection<string> RentalDateList
        {
            get
            {
                return RentalDates.Split(',').ToList();
            }
        }
        public virtual Category Category {get; set;}

        public Equipment()
        {
        }

        public Equipment(int id, string serialNumber, string name, int categoryId, string description)
        {
            Id = id;
            SerialNumber = serialNumber;
            Name = name;
            CategoryId = categoryId;
            Description = description;
        }
    }
}
