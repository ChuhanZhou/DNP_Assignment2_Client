using DNP1.DNP_Assignment2;

#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\UpdatePerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8fc9ab3a909b1b1c3f0ff13bd776ed5a21da7d"
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
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Assignment2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\UpdatePerson.razor"
using Assignment2.Models.Unit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\UpdatePerson.razor"

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UpdatePerson")]
    public partial class UpdatePerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\UpdatePerson.razor"
       
    private static Person newPerson = new Person();
    private static string personType = "Person";
    private string error;
    private string errorForPet;
    private Pet addPet;
    
    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
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

    public static void setInfo(Adult adult)
    {
        if (adult!=null)
        {
            newPerson = adult;
            personType = "Adult";
        }
    }

    public static void setInfo(Child child)
    {
        if (child!=null)
        {
            newPerson = child;
            personType = "Child";
        }
    }
    
    private void ChooseInterest(string chooseInterest)
    {
        if (HasInterest(chooseInterest))
        {
            foreach (var interest in ((Child)newPerson).ChildInterests.Where(interest => interest.Type.Equals(chooseInterest)))
            {
                ((Child)newPerson).ChildInterests.Remove(interest);
                break;
            }
        }
        else
        {
            ((Child)newPerson).ChildInterests.Add(new Interest {Type = chooseInterest});
        }
    }

    private bool HasInterest(string chooseInterest)
    {
        foreach (var interest in ((Child)newPerson).ChildInterests.Where(interest => interest.Type.Equals(chooseInterest)))
        {
            return true;
        }
        return false;
    }
    
    private void AddPet()
    {
        errorForPet = null;
        foreach (var x in ((Child)newPerson).Pets.Where(x => x.Id == addPet.Id))
        {
            errorForPet = "This pet id is used.";
            break;
        }
        if (errorForPet==null)
        {
            ((Child)newPerson).Pets.Add(addPet);
            addPet = new Pet
            {
                Species = addPet.Species
            };
        }
    }
    
    private void RemovePet(Pet pet)
    {
        foreach (var x in ((Child)newPerson).Pets.Where(x => x.Id == pet.Id))
        {
            ((Child)newPerson).Pets.Remove(x);
            break;
        }
        errorForPet = null;
    }
    
    private async Task UpdateOldPerson()
    {
        error = await ModelManager.UpdatePersonAsync(newPerson);
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
