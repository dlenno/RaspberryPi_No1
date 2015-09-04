using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSensor
{
    public partial class Reading
    {
        public System.Guid ReadingId { get; set; }
        public System.Guid BuildingId { get; set; }
        public System.Guid PiId { get; set; }
        public Nullable<double> Bmp180_Temp { get; set; }
        public Nullable<double> Bmp180_Pressure { get; set; }
        public Nullable<double> Sdp610_DeltaP { get; set; }
        public System.DateTime Time { get; set; }

        public virtual Building Building { get; set; }
        
    }

    public partial class Building
    {
        public Building()
        {
            this.Pis = new HashSet<Pi>();
            this.Readings = new HashSet<Reading>();
        }

        public System.Guid BuildingId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Pi> Pis { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
    }

    public partial class Pi
    {
        public System.Guid PiId { get; set; }
        public string Name { get; set; }
        public System.Guid BuildingId { get; set; }

        public virtual Building Building { get; set; }
    }
}
