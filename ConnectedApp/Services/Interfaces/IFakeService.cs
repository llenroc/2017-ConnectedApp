﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConnectedApp.Models;

namespace ConnectedApp.Services.Interfaces
{
    public interface IFakeService
    {
        IObservable<List<Post>> GetPosts();
        IObservable<Post> GetPost(string id);
        Task<List<Comment>> GetCommentsByPost(string id);
    }
}