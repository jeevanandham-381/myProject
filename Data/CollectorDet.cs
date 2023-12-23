using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public class CollectorDet
{
    public int Id { get; set; }
    public string DistrictName { get; set; }
    public string DistrictCode { get; set;}
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
    public string Fax { get; set; }
    public string Street { get; set; }
    public string Zipcode { get; set; }
    public string CreateedBy { get; set; }
    public DateTime CreateData { get; set; }
    public DateTime ModifieddData { get; set; }
    public virtual ICollection<Hospital> Hospitals { get; set; }

}
