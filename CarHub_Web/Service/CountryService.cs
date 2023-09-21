﻿



using CarHub_Utility;
using CarHub_Web.Models;
using CarHub_Web.Models.Dto;
using CarHub_Web.Service.IService;

namespace CarHub_Web.Service
			carUrl = configuration.GetValue<string>("ServiceUrls:CarAPI");

		}
        public Task<T> GetCountryData<T>(int pageNum, string token)
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/GetCountryData?pageNum={pageNum}";

        }
        public Task<T> CountryByPagination<T>(string term, string orderBy, int currentPage, string token)
        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{carUrl}/api/v1/CountryAPI/CountryByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = apiUrl,
                Token = token
            });

        }