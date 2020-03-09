namespace StudentExercises
{
    public class Instructor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public Cohort Cohort { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}