namespace BJM.School.UI
{
    public class Student
    {
        // Method 1
        // access is Propfull 'tab'
        //Private Field
        private int id;
		// Public Property 
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        // Method 2 
		// access is Prop 'tab'
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public float GPA { get; set; }

        public void Study()
        {

        }
        private bool CompleteHomework()
        {
            return true;
        }
    }
}
