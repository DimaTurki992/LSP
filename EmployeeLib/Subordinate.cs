namespace EmployeeLib
{
    public class Subordinate : Employee
    {
        public Manager Manager { get; set; } = null;

        public virtual void AssignManager(Manager manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
    }
}
