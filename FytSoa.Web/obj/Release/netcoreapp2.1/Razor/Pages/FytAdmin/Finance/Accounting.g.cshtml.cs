#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1294e7e5ef2dabb0f154f435a6537eeed76d90fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Finance.Pages_FytAdmin_Finance_Accounting), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Finance/Accounting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Finance/Accounting.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Finance.Pages_FytAdmin_Finance_Accounting), null)]
namespace FytSoa.Web.Pages.FytAdmin.Finance
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1294e7e5ef2dabb0f154f435a6537eeed76d90fe", @"/Pages/FytAdmin/Finance/Accounting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Finance_Accounting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml"
  
    ViewData["Title"] = "财务管理-核算总账";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(155, 306, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        .layui-table td {
            border-radius: 0px;
        }
    </style>
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <select id=""shops"" lay-search="""">
                    ");
            EndContext();
            BeginContext(461, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b94fba3b29a4a3e9998e7ddfcabbd0a", async() => {
                BeginContext(478, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(498, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml"
                      
                        foreach (var item in Model.shopList)
                        {

#line default
#line hidden
            BeginContext(613, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(641, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b18b90b87742fea5cf8c0915bb7cc0", async() => {
                BeginContext(669, 13, false);
#line 21 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml"
                                                  Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 21 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(691, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Accounting.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(743, 3307, true);
            WriteLiteral(@"                </select>
            </div>
            <div class=""layui-inline"">
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
    </div>
    <div class=""list-wall"" style=""padding-top:0px"">
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""realMoney"">
        {{(d.money-d.backMoney).toFixed(2)}}
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'form', 'common', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $");
            WriteLiteral(@" = layui.jquery,
                    os = layui.common,
                    form = layui.form,
                    laydate = layui.laydate;
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , range: true
                    , format: 'yyyy/MM/dd'
                });
                form.render('select');
                table.render({
                    elem: '#tablist',
                    url: '/api/inventory/shopturnover',
                    cols: [
                        [
                            { field: 'shopName', title: '店铺名称', fixed: 'left' },
                            { field: 'orderCount', width: 150, title: '订单数' },
                            { field: 'money', width: 120, title: '应收营业额' },
                            { field: 'backMoney', width: 120, title: '退货金额'},
                            { field: 'money', width: 120, title: '实收营业额', style: 'background-color: #D9DEE4;', templet: '#realMo");
            WriteLiteral(@"ney' },
                            { field: 'returnCount', width: 200, title: '返货数' },
                            { field: 'backCount', width: 200, title: '退货数' }
                        ]
                    ],
                    page: true,
                    limit: 15,
                    id: 'tables'
                });
                var active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    time: $(""#times"").val(),
                                    guid: $(""#shops"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };
                $('.");
            WriteLiteral("list-search .layui-btn\').on(\'click\', function () {\r\n                    var type = $(this).data(\'type\');\r\n                    active[type] ? active[type].call(this) : \'\';\r\n                });\r\n            });\r\n    </script>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Finance.AccountingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Finance.AccountingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Finance.AccountingModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Finance.AccountingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
