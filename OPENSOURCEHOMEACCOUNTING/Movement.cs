using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPENSOURCEHOMEACCOUNTING
{
    public class Movement
    {
        private string _description;
        private double _value;
        private string _period;
        private DateTime _date;

        public string Description { get => _description; set => _description = value; }
        public double Value { get => _value; set => _value = value; }
        public string Period { get => _period; set => _period = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public Movement()
        {
            this.Description = "";
            this.Value = 0.0;
            this.Period = "Once";
            this.Date = DateTime.Today;
        }

        public Movement(string description, double value, string period, DateTime date)
        {
            this.Date = date;
            this.Value = value;
            this.Period = period;
            this.Date = date;
        }

        public Movement(Movement val)
        {
            this.Date = val.Date;
            this.Value = val.Value;
            this.Period = val.Period;
            this.Description = val.Description;
        }
    }
}
