#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilentNotes.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "SettingsRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.6.0.1061")]
public partial class SettingsRazorView : SettingsRazorViewBase
{

#line hidden

#line 2 "SettingsRazorView.cshtml"
public SettingsViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <base");

WriteAttribute ("href", " href=\"", "\""

#line 7 "SettingsRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlBase

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n    <title>SilentNotes</title>\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no, user-scalable=no" +
"\"");

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" href=\"bootstrap.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"silentnotes.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute ("href", " href=\"", "\""

#line 14 "SettingsRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Theme.DarkMode ? "silentnotes.dark.css" : "silentnotes.light.css"

#line default
#line hidden
, false)
);
WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteLiteral(" src=\"vue.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"jquery-3.4.1.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"bootstrap.bundle.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"silentnotes.js\"");

WriteLiteral("></script>\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(@">
        .background-icon {
            right: -128px;
            top: -154px;
        }

        #theme-control {
            height: 90px;
        }

        #color-control {
            height: 50px;
        }

        .theme-preview,
        .color-preview {
            width: 340px;
            max-width: calc(100% - 36px);
        }

        .theme-list,
        .color-list {
            max-height: 360px;
            overflow-y: scroll;
        }

        .theme-item,
        .color-item {
            display: inline-block;
            width: 90px;
            height: 128px;
        }

        .color-btn { color: black; }
        .color-btn.dark { color: white; }
    </style>
    <script>
");


#line 58 "SettingsRazorView.cshtml"
        

#line default
#line hidden

#line 58 "SettingsRazorView.cshtml"
          WriteLiteral(Model.VueDataBindingScript);

#line default
#line hidden
WriteLiteral("\r\n    </script>\r\n</head>\r\n<body><div");

WriteLiteral(" id=\"vueDataBinding\"");

WriteLiteral(">\r\n    <nav");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(" class=\"d-flex\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"nav-item mr-auto shortcut-escape\"");

WriteLiteral(" v-on:click=\"GoBackCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 63 "SettingsRazorView.cshtml"
                                                    , Tuple.Create<string,object,bool> ("", Model.Language["back"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 63 "SettingsRazorView.cshtml"
                                                                                                                      WriteLiteral(Model.Icon["arrow-left"]);

#line default
#line hidden
WriteLiteral("</button>\r\n    </nav>\r\n\r\n    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"container-fluid p-4\"");

WriteLiteral(">\r\n        <svg");

WriteLiteral(" class=\"background-icon\"");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-settings\"");

WriteLiteral(" /></svg>\r\n\r\n        <h2>");


#line 69 "SettingsRazorView.cshtml"
       Write(Model.Language["gui"]);


#line default
#line hidden
WriteLiteral("</h2>\r\n        <form");

WriteLiteral(" class=\"mb-4 col-md-9 col-lg-6\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"FontSizeStep\"");

WriteLiteral(">");


#line 72 "SettingsRazorView.cshtml"
                                                            Write(Model.Language["gui_font_size"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"custom-range col-sm-6\"");

WriteLiteral(" type=\"range\"");

WriteLiteral(" id=\"FontSizeStep\"");

WriteLiteral(" v-model=\"FontSizeStep\"");

WriteLiteral(" min=\"-3\"");

WriteLiteral(" max=\"3\"");

WriteLiteral(" step=\"1\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"Theme\"");

WriteLiteral(">");


#line 78 "SettingsRazorView.cshtml"
                                                     Write(Model.Language["gui_texture"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" id=\"theme-control\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"Theme\"");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" class=\"theme-preview btn m-0 h-100\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" v-bind:style=\"{ backgroundImage: \'url(\' + SelectedThemeImage + \')\' }\"");

WriteLiteral(">\r\n                        </button>\r\n                        <div");

WriteLiteral(" class=\"dropdown-menu theme-list\"");

WriteLiteral(" aria-labelledby=\"themeChooser\"");

WriteLiteral(">\r\n");


#line 84 "SettingsRazorView.cshtml"
                            

#line default
#line hidden

#line 84 "SettingsRazorView.cshtml"
                             foreach (var theme in @Model.Theme.Themes)
                            {


#line default
#line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"dropdown-item theme-item\"");

WriteAttribute ("v-on:click", " v-on:click=\"", "\""
, Tuple.Create<string,object,bool> ("", "SelectedTheme=\'", true)

#line 86 "SettingsRazorView.cshtml"
                                                           , Tuple.Create<string,object,bool> ("", theme.Id

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "\'", true)
);
WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "background:", true)
, Tuple.Create<string,object,bool> (" ", "url(", true)

#line 86 "SettingsRazorView.cshtml"
                                                                                                , Tuple.Create<string,object,bool> ("", theme.Image

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", ");", true)
);
WriteLiteral("></div>\r\n");


#line 87 "SettingsRazorView.cshtml"
                            }


#line default
#line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n                </div" +
">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group col-10\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"UseSolidColorTheme\"");

