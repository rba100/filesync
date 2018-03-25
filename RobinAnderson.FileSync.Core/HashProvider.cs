using System.IO;
using System.Security.Cryptography;

using RobinAnderson.FileSync.Interfaces;

namespace RobinAnderson.FileSync.Core
{
    public class HashProvider : IHashProvider
    {
        private readonly Stream m_Stream;
        private readonly HashAlgorithm m_Hash;

        private byte[] m_HashCache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream">The byte stream to hash. HashProvider will dispose of this stream.</param>
        public HashProvider(Stream stream, HashAlgorithm hash)
        {
            m_Stream = stream;
            m_Hash = hash;
        }

        public byte[] Hash
        {
            get
            {
                if (m_HashCache == null)
                {
                    InitHash();
                }
                return m_HashCache;
            }
        }

        public byte[] SliceHash(long offset, long length)
        {
            m_Hash.Initialize();
            m_Hash.ComputeHash()
        }

        public void Dispose()
        {
            m_Stream?.Dispose();
            m_Hash.Dispose();
        }

        private void InitHash()
        {
            m_Stream.Seek(0, SeekOrigin.Begin);
            m_HashCache = m_Hash.ComputeHash(m_Stream);
        }
    }
}
