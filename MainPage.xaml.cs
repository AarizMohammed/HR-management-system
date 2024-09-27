namespace W4B_HR_Example;

public partial class MainPage : ContentPage
{
	private Company _company = new Company();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//Company company = new Company();

		Employee employee = new Employee
		{
			Name = NameEntry.Text,
			Email = EmailEntry.Text,
			Salary = double.Parse(SalaryEntry.Text)
		};
		bool result = _company.AddEmployee(employee);

		if (result)
			DisplayAlert("Information", $"Employee added with {employee.Id}", "Ok");
		else
            DisplayAlert("Error", $"Email is already used!", "Ok");

    }

    void ShowAverageBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Information",
					  $"Salary average is ${_company.GetAverageSalary()}", "Ok");

    }

    void ShowEmployeeWithHighestSalary_Clicked(System.Object sender, System.EventArgs e)
    {
		Employee employee = _company.GetEmployeeWithHighestSalary();
		if (employee == null)
            DisplayAlert("Error", $"No body works here", "Ok");
		else
            DisplayAlert("Error", $"{employee.Name}", "Ok");


    }
}


