using MyFileManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileManager.Helpers
{
    /// <summary>
    /// Klasa pomagająca w sortowaniu list MyDirectoryItem
    /// </summary>
    public static class SortHelper
    {
        /// <summary>
        /// Pozwala na sortowanie listy MyDirectoryItem względem konkretnej właściwości
        /// </summary>
        /// <param name="itemsList"></param>
        /// <param name="colName"></param>
        /// <param name="sortDirection"></param>
        /// <returns></returns>
        public static List<MyDirectoryItem> ReturnItemsListSortedByProperty(List<MyDirectoryItem> itemsList, string colName, ListSortDirection sortDirection)
        {
            switch (colName)
            {
                case "colPath1":
                case "colPath2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.Path).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.Path).ToList();
                case "colName1":
                case "colName2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.Name).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.Name).ToList();
                case "colFullName1":
                case "colFullName2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.FullName).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.FullName).ToList();
                case "colSize1":
                case "colSize2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.Size).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.Size).ToList();
                case "colCreationDate1":
                case "colCreationDate2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.CreationDate).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.CreationDate).ToList();
                case "colType1":
                case "colType2":
                    if (sortDirection == ListSortDirection.Ascending)
                        return itemsList.OrderBy(i => i.Type).ToList();
                    else
                        return itemsList.OrderByDescending(i => i.Type).ToList();
                default:
                    return itemsList;
            }
        }
    }
}
