using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Umbraco9_Blazor.Models;

namespace Umbraco9_Blazor.Services
{
    public interface IRazorPublishEventService : INotifyPropertyChanged
    {
        public List<PublishEventModel> PublishEventList { get; set; }

        public void AddEvent(PublishEventModel eventModel);
    }
}
