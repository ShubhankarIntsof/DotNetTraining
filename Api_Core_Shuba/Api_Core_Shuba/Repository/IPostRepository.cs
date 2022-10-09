using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Core_Shuba.Models;
using Api_Core_Shuba.ViewModel;

namespace Api_Core_Shuba.Repository
{
    interface IPostRepository
    {
       IEnumerable<ApiCoreShuba> GetCategories();
       List<PostViewModel> GetPosts();


    }
}