WriteLiteral(" v-model=\"UseSolidColorTheme\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(" for=\"UseSolidColorTheme\"");

WriteLiteral(">");


#line 96 "SettingsRazorView.cshtml"
                                                                            Write(Model.Language["gui_theme_solid_color"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" class=\"form-group col-2\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"color\"");

WriteLiteral(" v-model=\"ColorForSolidThemeHex\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" v-model=\"SelectedThemeMode\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"Auto\"");

WriteLiteral(">");


#line 105 "SettingsRazorView.cshtml"
                                    Write(Model.Language["gui_theme_auto"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                    <option");

WriteLiteral(" value=\"Dark\"");

WriteLiteral(">");


#line 106 "SettingsRazorView.cshtml"
                                    Write(Model.Language["gui_theme_dark"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                    <option");

WriteLiteral(" value=\"Light\"");

WriteLiteral(">");


#line 107 "SettingsRazorView.cshtml"
                                     Write(Model.Language["gui_theme_light"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group col-10\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"UseColorForAllNotesInDarkMode\"");

WriteLiteral(" v-model=\"UseColorForAllNotesInDarkMode\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(" for=\"UseColorForAllNotesInDarkMode\"");

WriteLiteral(">");


#line 114 "SettingsRazorView.cshtml"
                                                                                       Write(Model.Language["gui_theme_color_all_dark"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <di" +
"v");

WriteLiteral(" class=\"form-group col-2\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" type=\"color\"");

WriteLiteral(" v-model=\"ColorForAllNotesInDarkModeHex\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"Color\"");

WriteLiteral(">");


#line 123 "SettingsRazorView.cshtml"
                                                     Write(Model.Language["gui_default_color"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" id=\"color-control\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"DefaultNoteColor\"");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" id=\"Color\"");

WriteLiteral(" class=\"color-preview btn m-0 h-100\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(" v-bind:style=\"{ backgroundColor: DefaultNoteColorHex }\"");

WriteLiteral(">\r\n                        </button>\r\n                        <div");

WriteLiteral(" class=\"dropdown-menu color-list\"");

WriteLiteral(" aria-labelledby=\"colorChooser\"");

WriteLiteral(">\r\n");


#line 129 "SettingsRazorView.cshtml"
                            

#line default
#line hidden

#line 129 "SettingsRazorView.cshtml"
                             foreach (var backgroundColor in @Model.NoteColorsHex)
                            {


#line default
#line hidden
WriteLiteral("                                <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "dropdown-item", true)
, Tuple.Create<string,object,bool> (" ", "color-btn", true)

#line 131 "SettingsRazorView.cshtml"
                            , Tuple.Create<string,object,bool> (" ", Model.GetDarkClass(backgroundColor)

#line default
#line hidden
, false)
);
WriteAttribute ("v-on:click", " v-on:click=\"", "\""
, Tuple.Create<string,object,bool> ("", "DefaultNoteColorHex=\'", true)

#line 131 "SettingsRazorView.cshtml"
                                                                                                    , Tuple.Create<string,object,bool> ("", backgroundColor

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "\'", true)
);
WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "background-color:", true)

#line 131 "SettingsRazorView.cshtml"
                                                                                                                                               , Tuple.Create<string,object,bool> (" ", backgroundColor

#line default
#line hidden
, false)
);
WriteLiteral(">Lorem ipsum</div>\r\n");


#line 132 "SettingsRazorView.cshtml"
                            }


#line default
#line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n                </div" +
">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"SelectedNoteInsertionMode\"");

WriteLiteral(">");


#line 138 "SettingsRazorView.cshtml"
                                                                         Write(Model.Language["gui_note_insertion"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"SelectedNoteInsertionMode\"");

WriteLiteral(" v-model=\"SelectedNoteInsertionMode\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"AtTop\"");

WriteLiteral(">");


#line 140 "SettingsRazorView.cshtml"
                                     Write(Model.Language["gui_note_insertion_top"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                    <option");

WriteLiteral(" value=\"AtBottom\"");

WriteLiteral(">");


#line 141 "SettingsRazorView.cshtml"
                                        Write(Model.Language["gui_note_insertion_bottom"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n        </form>\r\n\r\n    " +
"    <h2>");


#line 146 "SettingsRazorView.cshtml"
       Write(Model.Language["encryption"]);


#line default
#line hidden
WriteLiteral("</h2>\r\n        <form");

WriteLiteral(" class=\"mb-4 col-md-9 col-lg-6\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"SelectedEncryptionAlgorithm\"");

WriteLiteral(">");


#line 149 "SettingsRazorView.cshtml"
                                                                           Write(Model.Language["encryption_algorithm"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"SelectedEncryptionAlgorithm\"");

WriteLiteral(" v-model=\"SelectedEncryptionAlgorithm\"");

WriteLiteral(">\r\n");


#line 151 "SettingsRazorView.cshtml"
                    

#line default
#line hidden

#line 151 "SettingsRazorView.cshtml"
                     foreach (var algorithm in @Model.EncryptionAlgorithms)
                    {


#line default
#line hidden
WriteLiteral("                        <option");

WriteAttribute ("value", " value=\"", "\""

#line 153 "SettingsRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", algorithm.Value

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 153 "SettingsRazorView.cshtml"
                                                    Write(algorithm.Description);


#line default
#line hidden
WriteLiteral("</option>\r\n");


#line 154 "SettingsRazorView.cshtml"
                    }


#line default
#line hidden
WriteLiteral("                </select>\r\n            </div>\r\n        </form>\r\n\r\n        <h2>");


#line 159 "SettingsRazorView.cshtml"
       Write(Model.Language["sync"]);


#line default
#line hidden
WriteLiteral("</h2>\r\n        <form");

WriteLiteral(" class=\"mb-4 col-md-9 col-lg-6\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"SelectedAutoSyncMode\"");

WriteLiteral(">");


#line 162 "SettingsRazorView.cshtml"
                                                                    Write(Model.Language["sync_auto"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"SelectedAutoSyncMode\"");

WriteLiteral(" v-model=\"SelectedAutoSyncMode\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"Never\"");

WriteLiteral(">");


#line 164 "SettingsRazorView.cshtml"
                                     Write(Model.Language["sync_auto_never"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                    <option");

WriteLiteral(" value=\"CostFreeInternetOnly\"");

WriteLiteral(">");


#line 165 "SettingsRazorView.cshtml"
                                                    Write(Model.Language["sync_auto_costfree"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                    <option");

WriteLiteral(" value=\"Always\"");

WriteLiteral(">");


#line 166 "SettingsRazorView.cshtml"
                                      Write(Model.Language["sync_auto_always"]);


#line default
#line hidden
WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"form-row form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"col-form-label\"");

WriteLiteral(" for=\"CloudStorageSettings\"");

WriteLiteral(">");


#line 170 "SettingsRazorView.cshtml"
                                                                    Write(Model.Language["cloud_service"]);


#line default
#line hidden
WriteLiteral("</label>\r\n                <textarea");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"CloudStorageSettings\"");

WriteLiteral(" v-once");

WriteLiteral(" v-model=\"AccountSummary\"");

WriteLiteral(" rows=\"4\"");

WriteLiteral(" readonly></textarea>\r\n            </div>\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-secondary mb-2\"");

WriteLiteral(" v-on:click=\"ChangeCloudSettingsCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 173 "SettingsRazorView.cshtml"
                                                                         , Tuple.Create<string,object,bool> ("", Model.Language["cloud_change_settings_desc"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 173 "SettingsRazorView.cshtml"
                                                                                                                                                          Write(Model.Language["cloud_change_settings"]);


#line default
#line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-secondary mb-2\"");

WriteLiteral(" v-on:click=\"ClearCloudSettingsCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 174 "SettingsRazorView.cshtml"
                                                                        , Tuple.Create<string,object,bool> ("", Model.Language["cloud_clear_settings_desc"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 174 "SettingsRazorView.cshtml"
                                                                                                                                                        Write(Model.Language["cloud_clear_settings"]);


#line default
#line hidden
WriteLiteral("</button>\r\n        </form>\r\n    </div>\r\n\r\n    <div hidden>\r\n");


#line 179 "SettingsRazorView.cshtml"
        

#line default
#line hidden

#line 179 "SettingsRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("settings", new[] { new KeyValuePair<string, string>("id", "svg-settings") }));

#line default
#line hidden
WriteLiteral("\r\n    </div>\r\n</div></body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class SettingsRazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
