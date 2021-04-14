namespace Parser
{
    public class ThreatUnit
    {
        public int id;
        public string name;
        public string description;
        public string source;
        public string objective;
        public bool isPolicy;
        public bool isIntegrity;
        public bool isAvailability;

        public ThreatUnit(int id, string name, string description, string source, string objective, bool isPolicy, bool isIntegrity, bool isAvailability)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.source = source;
            this.objective = objective;
            this.isPolicy = isPolicy;
            this.isIntegrity = isIntegrity;
            this.isAvailability = isAvailability;
        }
    }


}

