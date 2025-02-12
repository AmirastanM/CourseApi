﻿using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Educations;
using Service.DTOs.Admin.Groups;
using Service.DTOs.Admin.Rooms;
using Service.DTOs.Admin.Students;
using Service.DTOs.Admin.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ForMember(dest => dest.Groups, opt => opt.MapFrom(src =>
                src.GroupStudents.Select(gs => gs.Group)));


            CreateMap<StudentCreateDto, Student>().ForMember(dest => dest.GroupStudents, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new GroupStudent { GroupId = id })));
            CreateMap<StudentEditDto, Student>().ForMember(dest => dest.GroupStudents, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new GroupStudent { GroupId = id })));


            CreateMap<Group, GroupDto>().ForMember(dest => dest.EducationName, opt => opt.MapFrom(src => src.Education.Name))
                .ForMember(dest => dest.RoomName, opt => opt.MapFrom(src => src.Room.Name));
            CreateMap<GroupCreateDto, Group>();
            CreateMap<GroupEditDto, Group>();

            CreateMap<Education, EducationDto>();
            CreateMap<EducationCreateDto, Education>();
            CreateMap<EducationEditDto, Education>();


            CreateMap<Room, RoomDto>();
            CreateMap<RoomCreateDto, Room>();
            CreateMap<RoomEditDto, Room>();

            CreateMap<Teacher, TeacherDto>().ForMember(dest => dest.Groups, opt => opt.MapFrom(src =>
                src.GroupTeachers.Select(gs => gs.Group))); ;
            CreateMap<TeacherCreateDto, Teacher>().ForMember(dest => dest.GroupTeachers, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new GroupTeacher { GroupId = id }))); ;
            CreateMap<TeacherEditDto, Teacher>().ForMember(dest => dest.GroupTeachers, opt => opt.MapFrom(src =>
        src.GroupId.Select(id => new GroupTeacher { GroupId = id }))); ;
        }

    }
}
