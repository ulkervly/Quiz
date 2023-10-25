using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_models
{
    static class BlogService
    {
        
        static void AddBlog(Blog blog)
        {
            foreach (var item in List<Blog>BlogsList)
            {
                if (blog=item)
                {
                    Blogs.Add(blog);
                }
            }
       
        }
        static  void RemoveBlog(int id)
        {
            BlogsList.Remove(Blog => Blog.id);
        }
        static Blog GetBlogById(int id)
        {

        }
        static List<Blog> GetAllBlogs()
        {

        }
        static List<Blog> GetBlogsByValue(string value)
        {

        }

    }
}
