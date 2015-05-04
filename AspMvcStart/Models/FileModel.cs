using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Data.Common;

namespace AspMvcStart.Models
{
    public class FileModel : IFile
    {

        [ScaffoldColumn(false)]
        public int FileId { get; set; }

        [Required]
        [Display(Name = "File path")]
        public string Path { get; set; }

        public FileModel() : this(null) { }
        public FileModel(IFile file)
        {
            if (file == null)
            {
                FileId = 0;
                Path = string.Empty;
            }
            else
            {
                FileId = file.FileId;
                Path = file.Path;
            }
        }
    }
}