using System;
using System.Collections.Generic;
using System.IO;

namespace RobinAnderson.FileSync.Interfaces
{
    public interface IFileSystem
    {
        IFileSet GetFileSet(string absolutePath);
    }

    public interface IDirectory : IHashed
    {
        string PathFromRoot { get; }
        IEnumerable<IDirectory> Directories { get; }
        IEnumerable<IFile> Files { get; }
    }

    public interface IFile : IHashed
    {
        IDirectory ParentDirectory { get; }
        DateTime LastModifiedUtc { get; }
        string Name { get; }
        Stream Open();
    }

    public interface IFileSet : IHashed
    {
        IDirectory Root { get; }
    }

    public interface IHashed
    {
        byte[] Hash { get; }
    }
}
