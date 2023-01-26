using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class PagedResponse<T>:ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }   
        public PagedResponse( T value,int pageSize,int pageNumber ):base(value) 
        {
            PageNumber= pageNumber;
            PageSize=pageSize;
        }
      
        
    }
}
