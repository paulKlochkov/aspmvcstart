using Data.Common;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class StubFileRepositry : IFileRepositry
    {
        private List<IFile> _files = new List<IFile>();
        public StubFileRepositry()
        {
            _files = new List<IFile>();
        }
        public Common.IFile FindById(int fileId)
        {
            return _files.FirstOrDefault(x => x.FileId == fileId);
        }

        public void Save(Common.IFile entity)
        {
            _files.Add(entity);
        }

        public void Remove(Common.IFile entity)
        {
            _files.Remove(entity);
        }

        public ICollection<Common.IFile> GetAll()
        {
            return _files;
        }

        public void Update(Common.IFile entity)
        {
            _files.Remove(entity);
            _files.Add(entity);
        }

        public IFile CreateNew()
        {
            IFile fileEntity = new FileEntity();
            _files.Add(fileEntity);
            return fileEntity;
        }
    }
}
