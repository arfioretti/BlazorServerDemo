using BlazorServerDemo.Models;
using BlazorServerDemo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService ContactService { get; set; }

        [Inject]
        NavigationManager naviManage {  get; set; }

        private List<Contact> contacts;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            contacts = ContactService.GetContacts();

        }
        private void TestHrefAchor()
        {
            naviManage.NavigateTo("./TestHrefAchor");
        }

        // protected override void OnInitialized()
        // {
        //     base.OnInitialized();
        //     contacts = new List<Contact>()
        //     {
        //         new Contact { FirstName = "Aristides", LastName = "Fioretti", Email = "arfioretti@gmail.com" },
        //         new Contact { FirstName = "Aura", LastName = "Fioretti", Email = "aurafioretti@gmail.com" },
        //         new Contact { FirstName = "Piliba", LastName = "Fioretti", Email = "pilibafioretti@gmail.com" },
        //         new Contact { FirstName = "Carneirito", LastName = "Fioretti", Email = "carneiritofioretti@gmail.com" }
        //     };
        // }   

    }
}
