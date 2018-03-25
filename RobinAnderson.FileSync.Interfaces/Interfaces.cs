using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinAnderson.FileSync.Interfaces
{
    public interface IFile
    {
        /// <summary>
        /// The path of the file from the synchronisation root directory.
        /// </summary>
       string Path { get; }

        DateTime LastModifiedUtc { get; }

        IHashMap HashMap { get; }
    }

    public interface IHashMap
    {
        byte[] Hash { get; }

        IHashMap Slice(long offset, long length);
    }


    public interface IFileSystem
    {
        IDirectory GetDirectory(string absolutePath);
    }

    public interface IDirectory
    {
        string Name { get; }
        IEnumerable<IDirectory> GetDirectories();
        IEnumerable<IFile> GetFiles();
    }

    public interface ICrytoHasher
    {
        
    }

    public interface IFileManifest
    {
        
    }
}
