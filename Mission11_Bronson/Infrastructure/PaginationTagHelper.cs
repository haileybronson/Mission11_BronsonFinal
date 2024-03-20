using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mission11_Bronson.Models;

    [HtmlTargetElement("div", Attributes ="page-model")]
    public class PaginationTagHelper : TagHelper 
    {
        private IUrlHelperFactory urlHelperFactory;

        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            urlHelperFactory = temp; 
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext {get; set;}
    }