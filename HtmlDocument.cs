using System;
using System.Text;
using ManagerExtensions.Html;

namespace ManagerExtensions
{
    public abstract class HtmlDocument
    {
        private StringBuilder sb = new StringBuilder();

        public void Write(string s)
        {
            sb.Append(s);
        }

        public void string GetHtml()
        {
            return sb.ToString();
        }

        public Html.Html Html() { return new Html.Html(sb: this.sb); }
        public void Hr() { Write("<hr />"); }
        public void Br() { Write("<br />"); }
        public void Title(string title) { Write("<title>" + title + "</title>"); }
        public Head Head() { return new Head(sb: this.sb); }
        public Legend Legend() { return new Legend(sb: this.sb); }
        public Style Style() { return new Style(sb: this.sb); }
        public Pre Pre(string id = null, string @class = null, string style = null) { return new Pre(sb: this.sb, id: id, @class: @class, style: style); }
        public Code Code(string id = null, string @class = null, string style = null) { return new Code(sb: this.sb, id: id, @class: @class, style: style); }
        public H1 H1(string id = null, string @class = null, string style = null, string dataBind = null) { return new H1(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public H2 H2(string id = null, string @class = null, string style = null, string dataBind = null) { return new H2(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public H3 H3(string id = null, string @class = null, string style = null, string dataBind = null) { return new H3(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public H4 H4(string id = null, string @class = null, string style = null, string dataBind = null) { return new H4(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public H5 H5(string id = null, string @class = null, string style = null, string dataBind = null) { return new H5(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public H6 H6(string id = null, string @class = null, string style = null, string dataBind = null) { return new H6(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public void LinkStylesheet(string href) { Write(@"<link rel=""stylesheet"" type=""text/css"" href=""" + href + @""" />"); }
        public Script Script() { return new Script(sb: this.sb); }
        public void Script(string src) { Write(@"<script src=""" + src + @""" type=""text/javascript""></script>"); }
        public Body Body(string style = null) { return new Body(sb: this.sb, style: style); }
        public Fieldset Fieldset(string id = null, string @class = null, string style = null, string dataBind = null, string legend = null) { return new Fieldset(sb: this.sb, id: id, @class: @class, style: style, legend: legend, dataBind: dataBind); }
        public IFrame IFrame(string src = null, string name = null, string id = null, string @class = null, string style = null, string dataBind = null, bool? frameBorder = null, string onload = null, bool? scrolling = null) { return new IFrame(sb: this.sb, src: src, name: name, id: id, @class: @class, style: style, dataBind: dataBind, frameBorder: frameBorder, onload: onload, scrolling: scrolling); }
        public Div Div(string id = null, string @class = null, string style = null, string dataBind = null, string[] data = null) { return new Div(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind, data: data); }
        public A A(string href = null, string id = null, string @class = null, string style = null, string title = null, string dataBind = null, string accessKey = null, int? tabIndex = null, string target = null, string rev = null, string rel = null, string name = null, string onclick = null, string itemprop = null, string role = null, Tuple<string, string>[] data = null) { return new A(sb: this.sb, href: href, id: id, @class: @class, style: style, title: title, accessKey: accessKey, tabIndex: tabIndex, target: target, rev: rev, rel: rel, name: name, onclick: onclick, itemprop: itemprop, dataBind: dataBind, data: data); }
        public Span Span(string id = null, string @class = null, string style = null, string title = null, string dataBind = null, Tuple<string, string>[] data = null) { return new Span(sb: this.sb, id: id, @class: @class, style: style, title: title, dataBind: dataBind, data: data); }
        public P P(string id = null, string @class = null, string style = null, string title = null, string dataBind = null) { return new P(sb: this.sb, id: id, @class: @class, style: style, title: title, dataBind: dataBind); }
        public Ul Ul(string id = null, string @class = null, string style = null, string dataBind = null) { return new Ul(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public Ol Ol(string id = null, string @class = null, string style = null, string dataBind = null) { return new Ol(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public Li Li(string id = null, string @class = null, string style = null, string dataBind = null) { return new Li(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public Label Label(string id = null, string @class = null, string style = null, string @for = null, string dataBind = null, string title = null) { return new Label(sb: this.sb, id: id, @class: @class, style: style, @for: @for, dataBind: dataBind, title: title); }
        public TBody TBody(string dataBind = null) { return new TBody(sb: this.sb, dataBind: dataBind); }
        public THead THead() { return new THead(sb: this.sb); }
        public TFoot TFoot() { return new TFoot(sb: this.sb); }
        public Select Select(string id = null, string @class = null, string style = null, string dataBind = null, bool? multiple = null, string name = null, bool disabled = false, Tuple<string, string>[] data = null) { return new Select(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind, multiple: multiple, name: name, disabled: disabled, data: data); }
        public Button Button(string id = null, string @class = null, string style = null, string dataBind = null, string onclick = null, string title = null, string type = null, params string[] data) { return new Button(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind, onclick: onclick, title: title, type: type, data: data); }
        public OptGroup OptGroup(string id = null, string @class = null, string style = null, string dataBind = null, string label = null, Tuple<string, string>[] data = null) { return new OptGroup(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind, label: label, data: data); }
        public Table Table(string id = null, string @class = null, string style = null, string dataBind = null) { return new Table(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind); }
        public Tr Tr(string id = null, string @class = null, string style = null, string dataBind = null, params string[] data) { return new Tr(sb: this.sb, id: id, @class: @class, style: style, dataBind: dataBind, data: data); }
        public Td Td(string id = null, string @class = null, string style = null, string dataBind = null, int? colspan = null, int? rowspan = null) { return new Td(sb: this.sb, id: id, @class: @class, style: style, colspan: colspan, rowspan: rowspan, dataBind: dataBind); }
        public Th Th(string id = null, string @class = null, string style = null, string dataBind = null, int? colspan = null, int? rowspan = null) { return new Th(sb: this.sb, id: id, @class: @class, style: style, colspan: colspan, rowspan: rowspan, dataBind: dataBind); }

        public void Meta(string name = null, string content = null)
        {
            string output = @"<meta";
            if (name != null) output += @" name=""" + name + @"""";
            if (content != null) output += @" content=""" + content + @"""";
            output += " />";
            Write(output);
        }

        public void Img(string src = null, string style = null, string @class = null, string id = null, string alt = null, string itemprop = null, string dataBind = null, string[] data = null)
        {
            string output = @"<img";
            if (src != null) output += @" src=""" + src + @"""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (alt != null) output += @" alt=""" + alt + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (itemprop != null) output += @" itemprop=""" + itemprop + @"""";
            if (data != null)
            {
                foreach (var e in data)
                {
                    if (string.IsNullOrWhiteSpace(e)) continue;
                    var keyValue = e.Split('=');
                    var dataKey = keyValue[0];
                    var dataValue = (keyValue.Length > 0) ? keyValue[1] : "";
                    output += @" data-" + dataKey + @"=""" + dataValue + @"""";
                }
            }
            output += " />";
            Write(output);
        }

        public void Option(string id = null, string @class = null, string style = null, string value = null, bool? selected = null, string text = null, string disabled = null, string dataBind = null, Tuple<string, string>[] data = null)
        {
            string output = @"<option";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (disabled != null) output += @" disabled=""" + disabled + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (selected != null && selected.Value) output += @" selected=""selected""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            if (text != null) output += text;
            output += "</option>";
            Write(output);
        }

        public void Textarea(string id = null, string @class = null, string style = null, string name = null, int? tabindex = null, string text = null, string placeholder = null, string dataBind = null, Tuple<string, string>[] data = null, bool? spellcheck = null, bool @readonly = false)
        {
            string output = @"<textarea";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (placeholder != null) output += @" placeholder=""" + placeholder + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (spellcheck.HasValue) output += @" spellcheck=""" + (spellcheck.Value ? "true" : "false") + @"""";
            if (@readonly) output += @" readonly=""readonly""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            if (text != null) output += text;//text.Replace(System.Environment.NewLine, "&#10;");
            output += "</textarea>";
            Write(output);
        }

        public void InputHidden(string id = null, string name = null, string value = null, string style = null, string dataBind = null, string @class = null, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""hidden""";
            if (id != null) output += @" id=""" + id + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (value != null) output += @" value=""" + System.Net.WebUtility.HtmlEncode(value) + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputText(string id = null, string @class = null, int? maxlength = null, string style = null, string name = null, string value = null, bool @readonly = false, string placeholder = null, string dataBind = null, int? tabindex = null, bool autofocus = false, bool? autocomplete = null, bool? autocorrect = null, bool? autocapitalize = null, bool? spellcheck = null, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""text""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (value != null) output += @" value=""" + System.Net.WebUtility.HtmlEncode(value) + @"""";
            if (placeholder != null) output += @" placeholder=""" + placeholder + @"""";
            if (@readonly) output += @" readonly=""readonly""";
            if (maxlength != null) output += @" maxlength=""" + maxlength.Value + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (autofocus) output += @" autofocus";
            if (autocomplete.HasValue && !autocomplete.Value) output += @" autocomplete=""off""";
            if (autocorrect.HasValue && !autocorrect.Value) output += @" autocorrect=""off""";
            if (autocapitalize.HasValue && !autocapitalize.Value) output += @" autocapitalize=""off""";
            if (spellcheck.HasValue && !spellcheck.Value) output += @" spellcheck=""off""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputDate(string id = null, string @class = null, string style = null, string name = null, int? tabindex = null, DateTime? value = null, bool @readonly = false, string dataBind = null, string placeholder = null, Tuple<string, string>[] data = null)
        {
            if (!@readonly) @class = "date " + @class;
            if (@class != null) @class = @class.Trim();
            string output = @"<input type=""text""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (value != null) output += @" value=""" + value.Value.ToString(System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.ShortDatePattern) + @"""";
            if (placeholder != null) output += @" placeholder=""" + placeholder + @"""";
            if (@readonly) output += @" readonly=""readonly""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputFile(string id = null, string @class = null, string style = null, string name = null, int? tabindex = null, string dataBind = null, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""file""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputRadio(string id = null, string @class = null, string style = null, string name = null, string value = null, int? tabindex = null, bool? @checked = null, string dataBind = null, Tuple<string, string>[] data = null, string onclick = null)
        {
            string output = @"<input type=""radio""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (onclick != null) output += @" onclick=""" + onclick + @"""";
            if (@checked != null && @checked.Value) output += @" checked=""checked""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputButton(string id = null, string @class = null, string style = null, string name = null, int? tabindex = null, string value = null, string dataBind = null, string onclick = null, string[] data = null)
        {
            string output = @"<input type=""button""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (onclick != null) output += @" onclick=""" + onclick + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null)
            {
                foreach (var e in data)
                {
                    if (string.IsNullOrWhiteSpace(e)) continue;
                    var keyValue = e.Split('=');
                    var dataKey = keyValue[0];
                    var dataValue = (keyValue.Length > 0) ? keyValue[1] : "";
                    output += @" data-" + dataKey + @"=""" + dataValue + @"""";
                }
            }
            output += " />";
            Write(output);
        }

        public void InputSubmit(string id = null, string @class = null, string style = null, string name = null, int? tabindex = null, string value = null, string dataBind = null, string onClick = null, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""submit""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (onClick != null) output += @" onClick=""" + onClick + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputCheckbox(string id = null, string @class = null, string style = null, string name = null, string value = null, int? tabindex = null, bool? @checked = null, string dataBind = null, bool? disabled = null, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""checkbox""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (disabled != null && disabled.Value) output += @" disabled=""disabled""";
            if (@checked != null && @checked.Value) output += @" checked=""checked""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }

        public void InputPassword(string id = null, string @class = null, int? maxlength = null, string style = null, string name = null, int? tabindex = null, string value = null, string dataBind = null, string placeholder = null, bool autofocus = false, Tuple<string, string>[] data = null)
        {
            string output = @"<input type=""password""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (value != null) output += @" value=""" + value + @"""";
            if (tabindex != null) output += @" tabindex=""" + tabindex.Value.ToString() + @"""";
            if (placeholder != null) output += @" placeholder=""" + placeholder + @"""";
            if (maxlength != null) output += @" maxlength=""" + maxlength.Value + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (autofocus) output += @" autofocus";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += " />";
            Write(output);
        }
    }

    public enum TableRules
    {
        None,
        Groups,
        Rows,
        Cols,
        All
    }

    public enum Enctype
    {
        applicationxwwwformurlencoded,
        multipartformdata,
        textplain
    }
}

namespace ManagerExtensions.Html
{
    public sealed class Legend : IDisposable
    {
        private StringBuilder sb;

        internal Legend(StringBuilder sb = null)
        {
            this.sb = sb;
            string output = @"<legend>";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</legend>");
        }
    }

    public sealed class Table : IDisposable
    {
        private StringBuilder sb;

        internal Table(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null)
        {
            this.sb = sb;
            string output = @"<table";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</table>");
        }
    }

    public sealed class TBody : IDisposable
    {
        private StringBuilder sb;

        public TBody(StringBuilder sb = null, string dataBind = null)
        {
            this.sb = sb;
            string output = @"<tbody";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</tbody>");
        }
    }

    public sealed class Td : IDisposable
    {
        private StringBuilder sb;

        public Td(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, int? rowspan = null, int? colspan = null)
        {
            this.sb = sb;
            string output = @"<td";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (rowspan != null) output += @" rowspan=""" + rowspan.Value.ToString() + @"""";
            if (colspan != null) output += @" colspan=""" + colspan.Value.ToString() + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</td>");
        }
    }

    public sealed class TFoot : IDisposable
    {
        private StringBuilder sb;

        public TFoot(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<tfoot>");
        }

        public void Dispose()
        {
            sb.Append(@"</tfoot>");
        }
    }

    public sealed class Pre : IDisposable
    {
        private StringBuilder sb;

        public Pre(StringBuilder sb = null, string id = null, string @class = null, string style = null)
        {
            this.sb = sb;
            string output = @"<pre";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</pre>");
        }
    }

    public sealed class Code : IDisposable
    {
        private StringBuilder sb;

        public Code(StringBuilder sb = null, string id = null, string @class = null, string style = null)
        {
            this.sb = sb;
            string output = @"<code";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</code>");
        }
    }

    public sealed class H1 : IDisposable
    {
        private StringBuilder sb;

        public H1(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h1";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h1>");
        }
    }

    public sealed class H2 : IDisposable
    {
        private StringBuilder sb;

        public H2(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h2";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h2>");
        }
    }

    public sealed class H3 : IDisposable
    {
        private StringBuilder sb;

        public H3(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h3";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h3>");
        }
    }

    public sealed class H4 : IDisposable
    {
        private StringBuilder sb;

        public H4(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h4";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h4>");
        }
    }

    public sealed class H5 : IDisposable
    {
        private StringBuilder sb;

        public H5(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h5";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h5>");
        }
    }

    public sealed class H6 : IDisposable
    {
        private StringBuilder sb;

        public H6(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<h6";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</h6>");
        }
    }

    public sealed class Th : IDisposable
    {
        private StringBuilder sb;

        public Th(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, int? rowspan = null, int? colspan = null)
        {
            this.sb = sb;
            string output = @"<th";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (rowspan != null) output += @" rowspan=""" + rowspan.Value.ToString() + @"""";
            if (colspan != null) output += @" colspan=""" + colspan.Value.ToString() + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</th>");
        }
    }

    public sealed class THead : IDisposable
    {
        private StringBuilder sb;

        public THead(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<thead>");
        }

        public void Dispose()
        {
            sb.Append(@"</thead>");
        }
    }

    public sealed class Tr : IDisposable
    {
        private StringBuilder sb;

        public Tr(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null, string[] data = null)
        {
            this.sb = sb;
            string output = @"<tr";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null)
            {
                foreach (var e in data)
                {
                    if (string.IsNullOrWhiteSpace(e)) continue;
                    var keyValue = e.Split('=');
                    var dataKey = keyValue[0];
                    var dataValue = (keyValue.Length > 0) ? keyValue[1] : "";
                    output += @" data-" + dataKey + @"=""" + dataValue + @"""";
                }
            }
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</tr>");
        }
    }

    public sealed class Ul : IDisposable
    {
        private StringBuilder sb;

        public Ul(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<ul";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</ul>");
        }
    }

    public sealed class Html : IDisposable
    {
        private StringBuilder sb;

        public Html(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<!DOCTYPE html>");
            sb.Append(@"<html moznomarginboxes mozdisallowselectionprint>");
        }

        public void Dispose()
        {
            sb.Append(@"</html>");
        }
    }

    public sealed class Label : IDisposable
    {
        private StringBuilder sb;

        public Label(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string @for = null, string title = null)
        {
            this.sb = sb;
            string output = @"<label";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (@for != null) output += @" for=""" + @for + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (title != null) output += @" title=""" + title + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</label>");
        }
    }

    public sealed class Li : IDisposable
    {
        private StringBuilder sb;

        public Li(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<li";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</li>");
        }
    }

    public sealed class Ol : IDisposable
    {
        private StringBuilder sb;

        public Ol(StringBuilder sb = null, string id = null, string @class = null, string dataBind = null, string style = null)
        {
            this.sb = sb;
            string output = @"<ol";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</ol>");
        }
    }

    public sealed class OptGroup : IDisposable
    {
        private StringBuilder sb;

        public OptGroup(StringBuilder sb = null, string id = null, string @class = null, string style = null, string @label = null, string dataBind = null, Tuple<string, string>[] data = null)
        {
            this.sb = sb;
            string output = @"<optgroup";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (label != null) output += @" label=""" + label + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</optgroup>");
        }
    }

    public sealed class P : IDisposable
    {
        private StringBuilder sb;

        public P(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string title = null)
        {
            this.sb = sb;
            string output = @"<p";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (title != null) output += @" title=""" + title + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</p>");
        }
    }

    public sealed class Script : IDisposable
    {
        private StringBuilder sb;

        public Script(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<script type=""text/javascript"">");
        }

        public void Dispose()
        {
            sb.Append(@"</script>");
        }
    }

    public sealed class Select : IDisposable
    {
        private StringBuilder sb;

        public Select(StringBuilder sb = null, string id = null, string @class = null, string style = null, bool? multiple = null, string name = null, string dataBind = null, bool disabled = false, Tuple<string, string>[] data = null)
        {
            this.sb = sb;
            string output = @"<select";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (multiple != null && multiple.Value) output += @" multiple=""multiple""";
            if (name != null) output += @" name=""" + name + @"""";
            if (disabled) output += @" disabled=""disabled""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</select>");
        }
    }

    public sealed class Button : IDisposable
    {
        private StringBuilder sb;

        public Button(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string title = null, string onclick = null, string type = null, params string[] data)
        {
            this.sb = sb;
            string output = @"<button";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (title != null) output += @" title=""" + title + @"""";
            if (type != null) output += @" type=""" + type + @"""";
            if (onclick != null) output += @" onclick=""" + onclick + @"""";
            if (data != null)
            {
                foreach (var e in data)
                {
                    if (string.IsNullOrWhiteSpace(e)) continue;
                    var keyValue = e.Split('=');
                    var key = keyValue[0];
                    var value = (keyValue.Length > 0) ? keyValue[1] : "";
                    output += @" data-" + key + @"=""" + value + @"""";
                }
            }
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</button>");
        }
    }

    public sealed class Span : IDisposable
    {
        private StringBuilder sb;

        public Span(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string title = null, Tuple<string, string>[] data = null)
        {
            this.sb = sb;
            string output = @"<span";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (title != null) output += @" title=""" + title + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</span>");
        }
    }

    public sealed class Style : IDisposable
    {
        private StringBuilder sb;

        public Style(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<style>");
        }

        public void Dispose()
        {
            sb.Append(@"</style>");
        }
    }

    public sealed class A : IDisposable
    {
        private StringBuilder sb;

        public A(StringBuilder sb = null, string href = null, string id = null, string @class = null, string style = null, string title = null, string dataBind = null, string accessKey = null, int? tabIndex = null, string target = null, string rev = null, string rel = null, string name = null, string onclick = null, string itemprop = null, string role = null, Tuple<string, string>[] data = null)
        {
            this.sb = sb;
            string output = @"<a";
            if (href != null) output += @" href=""" + href + @"""";
            if (title != null) output += @" title=""" + title + @"""";
            if (accessKey != null) output += @" accessKey=""" + accessKey + @"""";
            if (tabIndex != null) output += @" tabIndex=""" + tabIndex + @"""";
            if (target != null) output += @" target=""" + target + @"""";
            if (rev != null) output += @" rev=""" + rev + @"""";
            if (rel != null) output += @" rel=""" + rel + @"""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (onclick != null) output += @" onclick=""" + onclick + @"""";
            if (itemprop != null) output += @" itemprop=""" + itemprop + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (role != null) output += @" role=""" + role + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null) foreach (var e in data) output += @" data-" + e.Item1 + @"=""" + e.Item2 + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</a>");
        }
    }

    public sealed class Body : IDisposable
    {
        private StringBuilder sb;

        public Body(StringBuilder sb = null, string style = null)
        {
            this.sb = sb;
            string output = @"<body";
            if (style != null) output += @" style=""" + style + @"""";
            output += ">";
            sb.Append(output);

        }

        public void Dispose()
        {
            sb.Append(@"</body>");
        }
    }

    public sealed class Comment : IDisposable
    {
        private StringBuilder sb;

        public Comment(StringBuilder sb = null)
        {
            this.sb = sb;
            string output = @"<!--";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"-->");
        }
    }

    public sealed class IFrame : IDisposable
    {
        private StringBuilder sb;

        public IFrame(StringBuilder sb = null, string src = null, string name = null, string id = null, string @class = null, string dataBind = null, string style = null, bool? frameBorder = null, string onload = null, bool? scrolling = null)
        {
            this.sb = sb;
            string output = @"<iframe";
            if (src != null) output += @" src=""" + src + @"""";
            if (name != null) output += @" name=""" + name + @"""";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (onload != null) output += @" onload=""" + onload + @"""";
            if (frameBorder != null) output += @" frameBorder=""" + (frameBorder.Value ? "1" : "0") + @"""";
            if (scrolling != null) output += @" scrolling=""" + (scrolling.Value ? "yes" : "no") + @"""";
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</iframe>");
        }
    }

    public sealed class Div : IDisposable
    {
        private StringBuilder sb;

        public Div(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string[] data = null)
        {
            this.sb = sb;
            string output = @"<div";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            if (data != null)
            {
                foreach (var e in data)
                {
                    if (string.IsNullOrWhiteSpace(e)) continue;
                    var keyValue = e.Split('=');
                    var dataKey = keyValue[0];
                    var dataValue = (keyValue.Length > 0) ? keyValue[1] : "";
                    output += @" data-" + dataKey + @"=""" + dataValue + @"""";
                }
            }
            output += ">";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</div>");
        }
    }

    public sealed class Fieldset : IDisposable
    {
        private StringBuilder sb;

        public Fieldset(StringBuilder sb = null, string id = null, string @class = null, string style = null, string dataBind = null, string legend = null)
        {
            this.sb = sb;
            string output = @"<fieldset";
            if (id != null) output += @" id=""" + id + @"""";
            if (@class != null) output += @" class=""" + @class + @"""";
            if (style != null) output += @" style=""" + style + @"""";
            if (dataBind != null) output += @" data-bind=""" + dataBind + @"""";
            output += ">";
            if (legend != null) output += "<legend>" + legend + @"</legend>";
            sb.Append(output);
        }

        public void Dispose()
        {
            sb.Append(@"</fieldset>");
        }
    }

    public sealed class Head : IDisposable
    {
        private StringBuilder sb;

        public Head(StringBuilder sb = null)
        {
            this.sb = sb;
            sb.Append(@"<head>");
        }

        public void Dispose()
        {
            sb.Append(@"</head>");
        }
    }
}