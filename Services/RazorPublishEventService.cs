#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Umbraco9_Blazor.Annotations;
using Umbraco9_Blazor.Models;

namespace Umbraco9_Blazor.Services
{
    public class RazorPublishEventService : IRazorPublishEventService
    {
        public List<PublishEventModel> PublishEventList { get; set; }
        public void AddEvent(PublishEventModel eventModel)
        {
            PublishEventList.Add(eventModel);
            NotifyPropertyChanged();
        }

        public RazorPublishEventService()
        {
            PublishEventList = new List<PublishEventModel>()
            {
                new PublishEventModel()
                {
                    PublishDate = DateTime.Now,
                    ModelAlias = "Launch of application"
                }
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
