﻿using System.IO;
using NUnit.Framework;

namespace ExCSS.Tests
{
    [TestFixture]
    public class ImportRuleFixture
    {
        [Test]
        public void Parser_Reads_Imports()
        {
            //var parser = new Parser(File.OpenRead(@"C:\Everything\Source\git\ExCSS\ExCSS.Tests\Stylesheets\test.css"));
            var parser = new Parser();
            var css = parser.Parse("selector.class:pseudo-class {property:Term;}");

            var ch = css.CharsetDirectives;
            var ff = css.FontFaceDirectives;
            var im = css.ImportDirectives;
           
            var kf = css.KeyframeDirectives;
            var kfo = kf[0];
            var me = css.MediaDirectives;
            var ns = css.NamespaceDirectives;
            var x = css.PageDirectives;
            var y = css.SupportsDirectives;
        }
    }
}
