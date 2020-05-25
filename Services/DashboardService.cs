﻿using DashboardService.Protos;
using DashboardService.Repositories;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Services
{
    public class DashboardService : DashboardDataService.DashboardDataServiceBase //This is your grpc service "dot" Baseclass generated by compiler
    {
        private readonly ILogger<DashboardService> _logger;
        private readonly IDataRepository _dataRepository;

        public DashboardService(ILogger<DashboardService> logger, IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public override Task<TableData> GetTableData(DashboardRequest request, ServerCallContext context)
        {
            TableData tableData = new TableData()
            {
                ResponseTime = DateTime.Now.ToTimestamp()
            };

            try
            {
                if (request.Success == StatusMessage.Success)
                {
                    
                    tableData.Messages.Add(new List<TableRow>());
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return Task.FromResult(tableData);
        }
    }
}