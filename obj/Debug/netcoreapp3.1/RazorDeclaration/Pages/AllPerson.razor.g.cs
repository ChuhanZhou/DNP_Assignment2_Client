#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9dd2786474c78e72660e9cb3a8ceca8497ce997"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment2.Pages
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
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using global::DNP_Assignment2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using Assignment2.Models.Unit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using Assignment2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllPerson")]
    public partial class AllPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
       
    private static readonly List<string> KeyWordList = new[]
    {
        "All","Id","Name","Age","Height","Weight","Sex","Job"
    }.ToList();
    private AdultList allAdult;
    private ChildList allChild;
    private PersonList showList;
    private string error;
    private string searchKeyWord;
    private string searchInfo1;
    private string searchInfo2;
    private string historyKeyWord;
    
    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            error = null;
            searchKeyWord = KeyWordList[0];
            historyKeyWord = searchKeyWord;
            showList = new PersonList();
            await InitShowList();
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }

    private async Task InitShowList()
    {
        allAdult = await ModelManager.GetAllAdultAsync();
        allChild = await ModelManager.GetAllChildAsync();
        showList = new PersonList();
        foreach (var adult in allAdult.adults)
        {
            showList.AddPerson(adult);
        }
        foreach (var child in allChild.childs)
        {
            showList.AddPerson(child);
        }
    }

    private async Task ChangeKeyWord()
    {
        if (historyKeyWord!=searchKeyWord)
        {
            error = null;
            switch (searchKeyWord)
            {
                case "All":
                    break;
                case "Id":
                    searchInfo1 = "0";
                    searchInfo2 = null;
                    break;
                case "Name":
                    searchInfo1 = null;
                    searchInfo2 = null;
                    break;
                case "Age":
                    searchInfo1 = "0";
                    searchInfo2 = "125";
                    break;
                case "Height":
                    searchInfo1 = "1";
                    searchInfo2 = "250";
                    break;
                case "Weight":
                    searchInfo1 = "30";
                    searchInfo2 = "250";
                    break;
                case "Sex":
                    searchInfo1 = "All";
                    searchInfo2 = null;
                    break;
                case "Job":
                    searchInfo1 = "All";
                    searchInfo2 = null;
                    break;
            }
            await SearchByKeyWord();
        }
        historyKeyWord = searchKeyWord;
    }
    
    private async Task SearchByKeyWord()
    {
        error = null;
        await InitShowList();
        switch (searchKeyWord)
        {
            case "All":
                break;
            case "Id":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    Person target = null;
                    try
                    {
                        target = showList.GetPersonById(int.Parse(searchInfo1));
                    }
                    catch (Exception e)
                    {
                        error = "Id is a number.";
                    }
                    showList = new PersonList();
                    showList.AddPerson(target);
                }
                break;
            case "Name":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    showList = showList.GetPersonListByFirstName(searchInfo1);
                }
                if (!string.IsNullOrEmpty(searchInfo2))
                {
                    showList = showList.GetPersonListByLastName(searchInfo2);
                }
                break;
            case "Age":
                CheckSearchInfo(searchKeyWord,0,125);
                showList = showList.GetPersonListByAge(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Height":
                CheckSearchInfo(searchKeyWord,1,250);
                showList = showList.GetPersonListByHeight(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Weight":
                CheckSearchInfo(searchKeyWord,30,250);
                showList = showList.GetPersonListByWeight(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Sex":
                if (searchInfo1!="All")
                {
                    showList = showList.GetPersonListBySex(searchInfo1);
                }
                break;
            case "Job":
                if (searchInfo1!="All")
                {
                    showList = new PersonList();
                    foreach (var adult in allAdult.GetAdultListByJob(searchInfo1).adults)
                    {
                        showList.AddPerson(adult);
                    }
                }
                break;
        }
    }

    private void CheckSearchInfo(string keyword,int min, int max)
    {
        try
        {
            if (string.IsNullOrEmpty(searchInfo1))
            {
                searchInfo1 = "" + min;
            }
            else if(float.Parse(searchInfo1)<min||float.Parse(searchInfo1)>max)
            {
                searchInfo1 = "" + min;
            }
            if (string.IsNullOrEmpty(searchInfo2))
            {
                searchInfo2 = "" + max;
            }
            else if(float.Parse(searchInfo2)<min||float.Parse(searchInfo2)>max)
            {
                searchInfo2 = "" + max;
            }
            else if (float.Parse(searchInfo2)<float.Parse(searchInfo1))
            {
                searchInfo2 = "" + float.Parse(searchInfo1);
            }
            
        }
        catch (Exception e)
        {
            error = keyword + " is a number.";
        }
    }

    private void UpdatePerson(Person targetPerson)
    {
        NavigationManager.NavigateTo("UpdatePerson");
        if (allAdult.GetAdultById(targetPerson.Id)!=null)
        {
            Pages.UpdatePerson.setInfo(allAdult.GetAdultById(targetPerson.Id));
        }
        else
        {
            Pages.UpdatePerson.setInfo(allChild.GetChildById(targetPerson.Id));
        }
        
    }

    private async Task RemovePerson(Person targetPerson)
    {
        await ModelManager.RemovePersonAsync(targetPerson);
        await InitShowList();
        await SearchByKeyWord();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
