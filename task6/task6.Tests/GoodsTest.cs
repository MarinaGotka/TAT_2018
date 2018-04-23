using System;
using Xunit;
using task_DEV6;

namespace task6.Tests
{
    public class GoodsTest
    {
        [Fact]
        public void GoodsTest_NullArgumentType()
        {
            string type = String.Empty;
            string name = "sunrise";
            int count = 1;
            float cost = 4.6F;

            Assert.Throws<ArgumentNullException>(() => new Goods(type, name, count, cost));
        }

        [Fact]
        public void GoodsTest_NullArgumentName()
        {
            string type = "pen";
            string name = String.Empty;
            int count = 1;
            float cost = 4.6f;

            Assert.Throws<ArgumentNullException>(() => new Goods(type, name, count, cost));
        }

        [Fact]
        public void GoodsTest_ArgumentICostIsNegative()
        {
            string type = "pen";
            string name = "sunrise";
            int count = 1;
            float cost = -3;

            Assert.Throws<ArgumentException>(() => new Goods(type, name, count, cost));
        }

        [Fact]
        public void GoodsTest_ArgumentCountEqualsZero()
        {
            string type = "pen";
            string name = "sunrise";
            int count = 0;
            float cost = 2.1f;

            Assert.Throws<ArgumentException>(() => new Goods(type, name, count, cost));
        }

        [Fact]
        public void GoodsTest_ValidArgument()
        {
            string type = "pen";
            string name = "sunrise";
            int count = 1;
            float cost = 2.5f;

            Goods goods = new Goods(type, name, count, cost);

            Assert.NotNull(goods);
        }
    }
}
