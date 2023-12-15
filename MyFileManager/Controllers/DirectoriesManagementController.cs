using MyFileManager.Helpers;
using MyFileManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileManager.Controllers
{
    public class DirectoriesManagementController
    {
        /// <summary>
        /// Przechowuje listę z komunikatami błędów
        /// </summary>
        public List<string> errorMessages { get; set; }

        /// <summary>
        /// Pobiera ścieżki z podanej lokalizacji i zwraca je w postaci listy MyDirectoryItem
        /// </summary>
        /// <param name="path"></param>
        public List<MyDirectoryItem> DownlowadDirectiries(string path)
        {
            errorMessages = new List<string>();
            List<MyDirectoryItem> myDirectoryItems = new List<MyDirectoryItem>();

            if(path != null)
            {
                try
                {
                    string[] directories = Directory.GetDirectories(path);
                    string[] files = Directory.GetFiles(path);
                    foreach (string dir in directories)
                    {
                        MyDirectoryItem newDirItem = MyMapper.MapDirectorySystemItem(new DirectoryInfo(dir), DirectorySystemItemType.Directory);
                        if (newDirItem != null)
                            myDirectoryItems.Add(newDirItem);
                    }
                    foreach (string file in files)
                    {
                        MyDirectoryItem newDirItem = MyMapper.MapDirectorySystemItem(new DirectoryInfo(file), DirectorySystemItemType.File);
                        if (newDirItem != null)
                            myDirectoryItems.Add(newDirItem);
                    }
                }
                catch(Exception ex)
                {
                    errorMessages.Add(ex.Message + "\n\n" + ex.StackTrace);
                }
            }
            return myDirectoryItems;
        }

        /// <summary>
        /// Usuwa podaną ścieżkę
        /// </summary>
        /// <param name="fullName">pełna ścieżka do elemenu wraz z nazwą</param>
        public bool RemovePath(string fullPath, DirectorySystemItemType type)
        {
            try
            {
                if (type == DirectorySystemItemType.File && File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    return true;
                }
                else if (type == DirectorySystemItemType.Directory && Directory.Exists(fullPath))
                {
                    Directory.Delete(fullPath, true);
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Tworzy plik we wskazanej lokalizacji
        /// </summary>
        /// <param name="fullName"></param>
        public bool CreatePath(string fullName)
        {
            if (Directory.Exists(Path.GetDirectoryName(fullName)))
            {
                try
                {
                    Directory.CreateDirectory(fullName);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        /// Szuka dostępnej nazwy dla wskazanej ścieżki
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        public string FindPathName(string pathName)
        {
            bool pathNameFound = false;
            int index = 1;

            pathName += $"({index})";
            while (!pathNameFound)
            {
                if (!Directory.Exists(pathName))
                    pathNameFound = true;
                else
                {
                    pathName = pathName.Replace($"({index})", $"({++index})");
                }
            }
            return pathName;
        }

        /// <summary>
        /// Kopiuje wskazany plik do podanej lokazliacji
        /// </summary>
        /// <param name="baseDirectory"></param>
        /// <param name="targetDirectory"></param>
        public bool CopyPath(string basePath, string targetPath, DirectorySystemItemType type)
        {
            string dirName = Path.GetFileName(basePath);

            if (!String.IsNullOrEmpty(dirName))
            {
                string targetPathCombined = Path.Combine(targetPath, dirName);

                try
                {
                    if (type == DirectorySystemItemType.File && File.Exists(basePath))
                    {
                        File.Copy(basePath, targetPathCombined);
                        return true;
                    }
                    else if (type == DirectorySystemItemType.Directory && Directory.Exists(targetPath))
                    {
                        DirectoryInfo dirInfo = Directory.CreateDirectory(targetPathCombined);

                        string[] files = Directory.GetFiles(basePath);
                        string[] directories = Directory.GetDirectories(basePath);

                        foreach (string file in files)
                        {
                            CopyPath(file, targetPathCombined, DirectorySystemItemType.File);
                        }
                        foreach (string dir in directories)
                        {
                            CopyPath(dir, targetPathCombined, DirectorySystemItemType.Directory);
                        }

                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else return false;

        }
    }
}
