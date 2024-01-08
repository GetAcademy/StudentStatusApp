namespace StudentStatusApp
{
    internal class StatusChange
    {
        public string From { get; }
        public string To { get; }

        public StatusChange(string to, string from)
        {
            From = from;
            To = to;
        }
    }
}
