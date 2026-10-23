
using _13_COR.Handlers;
using _13_COR.Models;

ApprovalHandler teacher = new TeacherHandler();
ApprovalHandler department = new DepartmentHandler();
ApprovalHandler director = new DirectorHandler();

teacher.SetNext(department).SetNext(director);

var requests = new List<PurchaseRequest>
{
    new PurchaseRequest("Клавиатура", 3000),
    new PurchaseRequest("Принтер", 8000),
    new PurchaseRequest("Компьютерный класс", 55000),
    new PurchaseRequest("Офисное оборудование", 600000)
};

foreach (var request in requests)
{
    teacher.Handle(request);
}
