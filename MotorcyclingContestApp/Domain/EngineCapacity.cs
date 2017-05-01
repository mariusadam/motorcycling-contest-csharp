namespace MotorcyclingContestApp.Domain
{
    public class EngineCapacity
    {
        public int Id { get; set; }
        public double Capacity { get; set; }

        public override string ToString()
        {
            return Capacity + "Cc";
        }
    }
}
