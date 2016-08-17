﻿using OpenCharityAuction.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenCharityAuction.Entities.Models;

namespace OpenCharityAuction.Web.Models.Services
{
    public class AuctionService : IAuctionService
    {
        private readonly Data.AuctionContext AuctionContext;

        public AuctionService(Data.AuctionContext context)
        {
            AuctionContext = context;
        }

        public void AddEvent(Event newEvent, Action<Event> callback = null)
        {
            newEvent.CreateDate = DateTime.UtcNow.Date;
            AuctionContext.Events.Add(newEvent);
            AuctionContext.SaveChanges();

            // Send CallBack if not null
            callback?.Invoke(newEvent);
        }
    }
}
