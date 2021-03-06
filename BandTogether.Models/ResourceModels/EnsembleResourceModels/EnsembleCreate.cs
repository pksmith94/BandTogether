﻿using BandTogether.Data.Entities.Enumerations;
using BandTogether.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BandTogether.Models.ResourceModels.EnsembleResourceModels
{
    public class EnsembleCreate : IResourceCreate
    {
        private bool _isDownloadable;
        private bool _isPublic;

        public string TeacherId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Let others download?")]
        public bool EnsembleIsDownloadable
        {
            get => _isDownloadable;
            set
            {
                _isDownloadable = value;
            }
        }

        public bool IsDownloadable
        {
            get => _isDownloadable;
            set
            {
                _isDownloadable = value;
            }
        }

        [Display(Name = "Make it public?")]
        public bool EnsembleIsPublic
        {
            get => _isPublic;
            set
            {
                _isPublic = value;
            }
        }

        public bool IsPublic
        {
            get => _isPublic;
            set
            {
                _isPublic = value;
            }
        }

        [Required]
        [Display(Name = "File")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase File { get; set; }

        [Required]
        [EnumDataType(typeof(EnsembleType))]
        public EnsembleType Ensemble { get; set; }

        [Required]
        [EnumDataType(typeof(MusicalSkill))]
        public MusicalSkill Skill { get; set; }

        [Required]
        [Display(Name = "Grade Level")]
        [Range(4, 12)]
        public int GradeLevel { get; set; }
    }
}
