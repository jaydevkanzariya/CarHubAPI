﻿using CarHub_Utility;
using CarHub_Web.Models;
using CarHub_Web.Models.Dto;
using CarHub_Web.Models.VM;
using CarHub_Web.Service;
using CarHub_Web.Service.IService;

namespace CarHub_Web.Service
        public Task<T> SetAsync<T>(int imageId, int carId, string token)
        {
            string apiUrl = $"{carUrl}/api/v1/CarImageAPI/{imageId}/{carId}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                // Data = dto,
                Url = apiUrl,
                Token = token
            });
        }