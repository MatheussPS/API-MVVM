using CommunityToolkit.Mvvm.ComponentModel;
using HTTPClient.Models;
using HTTPClient.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTPClient.ViewModel
{
    public partial class PostViewModels : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> posts;

        PostService postService;

        public ICommand getPostsCommand { get; }

        public PostViewModels() {
            getPostsCommand = new Command(getPosts);
            postService = new PostService();
        }

        public async void getPosts()
        {
            Posts = await postService.GetPostsAsync();
        }
    }
}
