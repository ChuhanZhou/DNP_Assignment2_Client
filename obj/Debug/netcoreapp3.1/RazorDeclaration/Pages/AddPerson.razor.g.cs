#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AddPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6864b6a46e8669a8509a4a7129ff83308fe593e1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP_Assignment2_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AddPerson.razor"
using DNP_Assignment2_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AddPerson.razor"
using DNP_Assignment2_Client.Models.Unit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPerson")]
    public partial class AddPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AddPerson.razor"
       
    private Person newPerson;
    private string personType;
    private string error;
    private string jobTitle;
    private List<Interest> interests;
    private List<Pet> pets;
    private string errorForPet;
    private Pet addPet;

    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            newPerson = new Person
            {
                Id = 0,
                FirstName = null,
                LastName = null,
                HairColor = Person.ValidHairColor[0],
                EyeColor = Person.ValidEyeColor[0],
                Age = 0,
                Weight = 0,
                Height = 0,
                Sex = Person.ValidSex[0],
            };
            jobTitle = Adult.ValidJob[0];
            interests = new List<Interest>();
            pets = new List<Pet>();
            personType = "Adult";
            addPet = new Pet
            {
                Species = Pet.ValidSpecies[0]
            };
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }

    private void ChooseInterest(string chooseInterest)
    {
        if (HasInterest(chooseInterest))
        {
            foreach (var interest in interests.Where(interest => interest.Type.Equals(chooseInterest)))
            {
                interests.Remove(interest);
                break;
            }
        }
        else
        {
            interests.Add(new Interest{Type = chooseInterest});
        }
    }

    private bool HasInterest(string chooseInterest)
    {
        foreach (var interest in interests.Where(interest => interest.Type.Equals(chooseInterest)))
        {
            return true;
        }
        return false;
    }
    
    private void AddPet()
    {
        errorForPet = null;
        foreach (var x in pets.Where(x => x.Id == addPet.Id))
        {
            errorForPet = "This pet id is used.";
            break;
        }
        if (errorForPet==null)
        {
            pets.Add(addPet);
            addPet = new Pet
            {
                Species = addPet.Species
            };
        }
    }
    
    private void RemovePet(Pet pet)
    {
        foreach (var x in pets.Where(x => x.Id == pet.Id))
        {
            pets.Remove(x);
            break;
        }
        errorForPet = null;
    }
    
    private async Task AddNewPerson()
    {
        switch (personType)
        {
            case "Adult":
                error = await ModelManager.AddAdultAsync(new Adult
                {
                    Id = newPerson.Id,
                    FirstName = newPerson.FirstName,
                    LastName = newPerson.LastName,
                    HairColor = newPerson.HairColor,
                    EyeColor = newPerson.EyeColor,
                    Age = newPerson.Age,
                    Weight = newPerson.Weight,
                    Height = newPerson.Height,
                    Sex = newPerson.Sex,
                    JobTitle = jobTitle
                });
                break;
            case "Child":
                error = await ModelManager.AddChildAsync(new Child
                {
                    Id = newPerson.Id,
                    FirstName = newPerson.FirstName,
                    LastName = newPerson.LastName,
                    HairColor = newPerson.HairColor,
                    EyeColor = newPerson.EyeColor,
                    Age = newPerson.Age,
                    Weight = newPerson.Weight,
                    Height = newPerson.Height,
                    Sex = newPerson.Sex,
                    ChildInterests = interests,
                    Pets = pets
                });
                break;
        }
        if (string.IsNullOrEmpty(error))
        {
            NavigationManager.NavigateTo("AllPerson");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
