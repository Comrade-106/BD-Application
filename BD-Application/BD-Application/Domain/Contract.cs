using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    internal abstract class Contract {
        private int idTeam;
        private DateTime dateFrom;
        private DateTime dateTo;
        private double salary;

        public Contract (int idTeam, DateTime dateFrom, DateTime dateTo, double salary) {
            this.idTeam = idTeam;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.salary = salary;
        }
    }
}
