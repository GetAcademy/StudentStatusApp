namespace StudentStatusApp
{
    internal class StudentStatus
    {
        public string CurrentStatus { get; private set; }

        public StudentStatus()
        {
            CurrentStatus = "Har søkt";
        }
    }
}
