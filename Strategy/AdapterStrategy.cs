using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileController
    {
        IFileStorage filestorage;
        public FileController(IFileStorage filestorage) => this.filestorage = filestorage;
    }


    public interface IFileStorage
    {
        byte[] GetFile(string id);
        void SaveFile();
    }

    public class LocalFileStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            return new byte[] { 1, 0 };
        }
        public void SaveFile()
        {

        }
    }

    public class AWSFileStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            return new byte[] { 1, 1 };
        }
        public void SaveFile()
        {

        }
    }

}
