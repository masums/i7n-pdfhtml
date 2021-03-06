/*
This file is part of the iText (R) project.
Copyright (c) 1998-2018 iText Group NV
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
address: sales@itextpdf.com
*/
using System;
using System.IO;
using iText.Html2pdf;
using iText.Kernel.Utils;
using iText.Test;

namespace iText.Html2pdf.Element {
    public class SpanTest : ExtendedITextTest {
        public static readonly String sourceFolder = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/html2pdf/element/SpanTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/html2pdf/element/SpanTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            CreateDestinationFolder(destinationFolder);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest01() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest01.html"), new FileInfo(destinationFolder 
                + "spanTest01.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest01.pdf", sourceFolder
                 + "cmp_spanTest01.pdf", destinationFolder, "diff01_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest02() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest02.html"), new FileInfo(destinationFolder 
                + "spanTest02.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest02.pdf", sourceFolder
                 + "cmp_spanTest02.pdf", destinationFolder, "diff02_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest03() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest03.html"), new FileInfo(destinationFolder 
                + "spanTest03.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest03.pdf", sourceFolder
                 + "cmp_spanTest03.pdf", destinationFolder, "diff03_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest04() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest04.html"), new FileInfo(destinationFolder 
                + "spanTest04.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest04.pdf", sourceFolder
                 + "cmp_spanTest04.pdf", destinationFolder, "diff04_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest05() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest05.html"), new FileInfo(destinationFolder 
                + "spanTest05.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest05.pdf", sourceFolder
                 + "cmp_spanTest05.pdf", destinationFolder, "diff05_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest06() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest06.html"), new FileInfo(destinationFolder 
                + "spanTest06.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest06.pdf", sourceFolder
                 + "cmp_spanTest06.pdf", destinationFolder, "diff06_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest07() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest07.html"), new FileInfo(destinationFolder 
                + "spanTest07.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest07.pdf", sourceFolder
                 + "cmp_spanTest07.pdf", destinationFolder, "diff07_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest08() {
            // TODO DEVSIX-1438
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest08.html"), new FileInfo(destinationFolder 
                + "spanTest08.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest08.pdf", sourceFolder
                 + "cmp_spanTest08.pdf", destinationFolder, "diff08_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest09() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest09.html"), new FileInfo(destinationFolder 
                + "spanTest09.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest09.pdf", sourceFolder
                 + "cmp_spanTest09.pdf", destinationFolder, "diff09_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest10() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest10.html"), new FileInfo(destinationFolder 
                + "spanTest10.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest10.pdf", sourceFolder
                 + "cmp_spanTest10.pdf", destinationFolder, "diff10_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void SpanTest11() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest11.html"), new FileInfo(destinationFolder 
                + "spanTest11.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest11.pdf", sourceFolder
                 + "cmp_spanTest11.pdf", destinationFolder, "diff11_"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("DEVSIX-2118")]
        public virtual void SpanTest12() {
            HtmlConverter.ConvertToPdf(new FileInfo(sourceFolder + "spanTest12.html"), new FileInfo(destinationFolder 
                + "spanTest12.pdf"));
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(destinationFolder + "spanTest12.pdf", sourceFolder
                 + "cmp_spanTest12.pdf", destinationFolder, "diff12_"));
        }
    }
}
