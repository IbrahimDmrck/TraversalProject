﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models
{
    public class MailRequest
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string RecieverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}
