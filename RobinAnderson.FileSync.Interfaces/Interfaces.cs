using System;
using System.Collections.Generic;
using System.IO;

namespace RobinAnderson.FileSync.Interfaces
{
    public interface IFile
    {
        /// <summary>
        /// The path of the file from the synchronisation root directory.
        /// </summary>
        string Path { get; }

        DateTime LastModifiedUtc { get; }

        /// <summary>
        /// Opens the file for reading.
        /// </summary>
        Stream Open();
    }

    public interface IHashProvider : IDisposable
    {
        byte[] Hash { get; }

        byte[] SliceHash(long offset, long length);
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
