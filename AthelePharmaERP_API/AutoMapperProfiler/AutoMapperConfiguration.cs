using AthelePharmaERP_API.Models.Entities;
using AthelePharmaERP_API.Models.DTOs;
using AutoMapper;

namespace CheckTime.AutoMapperProfiler
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<HrEmpPermissionRequest, PermissionRequestDTO>();
            CreateMap<PermissionRequestDTO, HrEmpPermissionRequest>();
            CreateMap<HrEmpPermissionRequest, HrEmpPermissionRequest>();

        }

    }
}
