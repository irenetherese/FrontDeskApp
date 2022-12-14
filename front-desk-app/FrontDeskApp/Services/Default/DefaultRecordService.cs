using FrontDeskApp.Common.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using FrontDeskApp.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System;

namespace FrontDeskApp.Services.Default
{
    public class DefaultRecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IFacilityStorageInfoRepository _facilityStorageInfoRepository;

        public DefaultRecordService(IRecordRepository recordRepository, IFacilityStorageInfoRepository facilityStorageInfoRepository)
        {
            _recordRepository = recordRepository;
            _facilityStorageInfoRepository = facilityStorageInfoRepository;
        }

        public async Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request)
        {
            var records = await _recordRepository.GetAsync();
            var viewModels = records.Select(v => new RecordViewModel
            {
                Id = v.Id,
                CustomerId = v.CustomerId,
                CustomerName = $"{v.Customer.FirstName} {v.Customer.LastName}",
                FacilityId = v.FacilityId,
                FacilityName = v.Facility.Name,
                BoxType =  v.BoxType.ToString(),
                Status = v.Status.ToString(),
                CreatedOn = v.CreatedOnUtc,
                StoredOn = v.StoredOnUtc,
                RetrievedOn = v.RetrievedOnUtc,
                Data = v.Data
            });

            var response = new GetRecordsResponse
            {
                Records = viewModels
            };

            return response;
        }

        public async Task<GetRecordResponse> GetRecordAsync(int recordId)
        {
            var record = await _recordRepository.GetAsync(recordId);
            var viewModel = new RecordViewModel
            {
                Id = record.Id,
                CustomerId = record.CustomerId,
                CustomerName = $"{record.Customer.FirstName} {record.Customer.LastName}",
                FacilityId = record.FacilityId,
                FacilityName = record.Facility.Name,
                BoxType = record.BoxType.ToString(),
                Status = record.Status.ToString(),
                CreatedOn = record.CreatedOnUtc,
                StoredOn = record.StoredOnUtc,
                RetrievedOn = record.RetrievedOnUtc,
                Data = record.Data
            };

            var response = new GetRecordResponse
            {
                Record = viewModel
            };

            return response;
        }

        public async Task<CreateRecordResponse> CreateRecordAsync(CreateRecordRequest request)
        {
            var records = await _recordRepository.GetAsync(
               r => r.FacilityId == request.FacilityId
               && (r.Status == Status.Stored || r.Status == Status.Reserved || r.Status == Status.New)
               && r.BoxType == request.BoxType);

            var facilityInfo = await _facilityStorageInfoRepository.GetAsync(request.FacilityId);
            var facilityCapacity = facilityInfo.FirstOrDefault(f => f.BoxType == request.BoxType).Capacity;

            if (records.Count() < facilityCapacity)
            {
                var record = new Record
                {
                    CustomerId = request.CustomerId,
                    FacilityId = request.FacilityId,
                    BoxType = request.BoxType,
                    Status = request.Status,
                    CreatedOnUtc = request.CreatedOnUtc,
                    StoredOnUtc = null,
                    RetrievedOnUtc = null,
                    Data = request.Data
                };

                var id = await _recordRepository.CreateAsync(record);

                return new CreateRecordResponse
                {
                    Id = id
                };
            }
            else
            {
                return new CreateRecordResponse
                {
                    Id = 0
                };
            }
        }

        public async Task<UpdateRecordResponse> UpdateRecordAsync(int recordId, UpdateRecordRequest request)
        {
            var record = new Record
            {
                Id = recordId,
                CustomerId = request.CustomerId,
                FacilityId = request.FacilityId,
                BoxType = request.BoxType,
                Status = request.Status,
                CreatedOnUtc = request.CreatedOnUtc,
                StoredOnUtc = request.StoredOnUtc,
                RetrievedOnUtc = request.RetrievedOnUtc,
                Data = request.Data
            };

            await _recordRepository.UpdateAsync(record);
            return new UpdateRecordResponse
            {

            };
        }
    }
}
