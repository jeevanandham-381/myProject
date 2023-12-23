using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public class Hospital
{
    public int Id { get; set; }
    public int CollectorDetId { get; set; }
    public virtual CollectorDet CollectorDet { get; set; }
    public string HospitalName { get; set; }
    public string HospitalCode { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public string Email { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
    public int StatusLid { get; set; }
    public string CreateedBy { get; set; }
    public DateTime CreateData { get; set; }
    public DateTime ModifieddData { get; set; }
}
