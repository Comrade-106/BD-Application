using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    public abstract class Contract {
        private int idTeam;
        private DateTime dateFrom;
        private DateTime dateTo;
        private double salary;

        public int IdTeam { get { return idTeam; } set { idTeam = value; } }
        public DateTime DateFrom { get { return dateFrom; } set { dateFrom = value; } }
        public DateTime DateTo { get { return dateTo; } set { dateTo = value;} }
        public double Salary { get { return salary; } set { salary = value;} }

        public Contract (int idTeam, DateTime dateFrom, DateTime dateTo, double salary) {
            this.idTeam = idTeam;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.salary = salary;
        }
    }
}
