﻿using System.Collections.ObjectModel;

namespace EmployeeMAUIApp
{
    public class EmployeeListViewModel : ObservableCollection<EmployeeViewModel>
    {
        public void AddSampleDetailifEmpty()
        {
            if (Count == 0)
            {
                Add(new EmployeeViewModel
                {
                    EmployeeId = "001",
                    EmployeeName = "Employee 1",
                    JoinDate = new DateTime(2020, 5, 15),
                    Salary = 100000,
                    IsActive = true,
                    ImageUrl = "",
                });
            }
        }

    }
}