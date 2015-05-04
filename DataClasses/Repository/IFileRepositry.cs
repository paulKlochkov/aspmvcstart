using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data.Common;

namespace Data.Repository
{
    public interface IFileRepositry : IRepository<IFile>
    {
        IFile FindById(int fileId);
    }
}
