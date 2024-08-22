using CommunityToolkit.Mvvm.ComponentModel;
using HTTPClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HTTPClient.Services;

namespace HTTPClient.Models
{
    public partial class CreatPostViewModel: ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        int userId;

        public ICommand SavePostCommand { get; }

        CreatPostViewModel()
        {
            SavePostCommand = new Command(SavePost);
        }


        public async void SavePost()
        {
            Post post = new Post();
            Post newPost = new Post();

            post.Title = Title;
            post.Body = Body;   
            post.UserId = UserId;

            PostService postService = new PostService();
            newPost = await postService.SavePostAsync(post);
        }
    }
}
