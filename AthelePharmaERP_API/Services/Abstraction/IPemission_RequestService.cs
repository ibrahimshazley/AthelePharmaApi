using AthelePharmaERP_API.Models.Entities;
using AthelePharmaERP_API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthelePharmaERP_API.Services.Abstraction
{
    public interface IPemission_RequestService  
    {
        bool AddPermissionRequest(PermissionRequestDTO request);  //Task<PermissionRequestDTO>
        List<HrEmpPermissionRequest> GetAllRequests();
        bool SaveAll();




    }
}
