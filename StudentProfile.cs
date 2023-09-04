using AutoMapper;
public class StudentProfile : Profile
{
     public StudentProfile()
     {
          CreateMap<Student,StudentDto>()
          .ForMember(
            destinationProperty => destinationProperty.FullName,
            options => options.MapFrom(source => $"{source.FirstName}{source.LastName}" )
          );
     }
}