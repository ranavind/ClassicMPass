using Apollo.Tiers.DataAccess.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace ApolloTiers.Pages
{
    public partial class UserCreation 
    {
        public User user = new User();
        public bool ValidSubmit { get; set; } = false;
        public List<Role> roles  = new List<Role>();
        public List<User> users { get; set; }
        public bool ShowCreateEdit { get; set; } = false;
       
        async void HandleValidSubmit()
        {
            ValidSubmit = true;
            
            var userJson = new StringContent(
         JsonConvert.SerializeObject(user),Encoding.UTF8,"application/json");
            if (user.Id == 0)
            {
                string apiName = "api/User/CreateUser";
                await client.PostAsync(apiName, userJson);
            }
            else if(user.Id != 0)
            {
                string apiName = "api/User/UpdateUser";
                await client.PutAsync(apiName, userJson);
            }                    

            ValidSubmit = false;
            ShowCreateEdit = false;
            await GetUsers();

            StateHasChanged();
        }

        void HandleInvalidSubmit()
        {
            ValidSubmit = false;
        }
        protected override async Task OnInitializedAsync()
        {
           
           await  GetUsers();
           await GetRoles();
            
        }  
        async Task GetRoles()
        {
            var apiName = "api/role";
            var httpResponse = await client.GetAsync(apiName);

            if (httpResponse.IsSuccessStatusCode)
            {
                roles = JsonConvert.DeserializeObject<List<Role>>(await httpResponse.Content.ReadAsStringAsync());

                // StateHasChanged();
            }
        }

        async Task GetUsers()
        {
            var apiName = "api/user";
            var httpResponse = await client.GetAsync(apiName);

            if (httpResponse.IsSuccessStatusCode)
            {
                users = JsonConvert.DeserializeObject<List<User>>(await httpResponse.Content.ReadAsStringAsync());

                
            }
            
        }
        Task EditCommandHandler(GridCommandEventArgs args)
        {
            ShowCreateEdit = true;
            user = (User)args.Item;
            Console.WriteLine("The Custom command fired. Please wait for the long operation to finish");
            return Task.CompletedTask;
        }

        private void CreateCommandHandler(GridCommandEventArgs args)
        {
            user = new User();
            ShowCreateEdit = true;
            StateHasChanged();
        }
        async Task DeleteHandler(GridCommandEventArgs args)
        {
            User user = args.Item as User;
            var request = new HttpRequestMessage(HttpMethod.Delete, "api/User/DeleteUser");
            request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
           await client.SendAsync(request);
          
            await GetUsers();
        }

    }
}
