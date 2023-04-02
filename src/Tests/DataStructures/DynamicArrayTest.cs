using Main.DataStuctures;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DataStructures
{
    public class DynamicArrayFixture
    {
        public DynamicArray<string> DA { get; set; }
        public DynamicArrayFixture()
        {
            DA = new DynamicArray<string>(2);
        }
    }

    public class DynamicArrayTest : IClassFixture<DynamicArrayFixture>
    {
        DynamicArrayFixture fixture;

        DynamicArray<string> Array => this.fixture.DA;

        public DynamicArrayTest(DynamicArrayFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void GetAndSet()
        {
            Array.SetValue(0, "a");
            Assert.Equal("a", Array.GetValue(0));
        }

    }
}
