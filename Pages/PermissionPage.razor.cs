using Apollo.Tiers.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloTiers.Pages
{
    public partial class PermissionPage
    {
        public IEnumerable<object> checkedItems { get; set; } = new List<object>();

        public class TreeItem
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public int? ParentIdValue { get; set; }
            public bool HasChildren { get; set; }
            public string Icon { get; set; }
            public bool Expanded { get; set; }
        }

        public IEnumerable<Page> FlatData { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadFlatDataAsync();

            var precheckedItem = FlatData.Where(x => x.Id == 3); // provide initial checked item when the page is loaded

            checkedItems = new List<object>(precheckedItem);
        }

        async Task LoadFlatDataAsync()
        {
            var apiName = "api/user/GetPages";
            var httpResponse = await client.GetAsync(apiName);

            if (httpResponse.IsSuccessStatusCode)
            {
                FlatData = JsonConvert.DeserializeObject<List<Page>>(await httpResponse.Content.ReadAsStringAsync());


            }
            
        }
    }
}
