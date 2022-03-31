﻿using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Services
{
   public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
