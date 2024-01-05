namespace StudentStatusApp
{
    internal class StatusChange
    {
        public string From;
        public string To;

        public StatusChange(string to, string from)
        {
            From = from;
            To = to;
        }
    }
}
