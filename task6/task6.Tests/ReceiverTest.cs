using System;
using Xunit;
using task_DEV6;

namespace task6.Tests
{
    public class ReceiverTest
    {
        [Fact]
        public void AddGoodsTest_NullArgument()
        {
            Goods goods = null;
            Receiver receiver = new Receiver();

            Assert.Throws<InvalidOperationException>(() => receiver.AddGoods(goods));
        }
        

        [Fact]
        public void AddGoodsTest_ValidArgument()
        {
            Goods goods = new Goods("pen", "sunrise",3, 1.4f);
            Receiver receiver = new Receiver();

            Assert.NotNull(receiver.AddGoods(goods));
        }

        [Fact]
        public void GetCountAllTest()
        {
            Goods goods = new Goods("pen", "sunrise", 3, 1.4f);
            Goods goodsG = new Goods("pencil", "sunset", 2, 7f);
            Receiver receiver = new Receiver();
            receiver.AddGoods(goods);
            receiver.AddGoods(goodsG);
            int expected = 5;

            Assert.Equal(expected.ToString(),receiver.GetCountAll().ToString());
        }

        [Fact]
        public void GetCountTypesTest()
        {
            Goods goods = new Goods("pen", "sunrise", 3, 1.4f);
            Goods goodsG = new Goods("pencil", "sunset", 2, 7f);
            Receiver receiver = new Receiver();
            receiver.AddGoods(goods);
            receiver.AddGoods(goodsG);
            int expected = 2;

            Assert.Equal(expected.ToString(), receiver.GetCountTypes().ToString());
        }

        [Fact]
        public void GetAveragePriceTest()
        {
            Goods goods = new Goods("pen", "sunrise", 3, 1.4f);
            Goods goodsG = new Goods("pencil", "sunset", 2, 7.2f);
            Receiver receiver = new Receiver();
            receiver.AddGoods(goods);
            receiver.AddGoods(goodsG);
            float expected = 3.72f;

            Assert.Equal(expected.ToString(), receiver.GetAveragePrice().ToString());
        }

        [Fact]
        public void GetAveragePriceTypeTest_TypeIsNull()
        {
            String type = String.Empty;
            Receiver receiver = new Receiver();

            Assert.Throws<ArgumentNullException>(() => receiver.GetAveragePrice(type));
        }

        [Fact]
        public void GetAveragePriceTypeTest()
        {
            Goods goods = new Goods("pen", "sunrise", 3, 1.4f);
            Goods goodsG = new Goods("pencil", "sunset", 2, 7.2f);
            String type = "pen";
            Receiver receiver = new Receiver();
            receiver.AddGoods(goods);
            receiver.AddGoods(goodsG);
            float expected = 1.4f;

            Assert.Equal(expected.ToString(), receiver.GetAveragePrice(type).ToString());
        }
    }
}
