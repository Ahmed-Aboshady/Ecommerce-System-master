#pragma checksum "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92ad4255a502e46a81506250095f80d653da2b91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_subCategoryData_FilterByPrice), @"mvc.1.0.view", @"/Areas/User/Views/subCategoryData/FilterByPrice.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ad4255a502e46a81506250095f80d653da2b91", @"/Areas/User/Views/subCategoryData/FilterByPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb445e7fa51e912a00e9a5abe0d2b4ac6cb7e700", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_subCategoryData_FilterByPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FinalProject.Models.product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100% !important;max-width:100!important;height:100%!important;max-height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "subCategoryData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("addCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("googles-cart pgoogles-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No Products</h1>\n");
#nullable restore
#line 5 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
     foreach (var product in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3 product-men women_two shop-gd"">
            <div class=""product-googles-info googles"" style=""height:100% !important"">
                <div class=""men-pro-item"">
                    <div class=""men-thumb-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92ad4255a502e46a81506250095f80d653da2b918634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 413, "~/photos/", 413, 9, true);
#nullable restore
#line 15 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
AddHtmlAttributeValue("", 422, product.productPhoto, 422, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <div class=\"men-cart-pro\">\n                            <div class=\"inner-men-cart-pro\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 794, 1);
#nullable restore
#line 18 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
WriteAttributeValue("", 716, Url.Action("getProductDetails","subCategoryData",new {id=product.productId }), 716, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""link-product-add-cart"">Quick View</a>
                            </div>
                        </div>
                        <span class=""product-new-top"">New</span>
                    </div>
                    <div class=""item-info-product"">
                        <div class=""info-product-price"">
                            <div class=""grid_meta"">
                                <div class=""product_price"">
                                    <h4>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ad4255a502e46a81506250095f80d653da2b9111529", async() => {
#nullable restore
#line 28 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                                                                                               Write(product.productName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                                                                    WriteLiteral(product.productId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </h4>\n                                    <div class=\"grid-price mt-2\">\n");
#nullable restore
#line 31 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                          
                                            var netvalue = product.productPrice - product.discountValue;
                                            if (product.discountValue > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <del class=\"money \">$");
#nullable restore
#line 35 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                Write(product.productPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\n");
            WriteLiteral("                                                <span class=\"money \">$");
#nullable restore
#line 37 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                 Write(netvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 38 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"money \">$");
#nullable restore
#line 41 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                 Write(product.productPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 42 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"

                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </div>\n                            </div>\n                            <div class=\"googles single-item hvr-outline-out\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ad4255a502e46a81506250095f80d653da2b9117096", async() => {
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ad4255a502e46a81506250095f80d653da2b9117389", async() => {
                    WriteLiteral("\n                                        <i class=\"fas fa-cart-plus\"></i>\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
                                                                   WriteLiteral(product.productId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ProductId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ProductId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                            </div>\n                        </div>\n                        <div class=\"clearfix\"></div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 63 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "F:\2-oop\Ecommerce-System-master\FinalProject\FinalProject\Areas\User\Views\subCategoryData\FilterByPrice.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FinalProject.Models.product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
