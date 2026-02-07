using System;
using System.Collections.Generic;
using System.Text;

namespace ZenOS.MB
{
    public class PagingResults<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; } = new List<T>();
        public int PageCount
        {
            get
            {
                if (PageSize <= 0) return 0;
                return (int)Math.Ceiling((double)TotalRecord / PageSize);
            }
        }

        public PagingResults() { }

        public PagingResults(List<T> items, int totalRecord, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalRecord = totalRecord;
            Items = items;
        }
    }
}
