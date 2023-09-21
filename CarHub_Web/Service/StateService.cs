﻿
using CarHub_Web.Models;
using CarHub_Web.Models.Dto;
using CarHub_Web.Service.IService;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.Design;

namespace CarHub_Web.Service
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}
        public Task<T> AllDataAsync<T>(string term, string orderBy, int currentPage, string token)
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData?term={term}&orderBy={orderBy}&currentPage={currentPage}";
        
