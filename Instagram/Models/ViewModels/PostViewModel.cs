﻿using System;
using System.Collections.Generic;
using Instagram.Domain;
using Microsoft.AspNetCore.Identity;

namespace Instagram.Models.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public IList<Like> Likes { get; set; }=new List<Like>();
        public string Photo { get; set; } = "https://picsum.photos/200";
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public IList<Coment> Coments { get; set; }=new List<Coment>();
    }
}