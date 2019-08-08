using BlogNetCore.BLL.DTO;
using BlogNetCore.Contracts.IServices;
using BlogNetCore.DAL;
using BlogNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNetCore.BLL.Services
{
    public class PostService : IPostService
    {
        private readonly BlogContext dbContext;

        public PostService(BlogContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddPost(PostDTO post)
        {
            var _post = new Post
            {
                Title = post.Title,
                Content = post.Content,
                Created = DateTime.UtcNow,
                AuthorName = post.AuthorName,
            };
            dbContext.Posts.Add(_post);
            dbContext.SaveChanges();
        }

        public void DeletePost(PostDTO post)
        {
            throw new System.NotImplementedException();
        }

        public Task<PostDTO> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PostDTO>> GetAll()
        {
            var listOfPosts = await dbContext.Posts
                .Select(p => new PostDTO
                {

                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    AuthorName = p.AuthorName,
                    Created = p.Created
                }).ToListAsync();

            return listOfPosts;
        }
    }
}
