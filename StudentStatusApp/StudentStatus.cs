namespace StudentStatusApp
{
    internal class StudentStatus
    {
        public string CurrentStatus { get; private set; }
        private List<string> _statusHistory;

        public StudentStatus()
        {
            _statusHistory = new List<string>();
            ChangeStatus("Har søkt");
        }

        public void ChangeStatus(string newStatus)
        {
            var isValidChange = CurrentStatus == null
                || newStatus == "Levert dokumentasjon" && CurrentStatus == "Har søkt"
                || newStatus == "Fått tilbud" && CurrentStatus == "Levert dokumentasjon"
                || newStatus == "Signert kontrakt" && CurrentStatus == "Fått tilbud"
                || newStatus == "Ikke startet" && CurrentStatus is "Har søkt" or "Levert dokumentasjon" or "Fått tilbud" or "Signert kontrakt"
                || newStatus == "Startet" && CurrentStatus == "Signert kontrakt"
                || newStatus == "Brutt" && CurrentStatus == "Startet"
                || newStatus == "Fullført, ikke bestått" && CurrentStatus == "Startet"
                || newStatus == "Fullført og bestått" && CurrentStatus is "Startet" or "Fullført, ikke bestått"
                || newStatus == "Ikke bestått - ikke flere forsøk igjen" && CurrentStatus == "Fullført, ikke bestått";
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
