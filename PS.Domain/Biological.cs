using System.Reflection.Metadata;

namespace PS.Domain
{
    public class Biological:Product
    {
        public string Herbs { get; set; }
        public override string GetMyType()
        {
            return "BIOLOGICAL";
        }
    }
}