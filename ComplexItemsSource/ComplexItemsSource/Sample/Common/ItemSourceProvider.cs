using Syncfusion.Maui.DataForm;

namespace ComplexItemsSource
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if(sourceName == "Department")
            {
                List<ComplexModel> departmentDetails = new List<ComplexModel>();
                departmentDetails.Add(new ComplexModel() { Name = "Development", DepartmentID = 101 });
                departmentDetails.Add(new ComplexModel() { Name = "HR", DepartmentID = 102 });
                departmentDetails.Add(new ComplexModel() { Name = "Network", DepartmentID = 103 });
                departmentDetails.Add(new ComplexModel() { Name = "Testing", DepartmentID = 104 });
                return departmentDetails;
            }

            return new List<string>();
        }
    }
}