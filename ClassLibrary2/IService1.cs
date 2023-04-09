using System.ServiceModel;

namespace ClassLibrary2
    {
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee Employee);

        [OperationContract]
        void DeleteEmployee(int id);

        [OperationContract]
        void Stam();

    }
}
