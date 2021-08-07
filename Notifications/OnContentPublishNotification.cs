﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using Umbraco9_Blazor.Models;
using Umbraco9_Blazor.Services;

namespace Umbraco9_Blazor.Notifications
{
    public class OnContentPublishNotification : INotificationHandler<ContentPublishedNotification>
    {
        private readonly IRazorPublishEventService _razorPublishEventService;

        public OnContentPublishNotification(IRazorPublishEventService razorPublishEventService)
        {
            _razorPublishEventService = razorPublishEventService;
        }

        public void Handle(ContentPublishedNotification notification)
        {
            foreach (var node in notification.PublishedEntities)
            {
                _razorPublishEventService.AddEvent(new PublishEventModel()
                {
                    PublishDate = DateTime.Now,
                    ModelAlias = node.ContentType.Alias
                });

            }
        }
    }
}
