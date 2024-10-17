namespace StudentApp
{
    public class SubjectMarks
    {
        public string SubjectName;
        public int MarksObtained;
        public int MaxMarks;

        public override string ToString()
        {
            return $"Subject: {SubjectName}, Marks Obtained: {MarksObtained}/{MaxMarks}";
        }
    }
}