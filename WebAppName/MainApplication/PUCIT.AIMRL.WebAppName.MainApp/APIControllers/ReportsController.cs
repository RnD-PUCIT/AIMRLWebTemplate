﻿using PUCIT.AIMRL.WebAppName.Entities;
using PUCIT.AIMRL.WebAppName.Entities.DBEntities;
using PUCIT.AIMRL.WebAppName.MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace PUCIT.AIMRL.WebAppName.MainApp.APIControllers
{
    public class ReportsController : BaseDataController
    {
        //
        // GET: /Admin/

        private readonly ReportsRepository _repository;

        public ReportsController()
        {
            _repository = new ReportsRepository();
        }
        private ReportsRepository Repository
        {
            get
            {
                return _repository;
            }
        }

        [HttpPost]
        public ResponseResult SearchLoginHistory(LoginHistorySearchParam u)
        {
            return Repository.SearchLoginHistory(u);
        }

        [HttpPost]
        public ResponseResult SearchForgotPasswordLog(ForgotPasswordSearchParam u)
        {
            return Repository.SearchForgotPasswordLog(u);
        }
    }
}