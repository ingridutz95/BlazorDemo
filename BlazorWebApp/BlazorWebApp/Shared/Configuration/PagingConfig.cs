using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Configuration
{
    public class PagingConfig
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }
        public bool CustomPager { get; set; }
        public int NumOfItemsToSkip(int pageNumber)
        {
            if(Enabled)
            {
                return (pageNumber - 1) * PageSize;
            }
            return 0;
        }
        public int NumItemsToTake(int totalItems)
        {
            if(Enabled)
            {
                return PageSize;
            }
            return totalItems;
        }

        public int PrevPageNumber(int currentPageNo)
        {
            if (currentPageNo > 1)
            {
                return currentPageNo - 1;
            }
            else
            {
                return 1;
            }
        }

        public int MaxPageNo(int totalItems) 
        {
            int maxPageNumber = 1;
            double numberOfPages = (double)totalItems / PageSize;
            if(numberOfPages == Math.Floor(numberOfPages))
            {
                maxPageNumber = (int)numberOfPages;
            }
            else
            {
                maxPageNumber = (int)numberOfPages + 1;
            }
            return maxPageNumber;
        }

        public int NextPageNumber(int currentPageNo, int totalItems)
        {
            if(currentPageNo < MaxPageNo(totalItems))
            {
                return currentPageNo + 1;
            }
            else
            {
                return currentPageNo;
            }
        }
    }
}
