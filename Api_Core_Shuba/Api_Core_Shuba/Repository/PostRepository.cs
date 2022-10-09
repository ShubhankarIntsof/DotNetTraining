using Api_Core_Shuba.Models;
using Api_Core_Shuba.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Core_Shuba.Repository
{
   
    public class PostRepository : IPostRepository
    {
        private readonly Freshers_Training2022Context _db;

        public PostRepository(Freshers_Training2022Context context)
        {
            _db = context;
        }



        public List<PostViewModel> GetPosts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApiCoreShuba> GetCategories()
        {
            return _db.ApiCoreShuba.ToList();
        }
    }
}
