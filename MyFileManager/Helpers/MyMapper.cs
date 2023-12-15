using MyFileManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileManager.Helpers
{
    public static class MyMapper
    {
        /// <summary>
        /// Mapuje obiekt DirectoryInfo na obiekt MyDirectoryItem
        /// </summary>
        /// <param name="directoryInfo"></param>
        /// <returns></returns>
        public static MyDirectoryItem MapDirectorySystemItem(DirectoryInfo directoryInfo, DirectorySystemItemType itemType = DirectorySystemItemType.Null)
        {
            if (directoryInfo == null)
                return null;
            return new MyDirectoryItem
            {
                CreationDate = directoryInfo.CreationTime,
                Name = directoryInfo.Name,
                Path = Path.GetDirectoryName(directoryInfo.FullName),
                Size = itemType == DirectorySystemItemType.File ? new FileInfo(directoryInfo.FullName).Length.ToString() : "<DIR>",
                Type = itemType
            };
        }
    }
}
