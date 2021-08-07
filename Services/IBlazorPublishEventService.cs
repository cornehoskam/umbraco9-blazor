using System.Collections.Generic;
using System.ComponentModel;
using Umbraco9_Blazor.Models;

namespace Umbraco9_Blazor.Services
{
    public interface IBlazorPublishEventService : INotifyPropertyChanged
    {
        public List<PublishEventModel> PublishEventList { get; set; }

        public void AddEvent(PublishEventModel eventModel);
    }
}
