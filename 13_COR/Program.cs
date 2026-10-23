
using _13_COR.Handlers;

ApprovalHandler teacher = new TeacherHandler();
ApprovalHandler department = new DepartmentHandler();
ApprovalHandler director = new DirectorHandler();

teacher.SetNext(department);
department.SetNext(director);