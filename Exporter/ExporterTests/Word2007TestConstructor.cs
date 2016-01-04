﻿using System;
using System.Configuration;
using ExportImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExporterTests
{

    public partial class Word2007Tests
    {
        [TestClass]
        public class TestConstructor
        {
            [TestMethod]
            public void TestConstructorHeaderWithPerson()
            {
                var t = new Person {Name = "andrei", WebSite = "http://msprogrammer.serviciipeweb.ro/"};
                var excel = new ExportWord2007<Person>();
                Assert.AreEqual(@"<w:tr>
                <w:tc>
                    <w:p>
                        <w:r>
                            <w:rPr>
                                <w:b w:val='on'/>
                                <w:t>
                                      Name
                                </w:t>
                            </w:rPr>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:p>
                        <w:r>
                            <w:rPr>
                                <w:b w:val='on'/>
                                <w:t>
                                      WebSite
                                </w:t>
                            </w:rPr>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:p>
                        <w:r>
                            <w:rPr>
                                <w:b w:val='on'/>
                                <w:t>
                                      CV
                                </w:t>
                            </w:rPr>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>", excel.ExportHeader);
            }

            [TestMethod]
            public void TestConstructorItemWithPerson()
            {
                var t = new Person {Name = "andrei", WebSite = "http://msprogrammer.serviciipeweb.ro/"};
                var excel = new ExportWord2007<Person>();
                Assert.AreEqual(@"<w:tr>
   <w:tc>
    <w:p>
        <w:r>
              <w:t>@Model.Name</w:t>
        </w:r>
    </w:p>
    </w:tc>
   <w:tc>
    <w:p>
        <w:r>
              <w:t>@Model.WebSite</w:t>
        </w:r>
    </w:p>
    </w:tc>
   <w:tc>
    <w:p>
        <w:r>
              <w:t>@Model.CV</w:t>
        </w:r>
    </w:p>
    </w:tc>
</w:tr>", excel.ExportItem);
            }
        }
    }
}