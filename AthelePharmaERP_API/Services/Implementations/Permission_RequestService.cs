using AthelePharmaERP_API.Models.Entities;
using AthelePharmaERP_API.Models.DTOs;
using AthelePharmaERP_API.Repositories.Abstraction;
using AthelePharmaERP_API.Repositories.IRepositories;
using AthelePharmaERP_API.Services.Abstraction;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthelePharmaERP_API.Services.Implementations
{
    public class Permission_RequestService : IPemission_RequestService
    {
        private readonly IBaseRepository _repo;
        private readonly IMapper _mapper;
        private readonly PharmaERPTestContext _context;


        public Permission_RequestService(PharmaERPTestContext context, IBaseRepository repo ,IMapper mapper)
        {
            _context = context;
            _repo = repo;
            _mapper = mapper;
        }

        public bool AddPermissionRequest(PermissionRequestDTO request) 
        {
            if (request != null)
            {
                HrEmpPermissionRequest PermissionData = new HrEmpPermissionRequest();
                PermissionData.CompanyId = request.CompanyId;
                PermissionData.BranchId = request.BranchId;
                PermissionData.EmpSerialNo = request.EmpSerialNo;
                PermissionData.FromTime = request.FromTime;
                PermissionData.ToTime = request.ToTime;
                PermissionData.Reason = request.Reason;
                PermissionData.PermissionReasonId = request.PermissionReasonId;
                PermissionData.PermissionReasonSubId = request.PermissionReasonSubId;
                PermissionData.PermissionType = request.PermissionType;
                PermissionData.RequestId = request.RequestId;
                PermissionData.TransDate = request.TransDate;
                PermissionData.PermissionDate = request.PermissionDate;
                PermissionData.InsUser = request.InsUser;
                PermissionData.OrderStatus = request.OrderStatus;
                PermissionData.RecNo = request.RecNo;

                _context.HrEmpPermissionRequest.Add(PermissionData);
                return _context.SaveChanges() > 0;

            }
            return false;

            //_mapper.Map(request, PermissionData);
            //return _repo.SaveChanges();

        }

        public List<HrEmpPermissionRequest> GetAllRequests()
        {
            var request = _context.HrEmpPermissionRequest.ToList();
            return request;
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

    }
}
