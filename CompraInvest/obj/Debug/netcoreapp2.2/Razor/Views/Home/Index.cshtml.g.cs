#pragma checksum "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1263355d472f82340ad13306dc0460783e0fb26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\_ViewImports.cshtml"
using CompraInvest;

#line default
#line hidden
#line 2 "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\_ViewImports.cshtml"
using CompraInvest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1263355d472f82340ad13306dc0460783e0fb26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed51a04233cb258d41127e334d8b230545e996df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/cuidamos-da-tecnologia.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:160px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/comparador-de-precos.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1-COMPLETASSO.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Pagina Inicial";

#line default
#line hidden
            BeginContext(99, 3534, true);
            WriteLiteral(@"

<!-- Modal -->
<div class=""modal fade"" id=""exampleModalScrollable"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalScrollableTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title text-center text-danger w-100"" id=""exampleModalScrollableTitle"">A Plataforma CompraInvest</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modalBody"">

            </div>
            <div class=""modal-footer"">
                <a href=""https://www.boavenda.com/Home/Index#planosDiv"" class=""btn btn-success text-light"" data-dismiss=""modal"">Inscrever-se</a>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Fechar</button>
           ");
            WriteLiteral(@" </div>
        </div>
    </div>
</div>

<div class=""main"" id=""main"">
    <header style=""background-color:#f3f3f3;"">
        <div class=""container"" style=""max-width:1800px;"">
            <div class=""row"">
                <div class=""intro-box"">
                    <div class=""intro"">
                        <h1>Inclua aqui a foto de seu cupom fiscal</h1>
                        <div class=""d-flex justify-content-center flex-row bd-highlight mb-3 busca-home-desktop"">
                            <div class=""p-2 bd-highlight"" style=""width:75%;"">
                                <input id=""buscaProdutoDesktop"" class=""place-preto form-control"" type=""file""
                                       style=""border-radius:0.3em;height:50px;"" placeholder=""Insira o link de um produto que você está vendendo"">
                            </div>
                            <div class=""p-2 bd-highlight"">
                                <button type=""button"" class=""btn botao-analise-home"" onclick=""VaiParaPlanil");
            WriteLiteral(@"ha()"">
                                    Análise Gratuita
                                </button>
                            </div>
                        </div>
                        <div class=""busca-home-celular"" style=""margin-left:16px;margin-right:16px;"">
                            <div class=""input-group mb-3"">
                                <input id=""buscaProdutoCelular"" class=""place-preto form-control"" type=""text""
                                       aria-label=""Recipient's username"" aria-describedby=""basic-addon2"" style=""border-radius:0.3em;height:50px;""
                                       placeholder=""Link produto que você vende"">
                                <div class=""input-group-append"">
                                    <button class=""btn botao-analise-home-celular"" id=""basic-addon2""><i class=""fas fa-search""></i></button>
                                </div>
                            </div>

                        </div>

                    </div>
  ");
            WriteLiteral(@"              </div>
            </div>
        </div>
    </header>
    <section class=""purpose section"">
        <div class=""container"" style=""max-width:1800px;"">
            <h2 class=""title"">Administre suas compras e ganhe dinheiro</h2>
            <div class=""row"">
                <div class=""col-sm-6 div-item-home"">
                    <div class=""vira-card"">
                        <div class=""vira-card-header"">
                            ");
            EndContext();
            BeginContext(3633, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1263355d472f82340ad13306dc0460783e0fb268740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3701, 647, true);
            WriteLiteral(@"
                        </div>
                        <div class=""vira-card-content"">
                            <h3>Administração de compras</h3>
                            <p>
                                Quando comprar algo e receber o cupom fiscal, escaneie o código QR Code por aqui e obtenha uma gestão grátis de suas compras!
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 div-item-home"">
                    <div class=""vira-card"">
                        <div class=""vira-card-header"">
                            ");
            EndContext();
            BeginContext(4348, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1263355d472f82340ad13306dc0460783e0fb2610647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4414, 3457, true);
            WriteLiteral(@"
                        </div>
                        <div class=""vira-card-content"">
                            <h3>Ganhe dinheiro fácil!</h3>
                            <p>
                                Ao escanear o QR Code dos produtos e se identificar, o nosso sistema automaticamente pede CPF na nota para você e sugere investimentos com base em seu perfil de compras!
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""about"" class=""about section"">
        <div class=""container-fluid"" style=""max-width:1400px;"">
            <div class=""row w-100"" style=""padding-left:16px;"">
                <h2 class=""title w-100"">Quem somos</h2>
                <h4>
                    Somos uma plataforma inovadora que traz a comodidade de você conseguir administrar os seus custos e investir sem precisar tomar nenhuma decisão complexa!
                    Nascemos no Hack");
            WriteLiteral(@"athon BMG e acreditamos que esse produto pode revolucionar a maneira com que as pessoas administram suas compras hoje.
                    Já pensou conseguir comprar e investir ao mesmo tempo? E já pensou isso ser prático, como uma simples foto de um cupom fiscal? A inovação está aqui! Ela existe!
                </h4>
            </div>
            <div class=""row w-100"">

            </div>
        </div>
    </section>
</div>

<section id=""contato"">
    <div class=""container mt-5 mb-5"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""col-12"" style=""padding-top:120px;"">
                    <h2 class=""text-center"">Contato</h2>
                    <h4 style=""text-center"">Em caso de dúvidas ou sugestões, preencha o formulário abaixo que em breve lhe enviaremos uma resposta</h4>
                </div>

                <div class=""col-12"">
                    <div class=""m-2"">
                        <div class=""col-12 form-group"">
                  ");
            WriteLiteral(@"          <label for=""ContatoNome"" class=""control-label"">Nome</label>
                            <input type=""text"" id=""ContatoNome"" class=""form-control input-email"" />
                        </div>
                        <div class=""col-12 form-group"">
                            <label for=""ContatoAssunto"" class=""control-label"">Assunto</label>
                            <input type=""text"" id=""ContatoAssunto"" class=""form-control input-email"" />
                        </div>
                        <div class=""col-12 form-group"">
                            <label for=""ContatoEmail"" class=""control-label"">Email</label>
                            <input type=""email"" id=""ContatoEmail"" class=""form-control input-email"" />
                        </div>

                        <div class=""col-12 form-group"">
                            <label for=""Mensagem"" class=""control-label"">Mensagem</label>
                            <textarea style=""height: 150px"" id=""ContatoMensagem"" class=""form-control");
            WriteLiteral(@" input-email""></textarea>
                        </div>
                        <div class=""col-12 form-group"">
                            <button type=""button"" id=""btn-envia-msg"" class=""botao-contato w-100"">Enviar Mensagem</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            EndContext();
            BeginContext(7871, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1263355d472f82340ad13306dc0460783e0fb2615548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7927, 320, true);
            WriteLiteral(@"
<script>
    function BuscaProdutoDesktop() {
        var linkProduto = $(""#buscaProdutoDesktop"").val();
        var mercadoLivreHomeDTO = { ""linkProduto"": linkProduto };

        if (linkProduto.includes(""mercadolivre"")) {

                $.ajax({
                    type: ""GET"",
                    url: """);
            EndContext();
            BeginContext(8248, 41, false);
#line 162 "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\Home\Index.cshtml"
                     Write(Url.Action("GetMercadoLivreHome", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(8289, 3156, true);
            WriteLiteral(@""" + ""?link="" + linkProduto,
                    data: JSON.stringify(mercadoLivreHomeDTO),
                    contentType: ""application/json; charset=utf-8"",

                    success: function (infoProduto) {
                        var modal = document.getElementById('modalBody');

                        var html = '<h2>' + infoProduto.body.product.title + '</h2>';
                        html += '<img src=""' + infoProduto.body.product.pictures[0].url + '"" style=""width:200px;""/>';
                        html += '<h3>R$ ' + infoProduto.body.product.price + '</h3>';

                        html += '<h4>Reviews: ' + infoProduto.body.product.num_reviews  + ', média: ' + infoProduto.body.product.rating_average + '</h4>';
                        html += '<h4>Anúncio criado em:' + infoProduto.body.product.date_created + '</h4>';
                        //html += '<h4>Visitas ao produto: ' + infoProduto.body.product.visits + ' </h4>';
                        //html += '<h4>Vendeu ' + infoProdut");
            WriteLiteral(@"o.body.product.sold_quantity + ' de ' + infoProduto.body.product.initial_quantity + '</h4>';
                        //html += '<h4>Nota do produto: ' + infoProduto.body.product.health + '</h4>';

                        //var imagemProdutoRuim = infoProduto.body.product.tags.includes('poor_quality_picture');

                        //if (imagemProdutoRuim) {
                        //    html += '<h4>Nota da imagem: Ruim</h4>';
                        //} else {
                        //    html += '<h4>Nota da imagem: Boa</h4>';
                        //}

                        //html += '<h4>Quantidade de produtos encontrados do mesmo vendedor: ' + infoProduto.body.seller.products.length + '</h4>'


                        //for (i = 0; i < infoProduto.body.product.reviews.length; i++) {
                        //    html += '<h4>Título review: ' + infoProduto.body.product.reviews[i].title;
                        //    html += '<h4>Review: ' + infoProduto.body.product.reviews[i].conte");
            WriteLiteral(@"nt;
                        //    html += '<h4>Likes: ' + infoProduto.body.product.reviews[i].likes;
                        //    html += '<h4>Dislikes: ' + infoProduto.body.product.reviews[i].dislikes;
                        //    html += '<h4>Relevância: ' + infoProduto.body.product.reviews[i].relevance;
                        //    html += '<h4>Data da compra: ' + infoProduto.body.product.reviews[i].buying_date;
                        //}

                        modal.innerHTML = html;

                        console.log(infoProduto);
                    },
                    error: function (message) {
                        alert(""Erro: "" + message.responseText);
                    }
                });
        } else {
            var siteProprio = confirm(""O site é seu?"");

            if (siteProprio) {

            } else {
                alert(""Desculpe, mas atualmente só trabalhamos com o marketplace do Mercado Livre"");
            }
        }
    }

    function");
            WriteLiteral(" VaiParaPlanilha() {\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
            EndContext();
            BeginContext(11446, 32, false);
#line 221 "C:\Users\marce\source\repos\CompraInvest\CompraInvest\Views\Home\Index.cshtml"
             Write(Url.Action("GetPlanilha","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(11478, 291, true);
            WriteLiteral(@""",
            contentType: ""application/json; charset=utf-8"",

            success: function () {
                window.location.replace(""https://docs.google.com/spreadsheets/d/13xt7rX9-FLPsPWJ5S5AzHdsC4Grk_0UBWTE92oZI33M/edit#gid=0"");
            }
        });

    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
