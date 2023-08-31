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

        public string FullName {
            get { return FirstName + ", " + LastName; }
        }

        public float GPA { get; set; }


        public void Study()
        {
            // create an instanc of the course class which is an object
            // Method 1
            Course course = new Course();

            // Method 2

            Course course2;
            course2 = new Course();

            // set the property values
            // Method 1
            // object + property = value 
            course.Name = "ASP.Bet";
            course.ID = 123456789;

            //method 2

            course2 = new Course { ID = 2, Name = "Mobile Dev" };


            // get data from an object
            string name = course2.Name;
            int id = course.ID;

        }
        private bool CompleteHomework()
        {
            return true;
        }
    }
}
