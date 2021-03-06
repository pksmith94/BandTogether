﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BandTogether.Models.Interfaces
{
    public interface IResourceEdit
    {
        int ResourceId { get; set; }
        string TeacherId { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        bool IsDownloadable { get; set; }
        bool IsPublic { get; set; }
        HttpPostedFileBase File { get; set; }
        string FileName { get; set; }
    }
}
