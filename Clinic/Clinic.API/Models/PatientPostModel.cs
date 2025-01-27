namespace Clinic.API.Models
{
    public class PatientPostModel
    {
        public string name { get; set; }
        public string phone { get; set; }
        public bool above18 { get; set; }
        public string status { get; set; }
    }
}
