using Anonymous_Response.Controllers;
using NUnit.Framework;

namespace Anonymous_Response.test
{
    [TestFixture]
    public class When_getting_data
    {
        [Test]
        public void Should_return_id_in_reponse()
        {
            var target = new DataController();

            dynamic response = target.Get();

            dynamic content = response.Content;

            Assert.That(content.id, Is.EqualTo(1));
        }

        [Test]
        public void Should_return_multiple_values()
        {
            var target = new DataController();

            dynamic response = target.GetAll();

            dynamic content = response.Content;

            Assert.That(content.items, Is.EquivalentTo(new [] {"1", "2", "3"}));
        }
    }
}
