using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobinAnderson.FileSync.Interfaces;

namespace RobinAnderson.FileSync.Core
{
    public interface IFileSetComparer
    {
        IComparisonReport Compare(IFileSet source, IFileSet target);
    }

    public interface IComparisonReport
    {
        IReadOnlyCollection<IFile> FilesOnlyInSource
    }
}
