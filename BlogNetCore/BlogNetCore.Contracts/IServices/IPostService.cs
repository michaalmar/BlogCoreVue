using BlogNetCore.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogNetCore.Contracts.IServices

{
    public interface IPostService
    {
        void AddPost(PostDTO post);

        void DeletePost(PostDTO post);

        Task<IEnumerable<PostDTO>> GetAll();

        Task<PostDTO> Get(int id);

    }
}
