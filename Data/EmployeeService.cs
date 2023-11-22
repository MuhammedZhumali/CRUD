namespace Aktobe.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Crud

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _context.Employees.ToList();
            return empList;
        }

        public string Create(EmployeeInfo emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return "Save Successfuly";
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo emp = _context.Employees.FirstOrDefault(s=>s.EmployeeId==id);
            return emp;
        }

        public string UpdateEmployee(EmployeeInfo emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteEmployee(EmployeeInfo id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return "Delete Successfully";
        }
    }
}
