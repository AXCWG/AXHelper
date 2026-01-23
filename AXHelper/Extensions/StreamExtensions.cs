using Microsoft.AspNetCore.Http;

namespace AXHelper.Extensions;

public static class StreamExtensions
{
    /// <param name="anyStream" >Must be Stream or IFormFile</param>
    extension<T>(T anyStream)
    {
        
        /// <remarks>
        /// ONLY ACT ON Stream or IFormFile<br/><br/>
        /// </remarks>
        /// <summary>
        /// Set pos to 0, copy all data to memStream, convert to arr then set pos to original. 
        /// </summary>
        /// <returns>The byte array in byte[]</returns>
        /// <exception cref="InvalidOperationException">When the anyStream is neither IFormFile nor Stream. </exception>
        public byte[] ReadToByteArray()
        {
            if (typeof(T) == typeof(Stream))
            {
                
                using var memStream = new MemoryStream();
                var pos = (anyStream as Stream)!.Position;
                (anyStream as Stream)!.Position = 0; 
                (anyStream as Stream)!.CopyTo(memStream);
                (anyStream as Stream)!.Position = pos; 
                return memStream.ToArray();
            }
            if (typeof(T) == typeof(IFormFile))
            {
                
                using var memStream = new MemoryStream();
                (anyStream as IFormFile)!.CopyTo(memStream);
                return memStream.ToArray();
            }

            throw new InvalidOperationException();
        }
    }
}