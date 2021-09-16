using NewWebShopStream.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Models
{
    public class DataManager
    {
        public IServiceItemRepository ServiceItems { get; set; }
        public ITextFieldRepository TextFields { get; set; }
        public DataManager(IServiceItemRepository serviceItemRepository, ITextFieldRepository textFieldRepository)
        {
            ServiceItems = serviceItemRepository;
            TextFields = textFieldRepository;
        }
    }
}
