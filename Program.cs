
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
class Program 
{
    static void Main()
    {

var serviceProvider = new ServiceCollection()
.AddAutoMapper(typeof(StudentProfile))
.BuildServiceProvider();

var mapper = serviceProvider.GetRequiredService<IMapper>();
var student = new Student { Id = 1, FirstName = "Ram", LastName = "Mahajan" };
var studentDto = mapper.Map<StudentDto>(student);
Console.WriteLine($"Id: {studentDto.Id}, FullName: {studentDto.FullName}");
}
}
