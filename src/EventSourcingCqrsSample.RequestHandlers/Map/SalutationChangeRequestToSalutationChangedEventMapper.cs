﻿using AutoMapper;

using EventSourcingCqrsSample.Events;
using EventSourcingCqrsSample.Models.Requests;

namespace EventSourcingCqrsSample.RequestHandlers.Map
{
    /// <summary>
    /// This represents the mapper entity for <see cref="UsernameChangeRequest" /> to <see cref="UsernameChangedEvent" />.
    /// </summary>
    public class UsernameChangeRequestToUsernameChangedEventMapper :
        BaseRequestToEventMapper<UsernameChangeRequest, UsernameChangedEvent>
    {
        /// <summary>
        /// Initialises the mapping definition.
        /// </summary>
        protected override void Initialise()
        {
            if (this.Initialised)
            {
                return;
            }

            Mapper.CreateMap<UsernameChangeRequest, UsernameChangedEvent>()
                  .ForMember(ev => ev.EventStream, o => o.MapFrom(req => req.StreamId))
                  .ForMember(ev => ev.ElementId, o => o.MapFrom(req => req.Id))
                  .ForMember(ev => ev.ElementName, o => o.MapFrom(req => req.Name))
                  .ForMember(ev => ev.ElementValue, o => o.MapFrom(req => req.Value));

            this.Initialised = true;
        }
    }
}