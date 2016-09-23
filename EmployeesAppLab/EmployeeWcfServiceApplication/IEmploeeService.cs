using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel.DataAnnotations;



namespace EmployeeWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmploeeService
    {
        [OperationContract]
        IEnumerable<Employee> GetEmployees();

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void InsertEmployee(Employee emp);

        [OperationContract]
        void UpdateEmployee(Employee emp);

        [OperationContract]
        void DeleteEmployee(int id);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {       
        [DataMember]
        

        public int EmployeeId { get; set; }

        [DataMember]
        [Required]
        public string FirstName { get; set;}

        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        
        public int PhNo { get; set; }

        [DataMember]
        [Required]
        public string Technology { get; set; }

        [DataMember]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        [Display(Name ="Date of Joning")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DateOfJoining { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        [DataType(DataType.Date)]
        public DateTime MarketingStartDate { get; set; }

        [DataMember]
        [Required]
        public string Status { get; set; }

        [DataMember]
        public string MarketedBy { get; set; }

    }
}
