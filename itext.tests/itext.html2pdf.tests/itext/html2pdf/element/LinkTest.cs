/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2017 iText Group NV
    Authors: iText Software.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS

    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
    http://itextpdf.com/terms-of-use/

    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.

    In accordance with Section 7(b) of the GNU Affero General Public License,
    a covered work must retain the producer line in every PDF that is created
    or manipulated using iText.

    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the iText software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving PDFs on the fly in a web application, shipping iText with a closed
    source product.

    For more information, please contact iText Software Corp. at this
    address: sales@itextpdf.com */
using System;
using System.IO;
using iText.Html2pdf;
using iText.IO.Util;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Versions.Attributes;
using iText.Kernel;
using iText.Test;

namespace iText.Html2pdf.Element {
    public class LinkTest : ExtendedITextTest {
        public static readonly String sourceFolder = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/html2pdf/element/LinkTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/html2pdf/element/LinkTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            CreateDestinationFolder(destinationFolder);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest01() {
            System.Console.Out.WriteLine("html: file:///" + UrlUtil.ToNormalizedURI(sourceFolder + "linkTest01.html").
                AbsolutePath + "\n");
            PdfDocument outDoc = new PdfDocument(new PdfWriter(destinationFolder + "linkTest01.pdf"));
            outDoc.SetTagged();
            HtmlConverter.ConvertToPdf(new FileStream(sourceFolder + "linkTest01.html", FileMode.Open, FileAccess.Read
                ), outDoc);
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest01.pdf", sourceFolder
                 + "cmp_linkTest01.pdf", destinationFolder, "diff01_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest02() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "linkTest02.html"), new FileInfo(destinationFolder 
                + "linkTest02.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest02.pdf", sourceFolder
                 + "cmp_linkTest02.pdf", destinationFolder, "diff02_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest03() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "linkTest03.html"), new FileInfo(destinationFolder 
                + "linkTest03.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest03.pdf", sourceFolder
                 + "cmp_linkTest03.pdf", destinationFolder, "diff03_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("DEVSIX-936")]
        public virtual void LinkTest04() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "linkTest04.html"), new FileInfo(destinationFolder 
                + "linkTest04.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest04.pdf", sourceFolder
                 + "cmp_linkTest04.pdf", destinationFolder, "diff04_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest05() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "linkTest05.html"), new FileInfo(destinationFolder 
                + "linkTest05.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest05.pdf", sourceFolder
                 + "cmp_linkTest05.pdf", destinationFolder, "diff05_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest06() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "linkTest06.html"), new FileInfo(destinationFolder 
                + "linkTest06.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest06.pdf", sourceFolder
                 + "cmp_linkTest06.pdf", destinationFolder, "diff06_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest07() {
            PdfDocument outDoc = new PdfDocument(new PdfWriter(destinationFolder + "linkTest07.pdf"));
            outDoc.SetTagged();
            HtmlConverter.ConvertToPdf(new FileStream(sourceFolder + "linkTest07.html", FileMode.Open, FileAccess.Read
                ), outDoc);
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest07.pdf", sourceFolder
                 + "cmp_linkTest07.pdf", destinationFolder, "diff07_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest08() {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(destinationFolder + "linkTest08.pdf"));
            pdfDocument.SetTagged();
            HtmlConverter.ConvertToPdf(new FileStream(sourceFolder + "linkTest08.html", FileMode.Open, FileAccess.Read
                ), pdfDocument, new ConverterProperties().SetBaseUri(sourceFolder));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest08.pdf", sourceFolder
                 + "cmp_linkTest08.pdf", destinationFolder, "diff08_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void LinkTest09() {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(destinationFolder + "linkTest09.pdf"));
            pdfDocument.SetTagged();
            HtmlConverter.ConvertToPdf(new FileStream(sourceFolder + "linkTest09.html", FileMode.Open, FileAccess.Read
                ), pdfDocument, new ConverterProperties().SetBaseUri(sourceFolder));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "linkTest09.pdf", sourceFolder
                 + "cmp_linkTest09.pdf", destinationFolder, "diff09_"));
        }
    }
}
