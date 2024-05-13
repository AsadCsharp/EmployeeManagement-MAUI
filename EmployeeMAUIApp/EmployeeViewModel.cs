using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeMAUIApp
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string employeeId;
        private string employeeName;
        private DateTime joinDate;
        private decimal salary;
        private bool isActive;
        private string imageUrl;

        public string EmployeeId
        {
            get => employeeId;
            set
            {
                employeeId = value;
                NotifyPropertyChanged();
            }
        }
        public string EmployeeName
        {
            get => employeeName;
            set
            {
                employeeName = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime JoinDate
        {
            get => joinDate;
            set
            {
                joinDate = value;
                NotifyPropertyChanged();
            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                NotifyPropertyChanged();
            }
        }
        public string ImageUrl
        {
            get => imageUrl;
            set
            {
                imageUrl = value;
                NotifyPropertyChanged();
            }
        }
    }
}