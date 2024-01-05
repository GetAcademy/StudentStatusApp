namespace StudentStatusApp
{
    internal class StudentStatus2
    {
        public string CurrentStatus { get; private set; }
        private List<string> _statusHistory;
        private List<StatusChange> _validStatusChanges;

        public StudentStatus2()
        {
            _validStatusChanges = new List<StatusChange>
            {
                new ("Levert dokumentasjon", "Har søkt"),
                new ("Fått tilbud","Levert dokumentasjon"),
                new ("Signert kontrakt", "Fått tilbud"),
                new ("Ikke startet", "Har søkt"),
                new ("Ikke startet", "Signert kontrakt"),
                new ("Ikke startet", "Levert dokumentasjon"),
                new ("Ikke startet", "Fått tilbud"),
                new ("Startet" , "Signert kontrakt"),
                new ("Brutt" ,"Startet"),
                new ("Fullført, ikke bestått" ,  "Startet"),
                new ("Fullført og bestått", "Startet" ),
                new ("Fullført og bestått", "Fullført, ikke bestått"),
                new ("Ikke bestått - ikke flere forsøk igjen" , "Fullført, ikke bestått"),
            };
            _statusHistory = new List<string>();
            ChangeStatus("Har søkt");
        }

        public void ChangeStatus(string newStatus)
        {
            var isValidChange = _validStatusChanges.Any(vsc => vsc.From == CurrentStatus && vsc.To == newStatus);
            if (!isValidChange) return;
            CurrentStatus = newStatus;
            _statusHistory.Add(newStatus);
        }

        public bool HasHadStatus(string status)
        {
            return _statusHistory.Contains(status);
        }
    }
}