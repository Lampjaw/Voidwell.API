﻿using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Voidwell.API.Clients
{
    public interface IInternalClient
    {
        Task<JToken> GetAllBlogPosts();
        Task<JToken> GetBlogPost(string blogPostId);
        Task<JToken> CreateBlogPost(JToken content);
        Task<JToken> UpdateBlogPost(string blogPostId, JToken content);
        Task DeleteBlogPost(string blogPostId);
        Task<JToken> GetAllEvents();
        Task<JToken> GetAllEventsByGame(string gameId);
        Task<JToken> GetEvent(string eventId);
        Task<JToken> UpdateEvent(string eventId, JToken requestContent);
        Task<JToken> CreateEvent(JToken requestContent);
    }
}
