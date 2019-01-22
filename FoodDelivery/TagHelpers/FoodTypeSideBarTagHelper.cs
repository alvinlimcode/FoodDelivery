using FoodDelivery.Core.Extensions;
using FoodDelivery.Service.Foods;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.TagHelpers
{
    [HtmlTargetElement("foodtypesidebar")]
    public class FoodTypeSideBarTagHelper : TagHelper
    {
        private readonly IFoodTypeService _foodTypeService;

        public FoodTypeSideBarTagHelper(
            IFoodTypeService foodTypeService
        )
        {
            _foodTypeService = foodTypeService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder html = new StringBuilder();
            html.Append("<ul class='list-group'>");

            var foodTypes = await _foodTypeService.GetAvailableFoodTypesAsync();
            foreach(var foodType in foodTypes)
            {
                html.Append($"<li class='list-group-item'><a href='/foods/type/{ foodType.Id }/{ foodType.Name.SeoFriendlyUrl() }'>{ foodType.Name }</a></li>");
            }

            html.Append("</ul>");

            output.Content.SetHtmlContent(html.ToString());

            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
