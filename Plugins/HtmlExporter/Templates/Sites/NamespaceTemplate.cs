﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 12.0.0.0
//  
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpDox.Plugins.Html.Templates.Sites
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using SharpDox.Model.Repository;
    using SharpDox.Sdk.Config;
    using MarkdownSharp;
    using SharpDox.Sdk;
    using SharpDox.Plugins.Html.Templates.Strings;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class NamespaceTemplate : NamespaceTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write(@" 

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class=""no-js lt-ie9 lt-ie8 lt-ie7""> <![endif]-->
<!--[if IE 7]>         <html class=""no-js lt-ie9 lt-ie8""> <![endif]-->
<!--[if IE 8]>         <html class=""no-js lt-ie9""> <![endif]-->
<!--[if gt IE 8]><!--> <html class=""no-js""> <!--<![endif]-->
    <head>
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
        <title>");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Repository.ProjectInfo.ProjectName));
            
            #line default
            #line hidden
            this.Write(" - ");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write(@"</title>
        <meta name=""viewport"" content=""width=device-width"">

		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/reset.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/font.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/font-awesome.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/typography.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/layout.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/elements.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/markdown.css"" />
		<link rel=""stylesheet"" type=""text/css"" href=""../stylesheets/vs.css"" />

		<script src=""../js/vendor/jquery.js""></script>
		<script src=""../js/vendor/highlight.pack.js""></script>
		<script src=""../js/Iframe.js""></script>

		<script>hljs.initHighlightingOnLoad();</script>
    </head>
    <body>        
       
	   <div id=""documentation-wrapper"">
			<div id=""header"">
				<h2 class=""type-title"">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write("</h2>\n\t\t\t\t<span class=\"namespace-title\">Assembly: ");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace.Assemblyname));
            
            #line default
            #line hidden
            this.Write("</span>\n\t\t\t</div>\n\t\t\t<div id=\"pagecontent\">\n\t\t\t\t\t\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 if(Namespace.Description.Count != 0 && Namespace.Description.ContainsKey(CurrentLanguage)) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t<h3 class=\"box-title first-heading\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Description));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t\t<div class=\"divider\">\n\t\t\t\t\t<span></span>\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"" +
                    "text-box markdown\">\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
	var template = new Templater(Repository, Namespace.Description[CurrentLanguage]); 
							var helper = new Helper(Repository);
							var namespaceDescription = template.TransformText(helper.TransformLinkToken); 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(namespaceDescription)));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t</div>\n\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Types));
            
            #line default
            #line hidden
            this.Write("</h3>\n\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t\t<h3 class=\"box-title first-heading\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Types));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t\t<div class=\"divider\">\n\t\t\t\t\t<span></span>\n\t\t\t\t\t</div>\n\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t<div class=\"table-box\">\n\t\t\t\t\t<table>\n\t\t\t\t\t\t<thead>\n\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t<td>" +
                    "</td>\n\t\t\t\t\t\t\t\t<td>Name</td>\n\t\t\t\t\t\t\t\t<td>Description</td>\n\t\t\t\t\t\t\t</tr>\n\t\t\t\t\t\t</th" +
                    "ead>\n\t\t\t\t\t\t<tbody>\t\t\t\n\n\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 var even = false; 
							foreach(var type in Namespace.Types) { 
								var sdType = (SDType)Repository.GetTypeByIdentifier(type.Identifier); 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t\t\t\t\t<tr ");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 if(even) { even = false; 
            
            #line default
            #line hidden
            this.Write(" class=\"even\" ");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } else { even = true; } 
            
            #line default
            #line hidden
            this.Write(">\n\t\t\t\t\t\t\t\t\t<td class=\"iconColumn\">\n\t\t\t\t\t\t\t\t\t\t<img alt=\"Class-Icon\" src=\"../images" +
                    "/icons/Class_");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Accessibility));
            
            #line default
            #line hidden
            this.Write(".png\">\n\t\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t\t\t<a title=\"");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Name));
            
            #line default
            #line hidden
            this.Write("\" href=\"../type/");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Name));
            
            #line default
            #line hidden
            this.Write("</a>\n\t\t\t\t\t\t\t\t\t</td>\t\n\t\t\t\t\t\t\t\t\t<td class=\"markdown\">\n\t\t\t\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 if(sdType.Documentation.ContainsKey(CurrentLanguage)) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(sdType.Documentation[CurrentLanguage].Summary.ToString())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t</tr>\n\n\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t\t\t</tbody>\n\t\t\t\t\t</table>\n\t\t\t\t</div>\n\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 if(Namespace.Uses.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Uses));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t\t<div class=\"list-box\">\n\t\t\t\t\t\t<ul>\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 foreach(var use in Namespace.Uses) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t<li><a href=\"../namespace/");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(use.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(use.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t</ul>\n\t\t\t\t\t</div>\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 if(Namespace.UsedBy.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.UsedBy));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t\t<div class=\"list-box\">\n\t\t\t\t\t\t<ul>\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 foreach(var used in Namespace.UsedBy) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t<li><a href=\"../namespace/");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(used.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(used.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li>\n\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t</ul>\n\t\t\t\t\t</div>\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t</div>\n\t\t</div>\n\t   \n    </body>\n</html>\n\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\ZP620933\Downloads\sharpDox-dev\Plugins\HtmlExporter\Templates\Sites\NamespaceTemplate.tt"
 public IStrings Strings { get; set; }
	public string CurrentLanguage { get; set; }
	public SDRepository Repository { get; set; }
    public SDNamespace Namespace { get; set; } 
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class NamespaceTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}