using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    internal class Stage1 {
        private int id;
        private string stage;

        public int Id { get { return id; } set { id = value; } }

        public string StageName { get { return stage; } set { stage = value; } }

        public Stage1(int id, string name) {
            this.id = id;
            this.stage = name;
        }
    }
}
