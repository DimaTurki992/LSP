namespace EmployeeLib
{
    public class Managed : Employee
    {
        public Employee Manager { get; set; } = null;

        public virtual void AssignManager(Employee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
    }
}
