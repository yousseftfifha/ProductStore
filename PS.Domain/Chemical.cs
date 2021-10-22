namespace PS.Domain
{
    public class Chemical:Product
    {
        public string LabName { get; set; }
        /*public string City { get; set; }

        public string StreetAdress { get; set; }*/
        public Address Address { get; set; }
        public override string GetMyType()
        {
            return "CHEMICAL";
        }
    }
}